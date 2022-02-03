using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace reverbsears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Разработчик - https://lolz.guru/members/433571/ ||| Скупаю логи reverb.com\nВведите свой запрос: ");
            string st = Console.ReadLine();
            string[] files = Directory.GetFiles(Environment.CurrentDirectory, "Passwords.txt", SearchOption.AllDirectories);
            foreach (var item in files)
            {
                string[] fl = File.ReadAllLines(item);
                foreach (var strfile in fl)
                {
                    if (strfile.Contains(st))
                    {
                        Zip(item.Replace(item.Split('\\')[item.Split('\\').Length-1],""));
                    }
                    
                }
            }
            Console.ReadKey();
        }
        static void Zip(string path)
        {
            ZipFile.CreateFromDirectory(path, "save/"+ path.Split('\\')[path.Split('\\').Length - 2]+ ".zip");
            //ZipFile.ExtractToDirectory(zipPath, path);
            Console.WriteLine(path);
        }
    }
}
