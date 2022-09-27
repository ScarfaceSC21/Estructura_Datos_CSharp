using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Listas_Enlazadas
{
    /*                  Listas Enlazadas
    Los inconvenientes de las listas contiguas se eliminan con las listas enlazadas. Se pueden almacenar los elementos de una lista lineal 
    en posiciones de memoria que no sean contiguas o adyacentes.
    Una lista enlazada o encadenada es un conjunto de elementos en los que cada elemento contiene la posición o dirección del siguiente elemento 
    de la lista. Cada elemento de la lista enlazada debe tener al menos dos campos: un campo que tiene el valor del elemento y un campo (enlace, link) 
    que contiene la posición del siguiente elemento, es decir, su conexión, enlace o encadenamiento. Los elementos de una lista son enlazados por 
    medio de los campos enlaces.
    Las listas enlazadas tienen una terminología propia que se suele utilizar normalmente. Primero, los valores se almacenan en un nodo.
    
    Los componentes de un nodo se llaman campos. Un nodo tiene al menos un campo dato o valor y un enlace (indicador o puntero) con el siguiente nodo. 
    El campo enlace apunta (proporciona la dirección o referencia de) al siguiente nodo de la lista. El último nodo de la lista enlazada, por convenio, 
    se suele representar por un enlace con la palabra reservada nil (nulo), una barra inclinada (/) y, en ocasiones, el símbolo eléctrico de tierra o masa.

    La implementación de una lista enlazada utiliza simplemente como enlace una variable puntero, o puntero (apuntador).
    Un puntero (apuntador) es una variable cuyo valor es la dirección o posición de otra variable.
    En las listas enlazadas no es necesario que los elementos de la lista sean almacenados en posiciones físicas adyacentes, ya que el puntero indica 
    dónde se encuentra el siguiente elemento de la lista.

    Una lista enlazada sin ningún elemento se llama lista vacía. Su puntero inicial o de cabecera tiene el valor nulo (nil). Una lista enlazada se define por:
        • El tipo de sus elementos: campo de información (datos) y campo enlace (puntero o apuntador).
        • Un puntero de cabecera que permite acceder al primer elemento de la lista.
        • Un medio para detectar el último elemento de la lista: puntero nulo (nil).

                            PROCESAMIENTO DE LISTAS ENLAZADAS
    Para procesar una lista enlazada se necesitan las siguientes informaciones:
        • Primer nodo (cabecera de la lista).
        • El tipo de sus elementos.
    Las operaciones que normalmente se ejecutan con listas incluyen:
        1. Recuperar información de un nodo específico (acceso a un elemento).
        2. Encontrar el nodo que contiene una información específica (localizar la posición de un elemento dado).
        3. Insertar un nuevo nodo en un lugar específico de la lista.
        4. Insertar un nuevo nodo en relación a una información particular.
        5. Borrar (eliminar) un nodo existente que contiene información específica
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Implementacion de una lista enlazada:
           /* LinkedList<int> list = new LinkedList<int>();

            foreach (int numero in new int[] { 4, 5 , 2, 4, 6, 3})
            {
                list.AddFirst(numero); //El metodo AddFirst() agrega el elemento al principo de la lista
            }

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            list.Remove(6); //El metodo Remove() elimina el elemento que le pasemos por parametro de la lista

            Console.WriteLine("Se elimino el elemento 6 de la lista");

            Console.WriteLine();

            Console.WriteLine("Cantidad de elementos en la lista: "+ list.Count); //La propiedad Count devuelve la cantidad de elementos de la lista

            Console.WriteLine();

            for(LinkedListNode<int> nodo = list.First; nodo!= null; nodo = nodo.Next)
            {
                int numero = nodo.Value;
                Console.WriteLine(numero);
            }*/

            //Ejemplo:

            // Crea la lista enlazada.
            string[] palabras = { "el", "zorro", "saltó", "sobre", "el", "perro" };
            LinkedList<string> frase = new LinkedList<string>(palabras);
            Muestra(frase, "Valores de la lista enlazada:");

            Console.WriteLine("frase.Contains(\"saltó\") = {0}", frase.Contains("saltó"));

            // Añade la palabra 'hoy' al comienzo de la lista.
            frase.AddFirst("hoy");
            Muestra(frase, "Test 1: Añade 'hoy' al comienzo de la lista:");

            // Mueve el primer nodo hasta el último nodo.
            LinkedListNode<string> marca1 = frase.First;
            frase.RemoveFirst();
            frase.AddLast(marca1);
            Muestra(frase, "Test 2: Mueve el primer nodo al la última posición:");

            // Modifica el último nodo por 'ayer'.
            frase.RemoveLast();
            frase.AddLast("ayer");
            Muestra(frase, "Test 3: Modifica el último nodo por 'ayer':");

            // Mueve el último nodo al primero.
            marca1 = frase.Last;
            frase.RemoveLast();
            frase.AddFirst(marca1);
            Muestra(frase, "Test 4: Mueve el último nodo al primero:");


            // Indica con un paréntesis la última concurrencia de 'el'.
            frase.RemoveFirst();
            LinkedListNode<string> actual = frase.FindLast("el");
            IndicaNodo(actual, "Test 5: Indica con un paréntesis la última concurrencia de 'el'.:");

            // Añade 'perezoso' y  'viejo' después de 'el' (el LinkedListNode nombre actual).
            frase.AddAfter(actual, "viejo");
            frase.AddAfter(actual, "perezoso");
            IndicaNodo(actual, "Test 6: Añade 'perezoso' y  'viejo' después de 'el' :");

            // Indica el nodo 'zorro'
            actual = frase.Find("zorro");
            IndicaNodo(actual, "Test 7: Indica el nodo 'zorro':");

            // Añade 'rápido' and 'marrón' antes de  'zorro':
            frase.AddBefore(actual, "rápido");
            frase.AddBefore(actual, "marrón");
            IndicaNodo(actual, "Test 8:Añade 'rápido' y 'marrón' antes de  'zorro':");

            // Mantiene una referencia al nodo actual 'zorro', y al nodo previo previous en la lista. Indica el nodo 'perro'.
            marca1 = actual;
            LinkedListNode<string> marca2 = actual.Previous;
            actual = frase.Find("perro");
            IndicaNodo(actual, "Test 9: Indica el nodo 'perro':");

            // el método AddBefore devuelve una InvalidOperationException si se intenta añadir un nodo que ya pertenece a la lista.
            Console.WriteLine("Test 10: excepcion por intentar añadir el nodo (zorro) ya existe en la lista:");
            try
            {
                frase.AddBefore(actual, marca1);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }
            Console.WriteLine();

            // Elimina el nodo al que se refiere la marca1, y añade otro antes del nodo referenciado por el nodo actual.
            // Indica el nodo referenciado por el actual.
            frase.Remove(marca1);
            frase.AddBefore(actual, marca1);
            IndicaNodo(actual, "Test 11: Mueve un nodo referenciado (zorro)antes del nodo actual (perro):");

            // Elimina el nodo referenciado por el actual.
            frase.Remove(actual);
            IndicaNodo(actual, "Test 12: Elimina el nodo actual (perro) e intenta indicarlo:");

            // Añade un nodo después del nodo referenciado por la marca2.
            frase.AddAfter(marca2, actual);
            IndicaNodo(actual, "Test 13: Añade el nodo eliminado en el tTest 11 después de referenciarlo (marrón):");

            // El método Remove encuentra y elimina el primer nodo que tiene un valor especificado.
            frase.Remove("viejo");
            Muestra(frase, "Test 14: Elimina el nodo que tiene el valor 'viejo':");

            // Cuando la lista es convertida a una ICollection(de caracteres), el método Add añade un nodo  al final de la lista.
            frase.RemoveLast();
            ICollection<string> icoleccion = frase;
            icoleccion.Add("rinoceronte");
            Muestra(frase, "Test 15: Elimina el último nodo convirtiéndolo a ICollection,y añade 'rinoceronte':");

            // Crea un array con el mismo número de elementos que la lista
            Console.WriteLine("Test 16: Copia la lista en un array:");

            string[] sArray = new string[frase.Count];
            frase.CopyTo(sArray, 0);

            foreach (string s in sArray)
            {
                Console.WriteLine(s);
            }

            // Libera todos los nodos.
            frase.Clear();

            Console.WriteLine();
            Console.WriteLine("Test 17: Limpia la lista. Contiene 'saltó' = {0}", frase.Contains("saltó"));

            Console.ReadKey();
        }

        private static void Muestra(LinkedList<string> palabras, string testeo)
        {
            Console.WriteLine(testeo);
            foreach (string palabra in palabras)
            {
                Console.Write(palabra + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void IndicaNodo(LinkedListNode<string> nodo, string testeo)
        {
            Console.WriteLine(testeo);
            if (nodo.List == null)
            {
                Console.WriteLine("Nodo '{0}' no está en la lista.\n",
                    nodo.Value);
                return;
            }

            StringBuilder resultado = new StringBuilder("(" + nodo.Value + ")");
            LinkedListNode<string> nodoP = nodo.Previous;

            while (nodoP != null)
            {
                resultado.Insert(0, nodoP.Value + " ");
                nodoP = nodoP.Previous;
            }

            nodo = nodo.Next;
            while (nodo != null)
            {
                resultado.Append(" " + nodo.Value);
                nodo = nodo.Next;
            }

            Console.WriteLine(resultado);
            Console.WriteLine();
        }
    }
}
