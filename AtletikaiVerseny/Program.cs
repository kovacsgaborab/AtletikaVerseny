using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AtletikaiVerseny
{
    class Program
    {
        static List<Atleta> Atletak = new List<Atleta>();


        static void Beolvas()
        {
            StreamReader sr = new StreamReader("tavol.csv");

            while (!sr.EndOfStream)
            {
                Atletak.Add(new Atleta(sr.ReadLine()));
            }
        }

        static void Masodik()
        {
            foreach (var a in Atletak)
            {
                Console.WriteLine($"2. feladat: {a.VezNev}  {a.KerNev} - {a.Ugras}");
            }
        }


        static void Harmadik()
        {
            List<string> egyesuletek = new List<string>();

            foreach (var a in Atletak)
            {
                if (!egyesuletek.Contains(a.Egyesulet))
                {
                    egyesuletek.Add(a.Egyesulet);
                }
            }
        }

        static void Negyedik()
        {
            int max = 0;

            foreach (var a in Atletak)
            {
                if (a.Ugras > max)
                {
                    max = a.Ugras;

                    Console.WriteLine($"4. feladat: {a.VezNev} {a.KerNev} - {max}");
                }
            }

            
        }

        static void Otodik()
        {
            int atlag = 0;

            foreach (var a in Atletak)
            {
                atlag += a.Ugras;
            }
            atlag = atlag / 9;
        }

        static void Hatodik()
        {
            StreamWriter sw = new StreamWriter("versenyzok.txt");
            foreach (var a in Atletak)
            {
                sw.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
            Beolvas();
            Masodik();
            Harmadik();
            Negyedik();
            Otodik();
            Hatodik();

            //foreach (var a in Atletak)
            //{
            //    Console.WriteLine($"{a.Rajtszam} - {a.VezNev} {a.KerNev} - {a.Egyesulet} - {a.Ugras}");
            //}

            Console.ReadLine();
        }
    }
}
