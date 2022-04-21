using System;
using System.IO;
using System.Globalization;
using trainingTwelve.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"C:\Users\cliente\Desktop\c++\Products.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
//FileStrem and StremReader
/* string path = @"C:\Users\cliente\Desktop\texto.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine( "An error  ocurred");
                Console.WriteLine(e.Message);
            }

        }
    }*/
// Path's
/*string path = @"C:\Users\cliente\Desktop\c++\file1.txt";
Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
Console.WriteLine("PathSeparator: " + Path.PathSeparator);
Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
Console.WriteLine("GetFileName: " + Path.GetFileName(path));
Console.WriteLine("GetExtension: " + Path.GetExtension(path));
Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
Console.WriteLine("GetTempPath: " + Path.GetTempPath());*/
//Directorys
/* try
            {
                var folders = Directory.EnumerateDirectories(path, ".", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                var files = Directory.EnumerateFiles(path, ".", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(@"c:C:\Users\cliente\Desktop\c++\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }*/