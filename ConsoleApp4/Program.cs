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
            //legnagyobb terfogatu bolygo
            //Console.WriteLine($"A legnagyobb terfogatu bolygo: {bolygos.OrderByDescending(r => r.terf).First().name}");
            Console.WriteLine($"A legnagobb terogatu bolygo a {bolygos.MaxBy(r => r.terf).name}");

            //bolygo nev kereso
            Console.Write($"Adja meg egy bolygo nevet: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"A {nev} bolygo {(bolygos.Find(r => r.name == nev) == null ? "nem" : "")} talalhato a listaban");



            //holdak szama
            Console.Write($"Adjon meg egy szamot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            //write a script that lists out all of the planets that have moons above the number given by the user
            Console.WriteLine($"A {szam}-nal tobb holdal rendelkezo bolygok: ");
            foreach (var item in bolygos.Where(r => r.holdakszama > szam))
            {
                Console.Write($"'{item.name}',");
            }
            Console.ReadKey();
        }
    }
}