using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Tarea1_Progra2_JoseChan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic[,] matriz = new dynamic[6, 2];
            
            //Titulos de la tabla
            matriz[0, 0] = "Nombre del Estudiante";
            matriz[0, 1] = "Nota del Estudiante";

            //Ingresar Nombre de Estudiante y su Nota
            for (int y = 1; y < 6; y++)
            {
                Console.Write("Ingrese Nombre del Estudiante " + y + ": ");
                string nombre = Console.ReadLine();
                matriz[y, 0] = nombre;

                Console.Write("Ingrese la Nota del Estudiante " + nombre + ": ");
                double nota = Convert.ToDouble(Console.ReadLine());
                matriz[y, 1] = nota;
            }

            //Mostrar encabezado
            Console.WriteLine();
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            
            //Mostrar los datos
            for (int i = 1; i < matriz.GetLength(0); i++)
            {
                string nombre = matriz[i, 0];
                double nota = matriz[i, 1];
 
                Console.Write(nombre + "\t\t\t");

                if (nota < 65)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write(nota + "\t\t");
                
                //Reseteamos el color a gris
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
        }
    }
}
