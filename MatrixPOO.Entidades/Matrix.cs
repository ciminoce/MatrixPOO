using System;
using System.Text;

namespace MatrixPOO.Entidades
{
    public class Matrix
    {
        private int[,] numeros;

        public Matrix()
        {
            numeros = new int[5, 5];
            PopularElementos();
        }

        private void PopularElementos()
        {
            Random r = new Random();
            for (int fila = 0; fila < numeros.GetLength(0); fila++)
            {
                for (int columna = 0; columna < numeros.GetLength(1); columna++)
                {
                    numeros[fila, columna] = r.Next(1, 21);
                }
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            for (int fila = 0; fila < numeros.GetLength(0); fila++)
            {
                for (int columna = 0; columna < numeros.GetLength(1); columna++)
                {
                    sb.Append($"{numeros[fila, columna].ToString().PadLeft(2,'0')} ");
                }

                sb.AppendLine("");
            }

            return sb.ToString();
        }

        public void OrdenarPorColumna()
        {
            for (int columna = 0; columna < numeros.GetLength(1); columna++)
            {
                for (int i = 0; i < numeros.GetLength(0); i++)
                {
                    for (int j = i+1; j <= numeros.GetLength(0)-1; j++)
                    {
                        if (numeros[i,columna]>numeros[j,columna])
                        {
                            var aux = numeros[i, columna];
                            numeros[i, columna] = numeros[j, columna];
                            numeros[j, columna] = aux;
                        }
                    }
                }
            }
        }

        public int this[int fila, int columna]
        {
            get
            {
                if (fila<numeros.GetLength(0) && columna<numeros.GetLength(1))
                {
                    return numeros[fila, columna];
                }

                throw new ArgumentOutOfRangeException(null, "Fila o columna fuera del rango permitido");
            }
        }
    }
}
