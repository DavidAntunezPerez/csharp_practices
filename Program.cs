using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasDAP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get circle area from its radius
            Console.WriteLine("Introduzca un radio para el circulo: ");
            // int radius = Convert.ToInt32(Console.ReadLine()); // Another way of converting Int
            int radius = int.Parse(Console.ReadLine());
            double area = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine($"El area del circulo de {radius} cm es {area} cm^2");
        }
    }
}
