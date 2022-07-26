using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileMoverApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\Student\Downloads";


            string newPath = @"C:\Users\Student\Downloads\Images";

            bool directoryExists = Directory.Exists(newPath);

            if (directoryExists)
            {
                Console.WriteLine("Image Folder exists");
            }
            else
            {
                Console.WriteLine("Image Folder does not exist");
                Directory.CreateDirectory(newPath);
            }


            var files = Directory.GetFiles(rootPath, "*.jpg", SearchOption.AllDirectories);
            string destinationFolder = @"C:\Users\Student\Downloads\Images\";


            foreach (string file in files)
            {

                bool ImageFilesExists = Directory.Exists(rootPath);

                if (ImageFilesExists)
                {

                    Console.WriteLine("Image file exists");
                    File.Move(file, $"{destinationFolder}{Path.GetFileName(file)}");
                    try
                    {
                        using (var stream = new FileStream(file, FileMode.CreateNew))
                        using (var)
                    }
                }
                else
                {

                    Console.WriteLine("Image files does not exist");

                }
            }



            Console.ReadLine();
        }
    }
}



//repeat = Path.GetFileName(file);

//try
//{
//    string repeat;

//    repeat = Path.GetFileName(file);
//}
//catch (FormatException)
//{
//    Console.WriteLine("same image exist");
//}
//catch (Exception err)
//{
//    Console.WriteLine(err);
//}