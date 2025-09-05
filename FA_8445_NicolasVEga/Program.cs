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
            ejer4();
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

        static void ejer4()
        {
            Console.WriteLine("Ingrese un numero decimal: ");
            double num = Convert.ToDouble(Console.ReadLine());

            double raiz_cuadrada = Math.Sqrt(num);
            int redondeo = (int)Math.Round(num);
            double alCubo = Math.Pow(num, 3);
            double RaizCubica = Math.Pow(1.0 / 3, num);


            Console.WriteLine($"La raiz cuadrada de {num} es: {raiz_cuadrada}");
            Console.WriteLine($"El numero redondeado es: {redondeo}");
            Console.WriteLine($"El numero elevado al cubo es: {alCubo}");
            Console.WriteLine($"La raiz cubica es: {RaizCubica}");
        }
    }
}
