using System;
using System.IO;
using Xunit;
using ex_compress_gzip;

namespace CompressTests
{
    public class CompressUnitTests
    {
        [Fact]
        public void Test1()
        {
            string filename1 = "Test1.txt";
            
            string filename2 = $"{filename1}.gzip";

            CompressFile compress = new CompressFile();

            compress.prepare(filename1);
            compress.read();
            compress.write();
            compress.compress();

            compress.prepare(filename2);
            compress.read();
            compress.decompress();

            FileInfo info = new FileInfo($"{filename1}");
            FileInfo info_copy = new FileInfo($"{filename1}.copy");
            FileInfo info_compress = new FileInfo($"{filename1}.gzip");
            FileInfo info_decompress = new FileInfo($"{filename1}.unzip");

            Assert.Equal(1, compress.Count);

            Assert.Equal(info.Length, info_copy.Length);

            Assert.True(info.Length >= info_compress.Length);

            Assert.Equal(97, info_compress.Length);

            Assert.Equal(info.Length, info_decompress.Length);
        }

        [Fact]
        public void Test2()
        {
            string filename1 = "Test2.txt";

            string filename2 = $"{filename1}.gzip";

            CompressFile compress = new CompressFile();

            compress.prepare(filename1);
            compress.read();
            compress.write();
            compress.compress();

            compress.prepare(filename2);
            compress.read();
            compress.decompress();

            FileInfo info = new FileInfo($"{filename1}");
            FileInfo info_copy = new FileInfo($"{filename1}.copy");
            FileInfo info_compress = new FileInfo($"{filename1}.gzip");
            FileInfo info_decompress = new FileInfo($"{filename1}.unzip");

            Assert.Equal(1, compress.Count);

            Assert.Equal(info.Length, info_copy.Length);

            Assert.True(info.Length >= info_compress.Length);

            Assert.Equal(584, info_compress.Length);

            Assert.Equal(info.Length, info_decompress.Length);
        }

        [Fact]
        public void Test3()
        {
            string filename1 = "Test3.fb2";

            string filename2 = $"{filename1}.gzip";

            CompressFile compress = new CompressFile();

            compress.prepare(filename1);
            compress.read();
            compress.write();
            compress.compress();

            compress.prepare(filename2);
            compress.read();
            compress.decompress();

            FileInfo info = new FileInfo($"{filename1}");
            FileInfo info_copy = new FileInfo($"{filename1}.copy");
            FileInfo info_compress = new FileInfo($"{filename1}.gzip");
            FileInfo info_decompress = new FileInfo($"{filename1}.unzip");

            Assert.Equal(2, compress.Count);

            Assert.Equal(info.Length, info_copy.Length);

            Assert.True(info.Length >= info_compress.Length);

            Assert.Equal(1300461, info_compress.Length);

            Assert.Equal(info.Length, info_decompress.Length);
        }

        [Fact]
        public void Test4()
        {
            string filename1 = "Test4.fb2";

            string filename2 = $"{filename1}.gzip";

            CompressFile compress = new CompressFile();

            compress.prepare(filename1);
            compress.read();
            compress.write();
            compress.compress();

            compress.prepare(filename2);
            compress.read();
            compress.decompress();

            FileInfo info = new FileInfo($"{filename1}");
            FileInfo info_copy = new FileInfo($"{filename1}.copy");
            FileInfo info_compress = new FileInfo($"{filename1}.gzip");
            FileInfo info_decompress = new FileInfo($"{filename1}.unzip");

            Assert.Equal(19, compress.Count);

            Assert.Equal(info.Length, info_copy.Length);

            Assert.True(info.Length >= info_compress.Length);

            Assert.Equal(18702654, info_compress.Length);

            Assert.Equal(info.Length, info_decompress.Length);
        }

        [Fact]
        public void Test5()
        {
            string filename1 = "Test5.fb2";

            string filename2 = $"{filename1}.gzip";

            CompressFile compress = new CompressFile();

            compress.prepare(filename1);
            compress.read();
            compress.write();
            compress.compress();

            compress.prepare(filename2);
            compress.read();
            compress.decompress();

            FileInfo info = new FileInfo($"{filename1}");
            FileInfo info_copy = new FileInfo($"{filename1}.copy");
            FileInfo info_compress = new FileInfo($"{filename1}.gzip");
            FileInfo info_decompress = new FileInfo($"{filename1}.unzip");

            Assert.Equal(22, compress.Count);

            Assert.Equal(info.Length, info_copy.Length);

            Assert.True(info.Length >= info_compress.Length);

            Assert.Equal(21889484, info_compress.Length);

            Assert.Equal(info.Length, info_decompress.Length);
        }

        [Fact]
        public void Test6()
        {
            string filename1 = "Test6.pdf";

            string filename2 = $"{filename1}.gzip";

            CompressFile compress = new CompressFile();

            compress.prepare(filename1);
            compress.read();
            compress.write();
            compress.compress();

            compress.prepare(filename2);
            compress.read();
            compress.decompress();

            FileInfo info = new FileInfo($"{filename1}");
            FileInfo info_copy = new FileInfo($"{filename1}.copy");
            FileInfo info_compress = new FileInfo($"{filename1}.gzip");
            FileInfo info_decompress = new FileInfo($"{filename1}.unzip");

            Assert.Equal(74, compress.Count);

            Assert.Equal(info.Length, info_copy.Length);

            Assert.True(info.Length >= info_compress.Length);

            Assert.Equal(76698763, info_compress.Length);

            Assert.Equal(info.Length, info_decompress.Length);
        }

        [Fact]
        public void Test7()
        {
            string filename1 = "Test7.pdf";

            string filename2 = $"{filename1}.gzip";

            CompressFile compress = new CompressFile();

            compress.prepare(filename1);
            compress.read();
            compress.write();
            compress.compress();

            compress.prepare(filename2);
            compress.read();
            compress.decompress();

            FileInfo info = new FileInfo($"{filename1}");
            FileInfo info_copy = new FileInfo($"{filename1}.copy");
            FileInfo info_compress = new FileInfo($"{filename1}.gzip");
            FileInfo info_decompress = new FileInfo($"{filename1}.unzip");

            Assert.Equal(133, compress.Count);

            Assert.Equal(info.Length, info_copy.Length);

            Assert.True(info.Length >= info_compress.Length);
                         
            Assert.Equal(137600118, info_compress.Length);

            Assert.Equal(info.Length, info_decompress.Length);
        }

        [Fact]
        public void Test8()
        {
            string filename1 = "Test8.pdf";

            string filename2 = $"{filename1}.gzip";

            CompressFile compress = new CompressFile();

            compress.prepare(filename1);
            compress.read();
            compress.write();
            compress.compress();

            compress.prepare(filename2);
            compress.read();
            compress.decompress();

            FileInfo info = new FileInfo($"{filename1}");
            FileInfo info_copy = new FileInfo($"{filename1}.copy");
            FileInfo info_compress = new FileInfo($"{filename1}.gzip");
            FileInfo info_decompress = new FileInfo($"{filename1}.unzip");

            Assert.Equal(280, compress.Count);

            Assert.Equal(info.Length, info_copy.Length);

            Assert.True(info.Length >= info_compress.Length);

            Assert.Equal(290443013, info_compress.Length);

            Assert.Equal(info.Length, info_decompress.Length);
        }
    }
}
