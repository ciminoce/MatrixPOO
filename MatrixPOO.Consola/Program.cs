using System;
using MatrixPOO.Entidades;

namespace MatrixPOO.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello Matrix");
                var matriz = new Matrix();
                Console.WriteLine(matriz.MostrarDatos());
                matriz.OrdenarPorColumna();
                Console.WriteLine(matriz.MostrarDatos());
                var elemento = matriz[3, 3];
                Console.WriteLine(elemento);
                var elemento2 = matriz[10, 10];
                Console.WriteLine(elemento2);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                
            }
            Console.ReadLine();
        }
    }
}
