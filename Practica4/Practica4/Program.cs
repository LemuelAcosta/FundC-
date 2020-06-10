using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Ejercicio 1");
            int num = 1;
            Console.WriteLine("Digite un numero");
            num = Convert.ToInt32(Console.ReadLine());

            num = (2 * num) / 2;
            Console.WriteLine("El valor absoluto es {0}", num);

            Console.WriteLine("Ejercicio 2");

            int n1;
            int n2;
            Console.WriteLine("Digite un numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite un segundo numero");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2){Console.WriteLine("El mayor es: {0}", n1);}
            else { Console.WriteLine("El mayor es: {0}", n2); }

            Console.WriteLine("Ejercicio 3");
            string a;
            Console.WriteLine("Digite un caracter");
            a = Console.ReadLine();
            int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0  };
            if (a == nums) { Console.WriteLine("El caracter es un numero"); }
            else { Console.WriteLine("El caracter es un signo de puntuacion o algun otro"); }

            Console.WriteLine("Ejercicio 4");
            char b;
            Console.WriteLine("Digite un caracter");

            Console.WriteLine("Perdon profesor por no entregar completo, es que hoy tuve el dia muy cansado y no pude, se la puedo entregar manana para la tarde si esta dentro de lo posible, gracias por comprender");



        }
    }
}
