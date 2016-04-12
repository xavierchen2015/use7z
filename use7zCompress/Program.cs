using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SevenZip;

namespace use7zCompress
{
    class Program
    {
        static void Main(string[] args)
        {
            //壓縮
            //SevenZipCompressor.SetLibraryPath(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "7z.dll"));
            SevenZipCompressor.SetLibraryPath(@"C:\Program Files\7-Zip\7z.dll");
            SevenZipCompressor sevenZipCompressor = new SevenZipCompressor();
            string[] files = { @"D:\WebApiForDidi_Txt\didiSqlStr_20160323_1811.txt" };
            //壓縮種類
            sevenZipCompressor.ArchiveFormat = OutArchiveFormat.Zip;
            sevenZipCompressor.VolumeSize = 0;
            sevenZipCompressor.CompressFiles(@"d:\test.zip", files);
            sevenZipCompressor.CompressDirectory(@"D:\WebApiForDidi_Txt", @"d:\testdddddddd.zip");
            //解壓縮
            SevenZipExtractor sevenZipExtractor = new SevenZipExtractor(@"d:\test.zip");
            sevenZipExtractor.ExtractArchive(@"c:\test");
        }
    }
}
