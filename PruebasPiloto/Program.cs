using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPiloto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numeros = 0, NumMax, Pos;
            const int VUELTAS = 10;
            bool BanMax = false;

            Pos = 0;
            NumMax = 0;

            for (int i = 0; i < VUELTAS; i++)
            {
                PedirDatos(ref Numeros);

                if(!BanMax)
                {
                    NumMax = Numeros;
                    BanMax = true;
                    Pos = i + 1;
                }
                else if (Numeros > NumMax)
                {
                    NumMax = Numeros;
                    Pos = i + 1;
                }
                    

                
            }

            Console.WriteLine("El numero mas grande ingresado fue: " + NumMax + "En la posicion: " + Pos);
            Console.ReadKey();


        }

        static void PedirDatos(ref int j)
        {
            Console.WriteLine("Ingrese numeros por favor: ");

            j = int.Parse(Console.ReadLine());
        }
    }
}