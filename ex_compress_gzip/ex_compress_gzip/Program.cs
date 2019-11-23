using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Threading;

namespace ex_compress_gzip
{
    class FileBlock
    {
        public byte[] data;
        public int data_size;
        public bool data_compressed;
    }

    public class CompressFile
    {
        private readonly object offsetReadLock = new object();
        private readonly object offsetWriteLock = new object();
        private readonly object compressLock = new object();
        private readonly object decompressLock = new object();
        private int offsetReadIndex;
        private int offsetWriteIndex;
        private int compressIndex;
        private int decompressIndex;
        bool compressed = false;

        private const int size = 1024 * 1014;
        private string filename;        
        private long fileSize;
        private long file_offset;
        private int blockCounts;
        private int readBlockCount = 5;
        private List<FileBlock> blocks;

        public CompressFile()
        {                        
            blocks = new List<FileBlock>();

            offsetReadIndex = 0;
            offsetWriteIndex = 0;
            compressIndex = 0;
            decompressIndex = 0;
            file_offset = 0;
        }

        public int Count
        {
            get { return blocks.Count; }
        }

        public void start_compress(string filename)
        {
            prepare(filename);

            Thread tread1 = new Thread(new ThreadStart(read));
            Thread tcompres1 = new Thread(new ThreadStart(compress));
            Thread twrite1 = new Thread(new ThreadStart(write));

            tread1.Start();
            tcompres1.Start();
            twrite1.Start();            
        }

        public void start_decompress(string filename)
        {
            prepare(filename);

            Thread tread1 = new Thread(new ThreadStart(read));
            Thread tdecompres1 = new Thread(new ThreadStart(decompress));
            //Thread twrite1 = new Thread(new ThreadStart(write_decompressed));

            tread1.Start();
            tdecompres1.Start();
            //twrite1.Start();
        }

        public void prepare(string filename)
        {
            clear();

            this.filename = filename;

            FileInfo fileInfo = new FileInfo(filename);

            fileSize = fileInfo.Length;

            blockCounts = (int)fileInfo.Length / size;   // размер файла - кол-во блоков в 1MB       
        }

        public void clear()
        {
            blocks.Clear();
            compressIndex = 0;
            offsetReadIndex = 0;
            offsetWriteIndex = 0;
            decompressIndex = 0;
            file_offset = 0;
        }

        public void read()
        {
            file_offset = 0;

            Console.WriteLine("Start read file");

            byte[] buffer;

            while (file_offset < fileSize)
            {
                lock (offsetReadLock)
                {                   
                    using (FileStream fileRead = new FileStream(filename, FileMode.Open, FileAccess.Read))
                    {
                        buffer = new byte[size];

                        fileRead.Seek(file_offset, SeekOrigin.Begin);

                        int r = fileRead.Read(buffer, 0, size);

                        file_offset += r-1;

                        lock (compressLock)
                        {
                            blocks.Add(new FileBlock()
                            {
                                data = buffer,
                                data_size = r
                            });
                        }
                    }                    
                }
            }
        }

        public void write()
        {
            file_offset = 0;

            string filename2 = Path.GetFileName(filename) + ".copy";

            Console.WriteLine("Start write file");            

            while (offsetWriteIndex < blocks.Count)
            {
                lock (offsetWriteLock)
                {
                    if (blocks.Count == 0) continue;

                    if (offsetWriteIndex < blocks.Count)
                    {
                        using (FileStream fileWrite = new FileStream(filename2, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fileWrite.Seek(file_offset, SeekOrigin.Begin);

                            fileWrite.Write(blocks[offsetWriteIndex].data, 0, blocks[offsetWriteIndex].data_size);

                            file_offset += blocks[offsetWriteIndex].data_size;

                            //blocks[offsetWriteIndex].data = null;
                        }
                        offsetWriteIndex++;
                    }
                }
            }            
        }        

        public void compress()
        {
            file_offset = 0;

            string filename2 = Path.GetFileName(filename) + ".gzip";

            while (compressIndex < blocks.Count)
            {
                lock (compressLock)
                {                    
                    using (FileStream fileWrite = new FileStream(filename2, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        fileWrite.Seek(file_offset, SeekOrigin.Begin);

                        var memory = new MemoryStream(new byte[size+1024]);

                        using (GZipStream gzip = new GZipStream(memory, CompressionMode.Compress))
                        {
                            gzip.Write(blocks[compressIndex].data, 0, blocks[compressIndex].data_size);

                            file_offset += memory.Length;
                        }
                    }
                    compressIndex++;                    
                }
            }
        }

        public void decompress()
        {
            int r = 0;

            file_offset = 0;

            byte[] buffer = new byte[size];

            string filename2 = Path.GetFileNameWithoutExtension(filename) + ".unzip";

            while (decompressIndex < blocks.Count)
            {
                lock (decompressLock)
                {
                    
                    using (FileStream fileWrite = new FileStream(filename2, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        var memory = new MemoryStream(blocks[decompressIndex].data);

                        using (GZipStream gzip = new GZipStream(memory, CompressionMode.Decompress))
                        {
                            r = gzip.Read(buffer, 0, size);

                            fileWrite.Seek(file_offset, SeekOrigin.Begin);

                            fileWrite.Write(buffer, 0, r);

                            file_offset += r;
                        }
                    }
                    decompressIndex++;
                    
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //string filename1 = "Test1.txt";
            //string filename1 = "Test2.txt";
            //string filename1 = "Test3.fb2";
            string filename1 = "Test4.fb2";

            string filename2 = $"{filename1}.gzip";

            CompressFile compress = new CompressFile();
            
            Console.WriteLine("Compress file");
            compress.prepare(filename1);
            compress.read();
            compress.write();
            compress.compress();
            
            Console.WriteLine("Deompress file");
            compress.prepare(filename2);
            compress.read();
            compress.decompress();
        }
    }
}
