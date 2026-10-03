using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileAndFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*                                       
            ___         _                                        
             | |_ . _  (_.| _   _| _  _ _   _  _ |_      _  _| | 
             | | )|_)  | ||(-  (_|(_)(-_)  | )(_)|_  \)/(_)| |(.  
                
            except for the path bit. if most of the file is commented out then it iwll work

             */


            //var path = @"c:\temp\somefile.jpg";
            //File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            ////File.Delete(path);
            //if (File.Exists(path))
            //{
            //    //
            //}

            //var content = File.ReadAllText(path);

            //// fileinfo

            //var fileInfo = new FileInfo(path);
            //fileInfo.CopyTo(@"c:\temp\");
            ////fileInfo.Delete();
            //if (fileInfo.Exists)
            //{
            //    //
            //}

            //// directory and directoryInfo

            //Directory.CreateDirectory(@"d:\temp\folder");
            //var files = Directory.GetFiles(@"c:\temp\", "*.*", SearchOption.AllDirectories);

            //foreach (var file in files)
            //{
            //    {
            //        Console.WriteLine(file);
            //    }

            //}

            //var directoryinfo = new DirectoryInfo("...");
            //directoryinfo.GetFiles();
            //directoryinfo.GetFiles();


            // path class // this is the only bit of the code that works

            var otherpath = @"c:\users\anosh\sourrce\repos\csharp\strings\strings.sln";

            var extensionofpath = Path.GetExtension(otherpath); // very quick and easy way to get extension

            Console.WriteLine(extensionofpath);
            Console.WriteLine(Path.GetFileName(otherpath));
            Console.WriteLine(Path.GetFileName(otherpath));
            Console.WriteLine(Path.GetFileNameWithoutExtension(otherpath));
            Console.WriteLine(Path.GetDirectoryName(otherpath));

        }
    }
}
