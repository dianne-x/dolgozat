using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bolygo> bolygos = new List<Bolygo>();
            StreamReader sr = new StreamReader(@"..\..\src\solsys.txt");


            while (!sr.EndOfStream)
            {
                bolygos.Add(new Bolygo(sr.ReadLine()));
            }

            Console.WriteLine($"{bolygos.Count} bolygó van a naprendszerben");
            Console.WriteLine($"Egy bolygonak a naprendszerben atlagosan {bolygos.Average(r => r.holdakszama)} holdja van");
            Console.WriteLine($"A legnagyobb terfogatu bolygo a {bolygos.Max(r => r.terf)}");

            Console.ReadKey();
        }
    }
}