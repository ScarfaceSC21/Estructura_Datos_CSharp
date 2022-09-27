using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Arreglos_Jagged
{
    /*                  Arreglos tipos Jagged
    Los arreglos que hemos visto hasta el momento no permiten tener columnas con diferente cantidad de renglones. Esto puede ser una limitación, 
    y puede significar que tengamos renglones sin utilizar en varias columnas. Esto nos lleva a desperdiciar memoria. Una solución podría ser 
    tener un arreglo que nos permita lograr esto. Para hacerlo tenemos que crear un arreglo de arreglos. Esto se conoce como arreglo jagged.
    En lugar de usar una matriz, lo que haremos es crear un arreglo, pero cada elemento de este arreglo será a su vez otro arreglo. Así podemos 
    controlar de forma independiente la cantidad de renglones en cada arreglo. Estos arreglos son más flexibles que los tradicionales, pero requieren 
    que seamos más cuidadosos con ellos. 
    Declaración de un arreglo jagged
    La declaración de los arreglos jagged es ligeramente más complicada que la de los tradicionales. Cuando los declaramos debemos declarar en primer 
    lugar el arreglo contendor y luego cada uno de los arreglos independientes que tiene.
    Declaramos arreglo contenedor
            int[][] Costos = new int[3][];
    Declaramos los arreglos
            Costos[0] = new int[15];
            Costos[1] = new int[20];
            Costos[2] = new int[10];
     */
    class Program
    {
        static void Main(string[] args)
        {
            /* Ahora modificaremos algunas partes del programa de la escuela para usar el arreglo de tipo jagged. Lo que haremos es tener salones con diferente 
            cantidad de alumnos y luego simplemente mostraremos las calificaciones de cada salón.  */

            // Variables necesarias
            int cantidad = 0; // Cantidad de alumnos
            int salones = 0; // Cantidad de salones
            int n = 0; // Variable de control de ciclo salones
            int m = 0; // Variable de control del ciclo alumnos
            string valor = "";

            // Variables para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f; //Variable para lacalificación mínima
            float maxima = 0.0f; //Variable para la calificación maxima

            // Pedimos la cantidad de salones
            Console.Write("Dame la cantidad de salones: ");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);
            
            // Creamos el arreglo
            float[][] calif = new float[salones][];

            // Pedimos los alumnos por salon
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                Console.WriteLine("Dame la cantidad de alumnos para el salon {0}", n);
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);
                
                // Instanciamos el arreglo
                calif[n] = new float[cantidad];
            }
            
            // Capturamos la información
            for(n=0;n<salones;n++) // Ciclo salones
            {
                Console.WriteLine("Salon {0}", n);
                for(m=0;m<calif[n].GetLength(0);m++) //Ciclo alumnos
                {
                    Console.Write("Dame la calificación: ");
                    valor=Console.ReadLine();
                    calif [n]
                    [m]=Convert.ToSingle(valor);
                }
            }

            // Desplegamos la información
            Console.WriteLine("—— Información ——");
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                Console.WriteLine("Salon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++) // Ciclo alumnos
                {
                    Console.WriteLine("El alumno {0} tiene {1}", m, calif[n][m]);
                }
            }

            Console.ReadKey();
        }
    }
}
