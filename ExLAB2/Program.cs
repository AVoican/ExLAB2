using System;

namespace ExLAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            Ex3();
        }
        static void Ex1()
        {
            //Scrieti un program care va afica factorialul unui numar n , n fiind citit de la tastatura

            Console.WriteLine("introduceti un numar de la tastatura : ");
            int n = int.Parse(Console.ReadLine());
            int factorialulNumarului = 1 ;
            for(int i=1; i <= n; i++)
            {
                factorialulNumarului = factorialulNumarului * i;
            }
            Console.WriteLine("Factorialul lui n este " + factorialulNumarului);
        }
        static void Ex2()
        {
            /*Sa se scrie un program care citese de la tastatura un sir de n numere naturale si determina
            media aritmetica a celor pare, n fiind citit de la tastatura*/

            Console.WriteLine("introduceti n , n reprezentand cate numere sunt in sir ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 0)
            {
                int mediaAritmeticaNumerePare = 0;
                int counter = 0;
                Console.WriteLine("introduceti numerele din sir ");
                for (int i = 1; i <= n; i++)
                {
                    int x = int.Parse(Console.ReadLine());
                    if (x >= 0 && x%2==0)
                    {
                        mediaAritmeticaNumerePare = mediaAritmeticaNumerePare + x;
                        counter++;
                    }
                    else if (x < 0)
                    {
                        Console.WriteLine("ati introdus un numar negativ in sir, va rog introduceti doar numere naturale");
                    }
                }
                mediaAritmeticaNumerePare = mediaAritmeticaNumerePare / counter;
                Console.WriteLine("media aritmetica a numerelor pare din sir este " + mediaAritmeticaNumerePare);
            }
            else
            {
                Console.WriteLine("ati introdus o valoare invalida");
            }
        }
        static void Ex3()
        {
            //Scrieti un program care va determina daca un numar este sau nu palindrom

            Console.WriteLine("introduceti numarul : ");
            int n = int.Parse(Console.ReadLine());
            int aux = n;
            int oglindit = 0;
            while (aux > 0)
            {
                oglindit = oglindit * 10 + aux % 10;
                aux = aux / 10;
            }
            if (oglindit == n)
            {
                Console.WriteLine("numarul " + n + " este palindrom");
            }
            else
            {
                Console.WriteLine("numarul " + n + " nu este palindrom");
            }
        }
    }
}
