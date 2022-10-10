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
            Practica1();
            Practica2();
        }
        #region Practica 1
        static void Practica1()
        {
            Console.WriteLine("Práctica 1:");
            // get circle area from its radius
            Console.WriteLine("Introduzca un radio para el circulo: ");
            // int radius = Convert.ToInt32(Console.ReadLine()); // Another way of converting Int
            int radius = int.Parse(Console.ReadLine());
            double area = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine($"El area del circulo de {radius} cm es {area} cm^2");
        }
        #endregion

        #region Practica 2
        static void Practica2()
        {

        }
        #endregion  
    }
}
