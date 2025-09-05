using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA_8445_NicolasVEga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer3();
            Console.ReadKey();
        }
        static void ejer1()
        {
            string nombre, carrera;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre},bienvenido al curso de Fundamentos de Algoritmos de la carrera de{carrera}");
        }

        static void ejer2()
        {
            Console.WriteLine("\"Nicolas\"");
        }

        static void ejer3()
        {
            Console.Write("Ingrese num 1: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese num 2: ");
            int y = Convert.ToInt32(Console.ReadLine());

            double divi = x / y;

            Console.WriteLine("\nSuma: " + (x + y));
            Console.WriteLine("Resta: " + (x - y));
            Console.WriteLine("Multiplicación: " + (x * y));
            Console.WriteLine("División: " + divi);
        }
    }
}
