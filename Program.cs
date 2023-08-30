using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero del primer semestre del año 1 al 6: \n");
            
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number) {
                case 1:
                    Console.WriteLine("\nEl mes de Enero es el " + number);
                    break;
                case 2:
                    Console.WriteLine("\nEl mes de Febrero es el " + number);
                    break;
                case 3:
                    Console.WriteLine("\nEl mes de Marzo es el " + number);
                    break;
                case 4:
                    Console.WriteLine("\nEl mes de Abril es el " + number);
                    break;
                case 5:
                    Console.WriteLine("\nEl mes de Mayo es el " + number);
                    break;
                case 6:
                    Console.WriteLine("\nEl mes de Junio es el " + number);
                    break;
                default:
                    Console.WriteLine("\nAdvertencia: Se ingrese un numero que no corresponde a un mes del 1 al 6");
                    break;
            }
        }
    }
}