using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1AnalisisGuia9
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Programa que evalua 9 notas y cuenta cuántas son igual a 8.5";


        Double Grado, notas = 0;

        for (int i = 0; i < 9; i++)
        {
        Console.WriteLine("Ingrese la nota " + (i + 1) + ":");
        Grado = Double.Parse(Console.ReadLine());
                
        if (Grado == 8.5)
        {
        notas = notas + 1;
        }
        }
        
        Console.WriteLine();
        Console.WriteLine("La cantidad de notas igual a 8.5 son: " + notas);


        Console.ReadKey();
        }
        }
    
}
