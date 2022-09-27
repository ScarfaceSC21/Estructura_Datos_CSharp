using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _009_Colas
{
    /*                                                              Colas (Queue)
    Las colas son otro tipo de estructura lineal de datos similar a las pilas, diferenciándose de ellas en el modo de insertar eliminar elementos.
    Una cola (queue) es una estructura lineal de datos en la que las eliminaciones se realizan al principio de la lista, frente (front), y las inserciones 
    se realizan en el otro extremo, final (rear). En las colas el elemento que entró el primero sale también el primero; por ello se conoce como listas FIFO 
    (first-in, first-out, “primero en entrar, primero en salir”). Así, pues, la diferencia con las pilas reside en el modo de entrada/salida de datos; 
    en las colas las inserciones se realizan al final de la lista, no al principio. Por ello las colas se usan para almacenar datos que necesitan ser procesados 
    según el orden de llegada.

    En la vida real se tienen ejemplos numerosos de colas: la cola de un autobús, la cola de un cine, una caravana de coches en una calle, etc. En todas ellas 
    el primer elemento (pasajero, coche, etc.) que llega es el primero que sale.
    
    Al igual que en el Stack, nosotros ya no necesitamos programarla, pues C# nos provee una clase con toda la funcionalidad necesaria para poder utilizarla. 
    La clase que debemos de utilizar para poder tener una cola es Queue.
    La forma como trabaja es diferente al Stack, ya que el Queue es una estructura de tipo FIFO. Cuando insertamos elementos en el Queue, éstos se colocan atrás
    del último elemento insertado o en la parte posterior de éste. Al momento de leer elementos, se toma el que se encuentre en la parte superior del Queue.

    El proceso por medio del cual nosotros insertamos un elemento nuevo al Queue se conoce como Enqueue y no debemos olvidar que lo hace al final. El acto de
    extraer un elemento del Queue se llama Dequeue y siempre toma el elemento que se encuentra en la parte superior.*/
    class Program
    {
        static void Main(string[] args)
        {
                                                                /*Declaración del Queue
            Para utilizar el Queue, lo primero que debemos hacer es crear una instancia de la clase Queue. El nombre de la instancia puede ser cualquier nombre válido 
            de variable en C#. Si deseamos crear un Queue llamado fila, haremos lo siguiente:
            Queue fila = new Queue();

                                                            /*Adición de elementos al Queue
            Nosotros podemos adicionar elementos al Queue en cualquier momento que lo necesitemos. El tamaño del Queue se modificará dinámicamente por lo que no debemos
            de preocuparnos por él. Siempre que se adiciona un elemento, este elemento se coloca al final o en la parte baja del Queue.

            Para poder hacer esto debemos utilizar el método Enqueue(), el cual pertenece a la clase Queue de C#. Este método es muy sencillo, ya que solamente requiere 
            de un parámetro. En el parámetro colocamos el elemento que deseamos añadir, este método no regresa ningún valor. 
            fila.Enqueue(35);
            fila.Enqueue(20);
            fila.Enqueue(15);
            fila.Enqueue(25);
            fila.Enqueue(10);
            fila.Enqueue(30);
            fila.Enqueue(5);
            Console.Write("Elementos agregados a la cola: ");
            ImprimirCola(fila);

            /*Cómo extraer un elemento del Queue
            Al igual que podemos colocar un elemento, también es posible extraerlo. Sin embargo, la extracción se lleva a cabo de acuerdo a las reglas del Queue. Cuando 
            extraemos un elemento, el elemento que recibimos es el que se encuentra en la parte superior o al inicio del Queue. Debemos recordar que no es posible la 
            extracción de los elementos que se encuentren en otras posiciones.
            Para llevar a cabo la extracción tenemos que usar un método de la clase Queue que se llama Dequeue(). El método no necesita de ningún parámetro y regresa 
            el elemento correspondiente. Es importante tener una variable que reciba al elemento o una expresión que haga uso de él. 
            int valor = 0;
            valor = (int)fila.Dequeue();
            Console.WriteLine("Elemento extraido de la cola: "+ valor);
            Console.Write("Valores actuales en la cola: ");
            ImprimirCola(fila);

                                                               /*Para observar un elemento del Queue
            Cuando hacemos uso del método Dequeue(), el elemento es extraído y deja de encontrarse adentro del Queue después de esa operación. Sin embargo, podemos observar
            el elemento. En este caso recibimos el valor del elemento, pero éste no es eliminado del Queue después de ser leído.

            Para llevar a cabo la observación hacemos uso del método Peek(). Este método no necesita de ningún parámetro y regresa el elemento observado. Al igual que con 
            Dequeue() debe de existir una variable o una expresión que reciba este valor.
            valor = (int)fila.Peek();
            Console.WriteLine("Elemento mostrado: "+ valor);
            Console.Write("Valores actuales en la cola: ");
            ImprimirCola(fila);

            /*Para saber si el Queue tiene determinado elemento
            Algunas veces podemos necesitar saber si en el interior del Queue se guarda un elemento en particular. Esto es posible hacerlo gracias a un método conocido como
            Contains(). Para usar este método, necesitamos pasar como parámetro el elemento que queremos determinar. El método regresará un valor de tipo bool. Si el elemento
            existe adentro del Queue, el valor regresado será true. En el caso de que el elemento no exista en el interior del Queue el valor regresado será false. Necesitamos
            tener una variable o una expresión que reciba el valor del método Contains(). 
            if (fila.Contains(15) == true) Console.WriteLine("El elemento 15 si existe en la cola");
            else Console.WriteLine("El elemento 15 no existe en la cola");

            /*Para conocer la cantidad de elementos que tiene el Queue
            Es conveniente saber la cantidad de elementos que contiene el Queue, especialmente antes de llevar a cabo algunas operaciones sobre éste. Cuando deseamos saber la
            cantidad de elementos existentes, debemos utilizar la propiedad de Count. Esta propiedad corresponde a un valor de tipo entero.
            La podemos utilizarla de la siguiente manera:
            int cantidad = fila.Count;
            Console.WriteLine("La cola tiene "+ cantidad + " elementos");

            /*Para borrar los contenidos del Queue
            Si necesitamos eliminar todos los contenidos del Queue, es sencillo de hacer por medio del método Clear(). Su utilización es muy sencilla ya que no necesita de
            ningún parámetro.
            fila.Clear();
            Console.WriteLine("Se han eliminado todos los elementos de la cola");*/

            //Ejemplo:
            // Variables necesarias
            int opcion = 0;
            int numero = 0;
            bool encontrado = false;

            // Creamos el Queue
            Queue miFila = new Queue();

            do
            {
                // Mostramos menu
                Console.WriteLine("1 - Enqueue");
                Console.WriteLine("2 - Dequeue");
                Console.WriteLine("3 - Clear");
                Console.WriteLine("4 - Contains");
                Console.WriteLine("5 - Salir");
                Console.Write("Dame tu opcion: "); 
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    // Pedimos el valor a introducir
                    Console.Write("Dame el valor a introducir: ");
                    numero = int.Parse(Console.ReadLine());

                    // Adicionamos el valor en el queue
                    miFila.Enqueue(numero);
                }
                if (opcion == 2)
                {
                    // Obtnemos el elemento
                    numero = (int)miFila.Dequeue();

                    // Mostramos el elemento
                    Console.WriteLine("El valor obtenido es: {0}", numero);
                }
                if (opcion == 3)
                {
                    // Limpiamos todos los contenidos del Queue
                    miFila.Clear();
                }
                if (opcion == 4)
                {
                    // Pedimos el valor a encontrar
                    Console.WriteLine("Dame el valor a encontrar: ");
                    numero = int.Parse(Console.ReadLine());

                    // Vemos si el elemento esta
                    encontrado = miFila.Contains(numero);

                    // Mostramos el resultado
                    Console.WriteLine("Encontrado - {0}", encontrado);
                }

                // Mostramos la informacion del stack
                Console.WriteLine("El Queue tiene {0} elementos", miFila.Count);
                ImprimirCola(miFila);
                Console.WriteLine("————---");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 5);

            Console.ReadKey();
        }

        public static void ImprimirCola(Queue cola)
        {
            foreach (int item in cola)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
    }
}
