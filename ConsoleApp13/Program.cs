using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        public static void CallNamesList(string path, string[] names)
        {

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < names.Length; i++)
                {
                    sw.WriteLine(names[i]);
                }
            }

        public static void PrintNmaesList(string[] names, string path)
        {
            using (StreamReader sw = new StreamReader(path))
            {
                string str;
                while ((str = sw.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
        }

        public static void ExistsOrNot(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader sw = new StreamReader(path))
                {
                    string str;
                    while ((str = sw.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }

        public static void CreateDir(string path,string path2)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if(!File.Exists(path2))
            {
                File.Create(path2);
            }

            using (StreamWriter sw = new StreamWriter(path2))
            {
                sw.WriteLine("The Kingdom of Armenia reached its height under Tigranes the Great in the 1st century BC and in the year 301 became the first state in the world to adopt Christianity as its official religion.[20][21][22][c] Armenia still recognises the Armenian Apostolic Church, the world's oldest national church, as the country's primary religious establishment.[23][d] The ancient Armenian kingdom was split between the Byzantine and Sasanian Empires around the early 5th century. Under the Bagratuni dynasty, the Bagratid Kingdom of Armenia was restored in the 9th century before falling in 1045. Cilician Armenia, an Armenian principality and later a kingdom, was located on the coast of the Mediterranean Sea between the 11th and 14th centuries.");
            }
        }

        public static void PrintAllLines(string path, string path2)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(path2))
            {
                File.Create(path2);
            }

            using (StreamWriter sw = new StreamWriter(path2))
            {
                sw.WriteLine("The Kingdom of Armenia reached its height under Tigranes the Great in the 1st century BC and in the year 301 became the first state in the world to adopt Christianity as its official religion.[20][21][22][c] Armenia still recognises the Armenian Apostolic Church, the world's oldest national church, as the country's primary religious establishment.[23][d] The ancient Armenian kingdom was split between the Byzantine and Sasanian Empires around the early 5th century. Under the Bagratuni dynasty, the Bagratid Kingdom of Armenia was restored in the 9th century before falling in 1045. Cilician Armenia, an Armenian principality and later a kingdom, was located on the coast of the Mediterranean Sea between the 11th and 14th centuries.");
            }

            using(StreamReader sw = new StreamReader(path2))
            {
                string[] str = File.ReadAllLines(path2);

                for(int i = 0; i < str.Length;i++ )
                {
                    Console.WriteLine(str[i]);
                }
            }
        }

        public static void WriteProgram(string path)
        {
            string[] paths = Directory.GetFiles(path);

            for (int i = 0; i < paths.Length; i++)
            {
                Console.WriteLine(paths[i]);
            }
        }

        public static void PrintNums()
        {

            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Mutqagrvac tivy sxal e");
            }
            finally
            {
                Console.WriteLine("Program End");
            }
        }

        public static void Copy(string path, string path2,string path3)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(path2))
            {
                File.Create(path2);
            }

            using (StreamWriter sw = new StreamWriter(path2))
            {
                sw.WriteLine("The Kingdom of Armenia reached its height under Tigranes the Great in the 1st century BC and in the year 301 became the first state in the world to adopt Christianity as its official religion.[20][21][22][c] Armenia still recognises the Armenian Apostolic Church, the world's oldest national church, as the country's primary religious establishment.[23][d] The ancient Armenian kingdom was split between the Byzantine and Sasanian Empires around the early 5th century. Under the Bagratuni dynasty, the Bagratid Kingdom of Armenia was restored in the 9th century before falling in 1045. Cilician Armenia, an Armenian principality and later a kingdom, was located on the coast of the Mediterranean Sea between the 11th and 14th centuries.");
            }
           
            if (!File.Exists(path3))
            {
                Console.WriteLine("NO exist");
            }
            else
            {
                File.Delete(path3);
            }
        }



        static void Main(string[] args)
        {
            PrintNums();
            string path = @"C:\Users\user\Desktop\New folder (4)\New folder (2)";
            string path2 = @"C:\Users\user\Desktop\New folder (4)\New folder (2)\test1.txt";
            string path3 = @"C:\Users\user\Desktop\New folder (4)\New folder (2)\copy_test.txt";
            Copy(path, path2, path3);
            PrintAllLines(path, path2);
            CreateDir(path, path2);
            string path = @"C:\Users\user\Desktop\New folder (4)\New folder";
            WriteProgram(path);
            string[] names = { "Bob", "Aram", "Ani", "Anna" };
            string path = @"C:\Users\user\Desktop\New folder\names.txt";
            ExistsOrNot(path);
            PrintNmaesList(names, path);
            CallNamesList(path, names);
            Console.ReadLine();
        }
    }
}
