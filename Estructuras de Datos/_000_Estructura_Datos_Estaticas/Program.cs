using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Estructura_Datos_Estaticas
{
    /*                                       ESTRUCTURA DE DATOS
    Una estructura de datos es una colección de datos que pueden ser caracterizados por su organización y las operaciones que se definen en ella.

    Los tipos de datos simples o primitivos significan que no están compuestos de otras estructuras de datos; los más frecuentes y utilizados por 
    casi todos los lenguajes son: enteros, reales y carácter (char), siendo los tipos lógicos, subrango y enumerativos propios de lenguajes estructurados  

    Los tipos de datos compuestos están construidos basados en tipos de datos primitivos; el ejemplo más representativo  es la cadena (string) de caracteres.

    Los tipos de datos simples pueden ser organizados en diferentes estructuras de datos: estáticas y dinámicas.

    Las estructuras de datos estáticas son aquellas en las que el tamaño ocupado en memoria se define antes de que el programa se ejecute y no puede modificarse 
    dicho tamaño durante la ejecución del programa. Estas estructuras están implementadas en casi todos los lenguajes: array (vectores/tablas-matrices), registros, 
    ficheros o archivos.

    Las estructuras de datos dinámicas no tienen las limitaciones o restricciones en el tamaño de memoria ocupada  que son propias de las estructuras estáticas.

    Una característica importante que diferencia a los tipos de datos es la siguiente: los tipos de datos simples tienen como característica común que cada variable 
    representa a un elemento; los tipos de datos estructurados tienen como característica común que un identificador (nombre) puede representar múltiples datos 
    individuales, pudiendo cada uno de éstos ser referenciado independientemente.*/

    class Program
    {
        static void Main(string[] args)
        {
            int[] Estructura_Array = { 120, 65, 24, 57, 46, 12 };

            int[,] Estructura_Matriz = { { 1, 2 },
                                         { 3, 4 },
                                         { 5, 6 },
                                         { 7, 8 },
                                         { 9, 10 } };

            Console.WriteLine("Datos en el array:");

            foreach (int item in Estructura_Array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Datos en la matriz:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(Estructura_Matriz[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}
