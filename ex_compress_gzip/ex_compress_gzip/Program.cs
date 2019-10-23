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
        public int file_offset;
        public bool data_compressed;
    }

    class CompressFile
    {
        private readonly object offsetReadLock = new object();
        private readonly object offsetWriteLock = new object();
        private readonly object compressLock = new object();
        private readonly object decompressLock = new object();
        private int offsetRead;
        private int offsetWrite;
        private int compressIndex;
        private int decompressIndex;

        private const int size = 1024 * 1014;
        private string filename;
        private string filename2;
        private long fileSize;
        private int blockCounts;
        private int readBlockCount = 5;
        private List<FileBlock> blocks;

        public CompressFile(string filename, string filename2)
        {
            this.filename = filename;
            this.filename2 = filename2;
            blocks = new List<FileBlock>();

            offsetRead = 0;
            offsetWrite = 0;
            compressIndex = 0;
        }

        public void start_compress()
        {
            prepare();

            Thread tread1 = new Thread(new ThreadStart(read));
            Thread tcompres1 = new Thread(new ThreadStart(compress));
            Thread twrite1 = new Thread(new ThreadStart(write));

            tread1.Start();
            tcompres1.Start();
            twrite1.Start();
        }

        public void start_decompress()
        {
            prepare();

            Thread tread1 = new Thread(new ThreadStart(read));
            //Thread tcompres1 = new Thread(new ThreadStart(decompress));
            Thread twrite1 = new Thread(new ThreadStart(write));
        }

        public void prepare()
        {
            FileInfo fileInfo = new FileInfo(filename);

            fileSize = fileInfo.Length;

            blockCounts = (int)fileInfo.Length / size;   // размер файла - кол-во блоков в 1MB            
        }

        public void read()
        {
            Console.WriteLine("Start read file");

            byte[] buffer = new byte[size];

            while (offsetRead <= blockCounts)
            {
                lock (offsetReadLock)
                {                   
                    using (FileStream fileRead = new FileStream(filename, FileMode.Open, FileAccess.Read))
                    {
                        int r = fileRead.Read(buffer, offsetRead*size, size);
                        
                        lock (compressLock)
                        {
                            blocks.Add(new FileBlock()
                            {
                                data = buffer,
                                data_size = r,
                                file_offset = offsetRead * size
                            });
                        }
                    }
                    offsetRead++;
                }
            }
        }

        public void write()
        {
            Console.WriteLine("Start write file");

            byte[] buffer = new byte[size];

            while (offsetWrite <= blockCounts)
            {
                lock (offsetWriteLock)
                {
                    if (blocks.Count == 0) continue;

                    if (offsetWrite <= blocks.Count && blocks[offsetWrite].data_compressed)
                    {
                        using (FileStream fileWrite = new FileStream(filename2, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fileWrite.Write(blocks[offsetWrite].data, blocks[offsetWrite].file_offset, blocks[offsetWrite].data_size);

                            blocks[offsetWrite].data = null;
                        }
                        offsetWrite++;
                    }
                }
            }            
        }        

        public void compress()
        {
            Console.WriteLine("Start compress file");

            while (compressIndex <= blockCounts)
            {
                lock (compressLock)
                {
                    if (blocks.Count == 0) continue;

                    if (compressIndex <= blocks.Count)
                    {
                        using (MemoryStream blockInMemory = new MemoryStream(blocks[compressIndex].data))
                        {
                            using (GZipStream gzip = new GZipStream(blockInMemory, CompressionMode.Compress, true))
                            {
                                gzip.Write(blocks[compressIndex].data, 0, blocks[compressIndex].data_size);

                                blocks[compressIndex].data_compressed = true;
                            }
                        }
                        compressIndex++;
                    }
                }
            }
        }

        public void decompress()
        {
            while (decompressIndex <= blockCounts)
            {
                lock (decompressLock)
                {
                    using (MemoryStream blockInMemory = new MemoryStream(blocks[decompressIndex].data))
                    {
                        using (GZipStream gzip = new GZipStream(blockInMemory, CompressionMode.Decompress, true))
                        {
                            gzip.Write(blocks[decompressIndex].data, 0, blocks[decompressIndex].data_size);
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
            string filename1 = "Task.txt";
            string filename2 = "Task_copy.txt";

            CompressFile compress = new CompressFile(filename1, filename2);

            Console.WriteLine("Read file");

            compress.start_compress();

            /*
            compress.read();

            Console.WriteLine("End.");

            Console.WriteLine("Write file");

            compress.write();

            Console.WriteLine("End.");
            */
            //Console.ReadLine();
        }
    }
}
