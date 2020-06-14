using System;
using System.Security.Cryptography.X509Certificates;

namespace Tarea
{
    class Program
    {
        private static string s;

        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1!");
            int n = 1;
            Console.WriteLine("Tabla del 7");

            while (n != 13) 
            {
                int m = n*7;
                Console.WriteLine("{0} x 7 = {1}", n,m);
                n++;
            }


            Console.WriteLine("Ejercicio 2!");


            int a = 0, num;
            Console.WriteLine("Digite un numero para saber si es primo");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < (num + 1); i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine(num + " No es primo");
            }
            else
            {
                Console.WriteLine(num + " Si es primo");
            }

            Console.WriteLine("Ejercicio 3!");
            string x;
            Console.WriteLine("Digite un numero ");
            x = Console.ReadLine();
            int size = x.Length;
            Console.WriteLine("El numero ingresado tiene {0} digitos.", size);


            Console.WriteLine("Ejercicio 4!");

            bool t = true;
            do
            {
                string s;
                Console.WriteLine("Si desea generar un numero aleatorio presione ENTER, si no, presine s");
                s = Console.ReadLine();
                Random rnd = new Random();
                int rand = rnd.Next(50, 100);
                Console.WriteLine(rand);

                if (s == "s")
                {
                    t = false;
                }
            } while (t != false);


            Console.WriteLine("Ejercicio 5!");

            for (int i = 1; i < 100; i++)
            {

                if (i % 10 == 0)
                {

                    int j = 1;
                    Console.WriteLine(j += 1);
                }
            }

            Console.WriteLine("Ejercicio 6!");

            for (int i = 1; i < 50; i++)
            {

                Console.WriteLine(i);
            }

            // Console.WriteLine("Hay {0} 0", j);









        }
    }
}
