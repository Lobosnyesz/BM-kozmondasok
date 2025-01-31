using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BM_kozmondasok
{
    internal class Program
    {
        static void beolvasas()
        {
           List<string> list1 = new List<string>();
           List<string> list2 = new List<string>();

            StreamReader be1 = new StreamReader("szoveg1.txt");
            StreamReader be2 = new StreamReader("szoveg2.txt");
            string sor1;
            string sor2;
            string[] reszek;
            sor1 = be1.ReadLine();
            sor2 = be2.ReadLine();
            int szam1 = 0;
            int szam2 = 0;
            while(sor1 != null)
            {
                reszek = sor1.Split('.');
                list1.Add(reszek[0]);
                sor1 = be1 .ReadLine();
                szam1++;
            }
            be1.Close();
            while (sor2 != null)
            {
                reszek = sor2.Split('.');
                list2.Add(reszek[0]);
                sor2 = be2.ReadLine();
                szam2++;
            }
            be2 .Close();
            Console.WriteLine("1.feladat");
            Console.WriteLine($"A szoveg1 sorok szama:{szam1}\nA szoveg2 sorok szama:{szam2}");
        }
        
        static void masodik()
        {
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();

            StreamReader be1 = new StreamReader("szoveg1.txt");
            StreamReader be2 = new StreamReader("szoveg2.txt");
            string sor1;
            string sor2;
            string[] reszek;
            sor1 = be1.ReadLine();
            sor2 = be2.ReadLine();
            int szam1 = 0;
            int szam2 = 0;
            while (sor1 != null)
            {
                reszek = sor1.Split('.');
                list1.Add(reszek[0]);
                sor1 = be1.ReadLine();
                szam1++;
            }
            be1.Close();
            while (sor2 != null)
            {
                reszek = sor2.Split('.');
                list2.Add(reszek[0]);
                sor2 = be2.ReadLine();
                szam2++;
            }
            be2.Close();
            List<string> egyesitettlista = new List<string>();
            egyesitettlista.Add(list1[0] + list2[0]);


            string longest = list1[0];
            string longest2 = list2[0];
            foreach (string s in list1)
            {
                if (s.Length > longest.Length)
                {
                    longest = s;
                }
            }
            foreach (string k in list2)
            {
                if (k.Length > longest.Length)
                {
                    longest2 = k;
                }
            }
            
            Console.WriteLine("2.feladat");
            Console.WriteLine($"szoveg1 leghosszabbb sora:{longest}\nszoveg2 leghosszabbb sora:{longest2}");
        }
        static void negyedik()
        {
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();

            StreamReader be1 = new StreamReader("szoveg1.txt");
            StreamReader be2 = new StreamReader("szoveg2.txt");
            string sor1;
            string sor2;
            string[] reszek;
            sor1 = be1.ReadLine();
            sor2 = be2.ReadLine();
            while (sor1 != null)
            {
                reszek = sor1.Split('\n');
                list1.Add(reszek[0]);
                sor1 = be1.ReadLine();
            }
            be1.Close();
            while (sor2 != null)
            {
                reszek = sor2.Split('\n');
                list2.Add(reszek[0]);
                sor2 = be2.ReadLine();
            }
            be2.Close();
            List<string> egyesitettlista = new List<string>();
            egyesitettlista.AddRange(list1);
            egyesitettlista.AddRange(list2);
            egyesitettlista.Sort();
            foreach(string s in egyesitettlista)
                Console.WriteLine(s);
            int spacenelkuli = 0;
            foreach (var s in egyesitettlista)
            {
                foreach (var s2 in s)
                {
                    if(s2 != ' ')
                    spacenelkuli++;
                }
            }
            Console.WriteLine($"A nem szóköz karakterek száma: {spacenelkuli}");

            StreamWriter ki = new StreamWriter("kozmondasok.txt");
            foreach (var s in egyesitettlista)
                { ki.WriteLine(s); }
            ki.WriteLine("-------------------------------");
            ki.WriteLine($"A nem szóköz karakterek száma: {spacenelkuli}");
            ki.Close();
        }

        static void Main(string[] args)
        {
            /*
            Kozmondasok
            BM - 2024.01.28   
            */
            string fejlec = "Kozmondasok";
            Console.WriteLine(fejlec);
            for (int i = 0; i < fejlec.Length; i++) Console.Write('-');
            Console.WriteLine();

            beolvasas();
            masodik();
            negyedik();
            

            Console.WriteLine("kilépéshez nyomjon meg bármit");
            Console.ReadKey();
        }
    }
}
