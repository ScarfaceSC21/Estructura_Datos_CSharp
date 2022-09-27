using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Arreglos
{
    /*                                                  ARREGLOS:
    Los arreglos son similares a las variables ya que son grupos de variables y estas variables serán referenciadas por el mismo nombre. 
    Para poder acceder a una variable del arreglo usaremos un número de índice, ya que todas las variables adentro de un arreglo serán de un 
    mismo tipo. Un punto muy importante que no debemos olvidar cuando trabajemos con los arreglos es que éstos están basados en índice cero, 
    esto quiere decir que el primer elemento del arreglo se encuentra en la posición 0, no en la posición 1 como podríamos pensar.
    Para poder trabajar un arreglo, primero es necesario declararlo.
    En la declaración nosotros indicamos su tipo, su nombre y su tamaño. En C# los arreglos son objetos, y deberemos usar new al declararlos.
            tipo[] nombre = new tipo[tamaño];
    Los arreglos tienen una cantidad finita de elementos y ésta se indica en el momento en que se declaran. Cuando intentamos acceder a uno de 
    sus elementos debemos colocar un valor de índice válido y que no exceda el tamaño del arreglo. Un error común con los arreglos es intentar
    acceder a elementos más allá de los que tiene.

     */
    class Program
    {
        static void Main(string[] args)
        {
            /* El programa encontrará el promedio, la calificación más alta y la calificación más baja. Para demostrar que los datos no se pierden 
            al ser guardados en el arreglo haremos cada cálculo en un ciclo diferente:  */

            // Variables necesarias
            /*int cantidad = 0; // Cantidad de alumnos
            int n = 0; // Variable de control de ciclo
            string valor = "";
  
            // Variables para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;// Variable para la calificación mínima
            float maxima = 0.0f; // Variable para la calificación maxima

            // Pedimos la cantidad de alumnos
            Console.Write("Dame la cantidad de alumnos: ");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);
           
            // Creamos el arreglo
            float[] calif = new float[cantidad];
            
            // Capturamos la información
            for (n = 0; n < cantidad; n++)
            {
                Console.Write("Dame la calificación: ");
                valor = Console.ReadLine();
                calif[n] = Convert.ToSingle(valor);
            }

            // Encontramos el promedio
            for (n = 0; n < cantidad; n++)
            {
                suma += calif[n];
            }
            promedio = suma / cantidad;
           
            // Encontramos la calificación mínima
            for (n = 0; n < cantidad; n++)
            {
                if (calif[n] < minima)
                    minima = calif[n];
            }
           
            // Encontramos la calificación maxima
            for (n = 0; n < cantidad; n++)
            {
                if (calif[n] > maxima)
                    maxima = calif[n];
            }

            // Desplegamos los resultados
            Console.WriteLine("El promedio es {0}", promedio);
            Console.WriteLine("La calificación mínima es {0}", minima);
            Console.WriteLine("La calificación máxima es {0}", maxima);*/

            /*Ejemplo:
            Arreglo de 5 elementos de cadenas de caracteres, se inicializara el vector con datos leídos por el teclado. 
            Se copiaran los elementos del vector en otro vector pero en orden inverso, y se mostrara por la pantalla.*/

            string[] ArregloOriginal = new string[5];
            string[] ArregloCopia = new string[5];


            for (int i = 0; i < 5; i++)
            {
                Console.Write("Escribe un dato en el vector en la posicion " + (i + 1) +": ");
                ArregloOriginal[i] = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("Arreglo original: ");
            foreach (string item in ArregloOriginal)
            {
                Console.Write(item + " ");
            }

            int j = 4;
            for (int i = 0; i < 5; i++)
            {
                ArregloCopia[i] = ArregloOriginal[j];
                j--;
            }

            Console.WriteLine();

            Console.WriteLine("Arreglo inverso: ");
            foreach (string item in ArregloCopia)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
