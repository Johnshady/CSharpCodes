using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\Student\Downloads";

            //string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories );

            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir); 
            //}



            //helps dives deep into any subfolder

            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

            //foreach (string file in files)
            //{
            //    //Console.WriteLine(file);
            //    //Console.WriteLine(Path.GetFileName(file));
            //    //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //    //Console.WriteLine(Path.GetFullPath(file));


            //    //information about a file like wanting to know how big a file is (i.e file size)
            //    var info = new FileInfo(file);
            //    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");

            //}

            //Creating automation task with c#
            //1. verifying if a directory exist
            //bool directoryExists = Directory.Exists(@"C:\Users\Student\Downloads\SubFolderC");

            //if (directoryExists)
            //{
            //    Console.WriteLine("The directory exists");
            //}
            //else
            //{
            //    Console.WriteLine("The directory does not exist");
            //}

            // creating a new folder or sub folder
            //string newPath = @"C:\Users\Student\Downloads\SubFolderC\SubSubFolderD";

            //// Maybe you dont care if a directory exist or not like you just want to create a new file
            //Directory.CreateDirectory(newPath);


            //bool directoryExists = Directory.Exists(newPath);

            //if (directoryExists)
            //{
            //    Console.WriteLine("The directory exists");
            //}
            //else
            //{
            //    Console.WriteLine("The directory does not exist");
            //    Directory.CreateDirectory(newPath);
            //}



            //FILE
            //1.COPYING FILES

            //string[] files = Directory.GetFiles(rootPath);
            //string destinationFolder = @"C:\Users\Student\Downloads\SubFolderC\";

            //foreach (string file in files)
            //{
            //    File.Copy(file, $"{destinationFolder}{ Path.GetFileName(file) }", true);
            //}

            //for (int i = 0; i < files.Length; i++)
            //{
            //    File.Copy(files[i], $"{destinationFolder}{i}.txt", true);
            //}

            //2. MOVING FILES

            //foreach (string file in files)
            //{
            //    File.Move(file, $"{destinationFolder}{Path.GetFileName(file)}");
            //}


            //3. SEARCHING FOR SPECIFIC KIND OF FILES OR FOLDERS(I.E FILE TYPE)

            var files = Directory.GetFiles(rootPath, "*folder*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
                //Console.WriteLine(Path.GetFileName(file));
                //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                //Console.WriteLine(Path.GetFullPath(file));


                //information about a file like wanting to know how big a file is (i.e file size)
                //var info = new FileInfo(file);
                //Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");

            }
            Console.ReadLine();
        }
    }
}
