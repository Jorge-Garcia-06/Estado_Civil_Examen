using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estado_Civil_Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char eCivil;

            Console.WriteLine("Ingrese un Caracter (C, S, V, D)");
            eCivil = char.Parse(Console.ReadLine());

            switch (eCivil)
            {
                case 'c':
                case 'C':
                    Console.WriteLine("Casado");
                    break;

                case 'v':
                case 'V':
                    Console.WriteLine("Casado");
                    break;

                case 's':
                case 'S':
                    Console.WriteLine("Casado");
                    break;

                case 'd':
                case 'D':
                    Console.WriteLine("Casado");
                    break;

                default:
                    Console.WriteLine("No esta permitido");
                    break;

            }
            Console.Write("Pulse ENTER para salir"); Console.ReadLine();
        }
    }
}    