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
            double num;
            Console.Write("Digite un numero: ");
            num = Convert.ToDouble(Console.ReadLine());

            if (num < 0)
            {

                Console.WriteLine("Su valor absoluto es: " + num * -1);

            }
            else
            {
                Console.WriteLine("Su valor absoluto es: " + num);
            }

            Console.WriteLine("Ejercicio 2");

            int n1;
            int n2;
            Console.WriteLine("Digite un numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite un segundo numero");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2) { Console.WriteLine("El mayor es: {0}", n1); }
            else { Console.WriteLine("El mayor es: {0}", n2); }

            Console.WriteLine("Ejercicio 3");
            char a;
            string b;
            Console.WriteLine("Programa para verificar lo que usuario digite");

            Console.Write("Ingrese un caracter del teclado: ");
            a = Convert.ToChar(Console.ReadLine());
            b = Convert.ToString(a);

            if (b == "1" || b == "2 " || b == "3" || b == "4" || b == "5" || b == "6" || b == "7" || b == "8" || b == "9" || b == "0")
            {
                Console.WriteLine("Es un valor numerico");
            }
            else if (b == "{" || b == "}" || b == "." || b == ";" || b == ":" || b == "?" || b == "¿" || b == " ' " || b == " - " || b == "," || b == "!" || b == "(" || b == ")" || b == "`")
            {
                Console.WriteLine("Es un signo de puntuacion");
            }
            else if (b == "+" || b == "-" || b == "*" || b == "/")
            {
                Console.WriteLine("Signo de matematico");
            }
            else
            {
                Console.WriteLine("Es una letra");
            }


            Console.WriteLine("Ejercicio 4");
            char c;

            Console.WriteLine("Introduce una letra");
            c = Convert.ToChar(Console.ReadLine());

            switch (c)
            {
                case ' ':
                    Console.WriteLine("Espacio.");
                    break;
                case '1': goto case '0';
                case '2': goto case '0';
                case '3': goto case '0';
                case '4': goto case '0';
                case '5': goto case '0';
                case '6': goto case '0';
                case '7': goto case '0';
                case '8': goto case '0';
                case '9': goto case '0';
                case '0':
                    Console.WriteLine("Dígito.");
                    break;
                case 'a': goto case 'u';
                case 'e': goto case 'u';
                case 'i': goto case 'u';
                case 'o': goto case 'u';
                case 'u':
                    Console.WriteLine("Es una vocal");
                    break;
                case 'b': goto case 'z';
                case 'c': goto case 'z';
                case 'd': goto case 'z';
                case 'f': goto case 'z';
                case 'g': goto case 'z';
                case 'h': goto case 'z';
                case 'j': goto case 'z';
                case 'k': goto case 'z';
                case 'l': goto case 'z';
                case 'm': goto case 'z';
                case 'n': goto case 'z';
                case 'p': goto case 'z';
                case 'q': goto case 'z';
                case 'r': goto case 'z';
                case 's': goto case 'z';
                case 't': goto case 'z';
                case 'w': goto case 'z';
                case 'x': goto case 'z';
                case 'y': goto case 'z';
                case 'z':
                    Console.WriteLine("Es una consonante");
                    break;
            }
            Console.WriteLine("Ejercicio 5");
            
            Console.WriteLine("Los numero pares del 23 al 7 ");
            for (int cont = 7; cont < 24; cont--) 
            {
                while (cont%2 == 0) 
                {
                    Console.WriteLine(cont);
                }
            }
          
        }
    }
}
