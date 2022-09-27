using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _008_Pilas
{
    /*                                                                  Pila (Stack)
    Una pila (stack) es un tipo especial de lista lineal en la que la inserción y borrado de nuevos elementos se realiza sólo por un extremo que se denomina tope (top).
    La pila es una estructura con numerosas analogías en la vida real: una pila de platos, una pila de monedas, una pila de cajas de zapatos, una pila de camisas, etc. 

    Dado que las operaciones de insertar y eliminar se realizan por un solo extremo (el superior), los elementos sólo pueden eliminarse en orden inverso al que se insertan 
    en la pila esto nos permite guardar elementos y cambiar su tamaño de forma dinámica, sin embargo trabaja en forma diferente al arreglo y al ArrayList. El último elemento 
    que se pone en la pila es el primero que se puede sacar; por ello, a estas estructuras se les conoce por el nombre de LIFO (last-in,  first-out, último en entrar, 
    primero en salir).
    Las operaciones más usuales asociadas a las pilas son:
        "push"      Meter, poner o apilar: operación de insertar un elemento en la pila.
        "pop"       Sacar, quitar o desapilar: operación de eliminar un elemento de la pila.

    El Stack al igual que el ArrayList tiene una capacidad y ésta crece dinámicamente. Cuando instanciamos el Stack adquiere la capacidad de default. Si necesitamos crear un 
    Stack con determinada capacidad, la forma de hacerlo es colocando el valor de capacidad entre los paréntesis del constructor al momento de instanciarlo.
    El efecto de colocar nuevos elementos en la parte superior del Stack se conoce como Push.
    Cuando tomamos un elemento de la parte superior del Stack se conoce como Pop.
     */
    class Program
    {
        static void Main(string[] args)
        {
                                                                       /*Como crear el Stack
            Como cualquier otra colección el Stack necesita ser instanciado para poderlo utilizar. C# nos provee de la clase Stack y adentro de esta clase encontramos todos los
            métodos necesarios para trabajar con él. La instanciación simplemente será la creación de un objeto de esta clase. Si deseamos crear un Stack hacemos lo siguiente:*/
            //Stack miPila = new Stack();

                                                                /*Cómo introducir información al Stack
            Para introducir información al Stack usamos el método Push(). Este método coloca el nuevo elemento en la parte superior del Stack. El método necesita únicamente
            de un parámetro que es el elemento que deseamos insertar. Podemos utilizar el método Push() cuantas veces sea necesario para colocar la información.*/
            /*miPila.Push(7);
            miPila.Push(3);
            miPila.Push(11);
            miPila.Push(15);
            miPila.Push(8);
            Console.WriteLine("Elementos agregados a la pila: ");
            ImprimirPila(miPila);
            /*En este ejemplo se introduce primero el elemento 7 y luego sobre él se coloca el elemento 11. En seguida se coloca un nuevo elemento en la parte superior, 
            que en este caso es 8.

                                                                    Cómo obtener información del Stack
            Si lo que necesitamos es obtener la información que está contenida en el Stack lo podemos hacer al tomar el elemento que se encuentra en la parte superior del Stack.
            Para lograr esto hacemos uso del método Pop(). Este método no necesita ningún parámetro y regresa el elemento correspondiente.*/
            /*int valor = 0;
            valor = (int)miPila.Pop();
            Console.WriteLine("El elemento sacado de la lista fue "+valor);
            ImprimirPila(miPila);
            /*Siguiendo el ejemplo anterior la variable valor ahora tendrá en su interior 8.

                                                        Para obtener la cantidad de elementos del Stack
            Es posible conocer la cantidad de elementos que tiene el Stack y hacerlo es muy sencillo. Debemos leer la propiedad Count del Stack. Esta propiedad nos regresa 
            un valor entero con la cantidad de elementos.*/
            /*int cantidad = miPila.Count;
            Console.WriteLine("Cantidad de elementos en la pila: "+ cantidad);
            ImprimirPila(miPila);

            /*Para saber si el Stack tiene un elemento
            Si deseamos saber si adentro del Stack se encuentra un elemento en particular, podemos hacer uso del método Contains(). Este método necesita de un parámetro que
            es el objeto a encontrar adentro del Stack. El método regresa un valor de tipo bool. Si el objeto se encuentra el valor es true, pero si no se encuentra es false.*/
            /*bool enStack = false;
            enStack = miPila.Contains(11);
            Console.WriteLine("El elemento 11 se encuentra en la pila = "+ enStack);

            /*Para limpiar los contenidos del Stack
            Si deseamos eliminar todos los elementos del Stack de forma rápida lo podemos hacer al usar el método Clear(). Este método no necesita de ningún parámetro y 
            solamente debe ser usado cuando sepamos que debemos borrar los elementos del Stack.*/
            //miPila.Clear();

            /*Aplicacion de la pila*/
            int opcion = 0;
            string valor ="";
            int numero = 0;
            bool encontrado = false;
            // Creamos el stack
            Stack miPila = new Stack();
            do
            {
                // Mostramos menu
                Console.WriteLine("1 - Push");
                Console.WriteLine("2 - Pop");
                Console.WriteLine("3 - Clear");
                Console.WriteLine("4 - Contains");
                Console.WriteLine("5 - Salir");
                Console.Write("Dame tu opcion: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);
                if (opcion == 1)
                {
                    // Pedimos el valor a introducir
                    Console.Write("Dame el valor a introducir: ");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);
                    // Adicionamos el valor en el stack
                    miPila.Push(numero);
                }
                if (opcion == 2)
                {
                    // Obtnemos el elemento
                    numero = (int)miPila.Pop();
                    // Mostramos el elemento
                    Console.WriteLine("El valor obtenido es: {0}", numero);
                }
                if (opcion == 3)
                {
                    // Limpiamos todos los contenidos del stack
                    miPila.Clear();
                }
                if (opcion == 4)
                {
                    // Pedimos el valor a encontrar
                    Console.Write("Dame el valor a encontrar: ");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);
                    // Vemos si el elemento esta
                    encontrado = miPila.Contains(numero);
                    // Mostramos el resultado
                    if (encontrado)
                    {
                        Console.WriteLine("El elemento se encuentra en la pila");
                    }
                    else
                    {
                        Console.WriteLine("El elemento no se encuentra en la pila");
                    }
                }
                // Mostramos la informacion del stack
                Console.WriteLine("El stack tiene {0} elementos", miPila.Count);

                ImprimirPila(miPila);

                Console.WriteLine("————");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 5);
        }

        public static void ImprimirPila(Stack pila)
        {
            foreach (int item in pila)
            {
                Console.WriteLine("{0}", item);
            }
        }
    }
}
