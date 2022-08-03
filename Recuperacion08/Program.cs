using System;

namespace Recuperacion08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio 08";
            Console.Write("Ingrese la temperatura en grados centígrados:");
            var celsius = float.Parse(Console.ReadLine());
            var reaumur = ConvertirAReaumur(celsius);
            //var fahrenheit = ConvetirAFahrenheit(celsius);
            Console.WriteLine($"{celsius} grados Celsius equivalen a {reaumur} grados Reaumur");
            Console.WriteLine($"{celsius} grados Celsius equivalen a {ConvetirAFahrenheit(celsius)} grados Fahrenheit");

        }

        private static float ConvetirAFahrenheit(float grados) => 1.8f * grados + 32;

        private static float ConvertirAReaumur( float grados)
        {
            return 0.8f * grados;
        }
    }
}
