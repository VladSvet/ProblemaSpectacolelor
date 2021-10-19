using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemaSpectacolelor
{
    class Program
    {
        static void Schimba(double x, double y)
        {
            double aux;
            aux = x;
            x = y;
            y = aux;
        }
        static void Main(string[] args)
        {
            int n; //numarul de spectacole
            double[] start = new double[100];
            double[] durata = new double[100];
            int i, j;
            double[] a = new double[100]; //permutarea spectacolelor
            double ora_sf; //ora ultimului spectacol
            Console.WriteLine("Problema Spectacolelor");
            Console.WriteLine("**********************");
            Console.WriteLine("Dati numarul de spectacole");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Spectacolul cu numarul " + i + ": ");
                Console.Write(" - Ora de incepere: ");
                start[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write(" - Durata lui: ");
                durata[i] = Convert.ToDouble(Console.ReadLine());
                a[i] = i; //permutarea identica
            }
            // se ordoneaza crescator spectacolele dupa ora de terminare
            for (i = 1; i <= n - 1; i++)
                for (j = i + 1; j <= n; j++)
                {
                    if (start[i] + durata[i] > start[j] + durata[j])
                    {
                        Schimba(start[i], start[j]);
                        Schimba(durata[i], durata[j]);
                        Schimba(a[i], a[j]);
                    }
                }
            Console.WriteLine("Solutie: ");
            ora_sf = start[1] + durata[1];
            Console.WriteLine("Spectacolul " + a[1] + " ");
            i = 2;
            while (i <= n)
            {
                if (ora_sf <= start[i])
                {
                    Console.WriteLine("Spectacolul " + a[i] + " ");
                    ora_sf = start[i] + durata[i];
                }
                i = i + 1;
            }
            Console.ReadLine();
        }
    }
}