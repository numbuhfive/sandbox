using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppTestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists(@"c:\test.txt"))
            {
                Console.WriteLine("File found!!");

            }
        }
               
    }
}
