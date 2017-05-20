using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex1
{
    class Program
    {

        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Амина\Documents\Task1");
            foreach (FileSystemInfo fInfo in directory.GetFileSystemInfos())
            {
                if (fInfo.GetType() == typeof(FileInfo) && fInfo.Name.Contains(".txt"))
                {
                    StreamReader sr = new StreamReader(fInfo.FullName);
                    string[] arr = sr.ReadToEnd().Split();
                    int b = 0;
                    foreach (string i in arr)
                    {
                        int a = int.Parse(i);
                        if (a % 2 == 0)
                        {
                            a = b;
                        }

                    }
                    Console.WriteLine(fInfo.Name + ": "+ a + " ");
                    sr.Close();
                }


           /*  StreamReader sr = new StreamReader(@"C:\Users\Амина\Documents\Task1\file1.txt");
                string[] arr = sr.ReadToEnd().Split();
                for(int i=0; i<arr.Length; i++)
                {
                    int a = int.Parse(arr[i]);
                    if(a % 2 == 0)
                    {
                       a = arr[i];
                    }

                }
            */
                
            }
            
            Console.ReadKey();
        }
    }
}
