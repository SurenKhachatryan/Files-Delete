using System;
using System.IO;

namespace FilesDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the path to the folder");
            var path = Convert.ToString(Console.ReadLine());
            string file = path;
            Console.WriteLine("Please Enter for delete Files");
            Console.ReadLine();
            while (true)
            {
                try
                {
                    Directory.Delete(file, true);
                }
                catch { }
                finally { }
            }
        }
    }
}
