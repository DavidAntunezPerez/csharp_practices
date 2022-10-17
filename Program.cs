using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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
            Practica3();
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
            //Modifica el ejemplo anterior para que cumpla lo siguiente:
            // > Si no es mayor de edad, mostrará el mensaje que indica que no puede
            // conducir.
            // > Si es mayor de edad, mostrará el mensaje que pregunta si tiene carnet y lo
            // comprobará, mostrando el mensaje correspondiente

            Console.WriteLine("DRIVING EVALUATION");
            Console.WriteLine("Please, type your age:");
            int age = int.Parse(Console.ReadLine());

            if(age < 18)
            {
                Console.WriteLine("Sorry, you are too young to drive");
            }
            else
            {
                Console.WriteLine("Do you have driving license?(Y/N)");
                string license = Console.ReadLine().ToUpper();
                if (String.Equals(license, "Y"))
                {
                    Console.WriteLine("You are able to drive");
                }
                else
                {
                    Console.WriteLine("You are not able to drive");
                }
            }

        }
        #endregion

        #region Practica 3
        static void Practica3()
        {
            const string loop = "Y";
            string ans = string.Empty;
            while (!String.Equals(ans,"N")) {
                Console.WriteLine("Do you want to go inside the loop?(Y/N)");
                ans = Console.ReadLine().ToUpper();
                switch (ans)
                {
                    case "Y":
                        while (String.Equals(ans, loop))
                        {
                            Console.WriteLine("Do you want to go inside the loop?(Y/N)");
                            ans = Console.ReadLine().ToUpper();
                        }
                        break;
                    case "N":
                        Console.WriteLine("You didnt went inside the loop.");
                        break;
                    default:
                        Console.WriteLine("Your answer must be Y or N!");
                        break;
                }
            }
            Console.WriteLine("You left the loop.");

        }
        #endregion
    }
}
