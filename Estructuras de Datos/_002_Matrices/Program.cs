using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Matrices
{
    class Program
    {
        /*                                                           MATRIZ:
        El array bidimensional se puede considerar como un vector de vectores. Es, por consiguiente, un conjunto de elementos, todos del mismo tipo, 
        en el cual el orden de los componentes es significativo y en el que se necesita especificar dos subíndices para poder identificar cada elemento del array. 
        En los arreglos de dos dimensiones tenemos que utilizar dos índices. Uno controlará el renglón y el otro la columna. Con la creación de estos dos 
        índices es posible que accedamos a cualquier celda ubicada dentro de la matriz.
        Declaración de los arreglos de dos dimensiones
        La declaración es similar al arreglo de una dimensión, pero indicamos la cantidad de elementos en cada dimensión.
                float[,] tabla = new float[5,3];
        También es posible declarar la matriz por medio de variables.
                float[,] tabla = new float[n, m];

         */
        static void Main(string[] args)
        {
            // El programa encontrará el promedio, la calificación más alta y la calificación más baja:
            /*
             // Variables necesarias
            int cantidad = 0; // Cantidad de alumnos
            int salones = 0; // Cantidad de salones
            int n = 0; // Variable de control de ciclo salones
            int m = 0; // Variable de control del ciclo alumnos
            string valor = "";

            // Variables para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;// Variable para la calificación mínima
            float maxima = 0.0f; // Variable para la calificación maxima
            
            // Pedimos la cantidad de salones
            Console.Write("Dame la cantidad de salones: ");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);

            // Pedimos la cantidad de alumnos
            Console.Write("Dame la cantidad de alumnos por salon: ");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);
            
            // Creamos el arreglo
            float[,] calif = new float[salones, cantidad];
            
            // Capturamos la información
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                Console.WriteLine("Salon {0}", n);
                for (m = 0; m < cantidad; m++) // Ciclo alumnos
                {
                    Console.Write("Dame la calificación: ");
                    valor = Console.ReadLine();
                    calif[n, m] = Convert.ToSingle(valor);
                }
            }

            // Encontramos el promedio
            for (n = 0; n<salones; n++) // Ciclo salones
            {
                for (m = 0; m<cantidad; m++) // Ciclo alumnos
                {
                    suma += calif[n, m];
                }
            }
            promedio = suma / (cantidad * salones);

            // Encontramos la calificación mínima
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                for (m = 0; m < cantidad; m++) // Ciclo alumnos
                {
                    if (calif[n, m] < minima)
                        minima = calif[n, m];
                }
            }
           
            // Encontramos la calificación maxima
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                for (m = 0; m < cantidad; m++) // Ciclo alumnos
                {
                    if (calif[n, m] > maxima)
                        maxima = calif[n, m];
                }
            }

            // Desplegamos los resultados
            Console.WriteLine("El promedio es {0}", promedio);
            Console.WriteLine("La calificación mínima es {0}", minima);
            Console.WriteLine("La calificación máxima es {0}", maxima);
             */

            /*Ejemplo:
            Crea una tabla bidimensional de longitud 5x15 y nombre ‘marco’. Carga la tabla con dos únicos valores 0 y 1, donde el valor uno ocupará 
            las posiciones o elementos que delimitan la tabla, es decir, las más externas, mientras que el resto de los elementos contendrán el valor 0.
            111111111111111
            100000000000001
            100000000000001
            100000000000001
            111111111111111*/
            int[,] matrix = new int[5, 15];
            for(int i = 0; i < 15; i++)
            {
                matrix[0, i] = 1;
                matrix[4, i] = 1;
            }
            matrix[1,0] = 1;
            matrix[1, 14] = 1;
            matrix[2,0] = 1;
            matrix[2, 14] = 1;
            matrix[3, 0] = 1;
            matrix[3, 14] = 1;
            matrix[4, 0] = 1;
            matrix[4, 14] = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }

        Console.ReadKey();
        }
    }
}
