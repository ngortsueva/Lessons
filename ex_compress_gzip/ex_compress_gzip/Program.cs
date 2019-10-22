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
        private List<FileBlock> blocks;

        public CompressFile(string filename, string filename2)
        {
            this.filename = filename;           

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
            /*
            Thread tr2 = new Thread(new ThreadStart(read));
            Thread tr3 = new Thread(new ThreadStart(read));
            Thread tr4 = new Thread(new ThreadStart(read));
            Thread tr5 = new Thread(new ThreadStart(read));
            */
        }

        public void start_decompress()
        {
            prepare();

            Thread tread1 = new Thread(new ThreadStart(read));
            Thread tcompres1 = new Thread(new ThreadStart(decompress));
            Thread twrite1 = new Thread(new ThreadStart(write));
        }

        public void prepare()
        {
            FileInfo fileInfo = new FileInfo(filename);

            long fileSize = fileInfo.Length;

            int blockCounts = (int)fileInfo.Length / size;   // размер файла - кол-во блоков в 1MB

            int[] offsetInFile = new int[blockCounts];         // массив смещений

            for (int i = 0; i < blockCounts; i++)
                offsetInFile[i] = size * (i + 1);
        }

        public void read()
        {
            lock (offsetReadLock)
            {
                byte[] buffer = new byte[size];

                using (FileStream fileRead = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    int r = fileRead.Read(buffer, offsetRead, size);
                    lock (compressLock)
                    {
                        blocks.Add(new FileBlock()
                        {
                            data = buffer,
                            data_size = r,
                            file_offset = offsetRead
                        });
                    }
                }
                offsetRead += size;
            }
        }

        public void write()
        {
            lock (offsetWriteLock)
            {
                byte[] buffer = new byte[size];

                using (FileStream fileWrite = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    fileWrite.Write(blocks[decompressIndex].data);
                    
                }
                offsetWrite += size;
            }


            FileStream file = new FileStream($"{filename}.gzip", FileMode.Create, FileAccess.Write);

            foreach(var item in blocks)
            {
                file.Write(item.data, 0, item.data_size);
            }
            file.Close();
        }        

        public void compress()
        {
            lock (compressLock)
            {
                using (MemoryStream blockInMemory = new MemoryStream(blocks[compressIndex].data) )
                {
                    using (GZipStream gzip = new GZipStream(blockInMemory, CompressionMode.Compress, true))
                    {
                        gzip.Write(blocks[compressIndex].data, 0, blocks[compressIndex].data_size);
                    }
                }
                compressIndex++;
            }
        }

        public void decompress()
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

    class Program
    {
        static void Main(string[] args)
        {
            string filename1 = "Task.txt";
            string filename2 = "Task_copy.txt";

            CompressFile compress = new CompressFile(filename1, filename2);

            Console.WriteLine("Read file");

            compress.read();

            Console.WriteLine("End.");

            Console.WriteLine("Write file");

            compress.write();

            Console.WriteLine("End.");

            Console.ReadLine();
        }
    }
}
