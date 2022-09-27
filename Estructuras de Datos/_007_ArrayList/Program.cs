using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _007_ArrayList
{
    /*                             ArrayList
   Entendemos al ArrayList como un arreglo que puede cambiar su tamaño según lo necesitemos.
   Puede guardar cualquier tipo de dato, por lo que lo podemos usar para enteros, cadenas, flotantes o incluso para tipos definidos por nosotros mismos. 
   ArrayList es una clase en C#, por lo que va a tener métodos o funciones que nos permitirán trabajar con los datos.
   El ArrayList tiene una propiedad que llamamos capacidad, que indica el tamaño que ocupa la lista. También tenemos el conteo, el cual nos dice cuántos 
   elementos está guardando en su interior.
   Para entender cómo funciona ArrayList crearemos una pequeña aplicación y en ella realizaremos las operaciones más importantes.

   Para poder utilizar las colecciones necesitamos que nuestro programa utilice el namespace de System.Collections. Sin este namespace las colecciones no 
   serán reconocidas y tendremos problemas al compilar el programa. Hay que recordar que los namespace a utilizar se colocan al inicio del programa antes 
   de nuestro código.  */
    class Program
    {
        static void Main(string[] args)
        {
            /*           Declaración de un ArrayList
            En nuestro programa podemos tener tantos ArrayList como sean necesarios, pero es necesario declararlos primero. La declaración se lleva a cabo de la 
            siguiente manera:*/
            ArrayList datos = new ArrayList();
            /*Lo primero que necesitamos es indicar ArrayList, ya que éste es el nombre de la clase. Luego colocamos el nombre que va a tener, en nuestro caso es datos. 
            Posteriormente pasamos a la instanciación, la cual se lleva a cabo por medio de new. En este ejemplo el constructor de la clase no recibe ningún parámetro.
            Si bien el ArrayList aumenta su tamaño dinámicamente, es posible instanciar el arreglo con algún valor de capacidad inicial. Esto es útil si sabemos 
            inicialmente cuantos elementos puede contener el ArrayList. para hacerlo simplemente colocamos la capacidad inicial entre los paréntesis de la siguiente forma:*/
            ArrayList datos_ = new ArrayList(32);

                        /*Adición de información
            Nosotros podemos adicionar cualquier tipo de información al ArrayList. Hacerlo es muy sencillo y requiere que usemos un método conocido como Add().
            Siempre que se adiciona un elemento al ArrayList, este nuevo elemento se agrega al final. Si incorporamos otro elemento, se colocará después del anterior. 
            La adición siempre se lleva a cabo después del último elemento que se encuentre en el ArrayList.
            El método Add() va a necesitar de un único parámetro y este es el dato que queremos guardar. Por ejemplo para guardar un dato de tipo entero podemos hacer 
            lo siguiente*/
            datos.Add(7);
            datos.Add(10);
            datos.Add(21);
            //El dato a guardar también puede ser pasado por medio de una variable:
            int n = 5;
            datos.Add(n);
            //Si quisiéramos guardar una cadena, se puede hacer de la siguiente manera:
            //palabras.Add(“Hola”);

                        /*Cómo acceder a la información de un ArrayList
            La colección ArrayList nos permite acceder a sus elementos por medio de un índice, algunas colecciones no lo permiten, pero ArrayList sí.
            Si tenemos un ArrayList llamado datos y deseamos imprimir el elemento 2, lo podemos hacer de la siguiente manera:*/
            Console.WriteLine("El dato es {0}", datos[2]);

                        /*Cómo obtener la cantidad de elementos en un ArrayList
            En muchas ocasiones es útil saber cuántos elementos tenemos en el ArrayList. A diferencia del arreglo tradicional, éste puede cambiar su tamaño durante 
            la ejecución de la aplicación y conocer el tamaño nos evita problemas con los valores de los índices al acceder el arreglo.
            Afortunadamente es muy sencillo hacerlo, simplemente tenemos que leer el valor de la propiedad count del ArrayList. Esta propiedad es un valor entero.*/
            int elementos = datos.Count;
            /*En este caso la variable elementos tendrá la cantidad de elementos en el arreglo datos.
            No debemos olvidar que si elementos tiene el valor de 5, los índices irán de 0 a 4.
            
                        Insertar elementos
            Hemos visto que podemos adicionar elementos y que éstos son colocados al final del ArrayList, sin embargo también es posible llevar a cabo una inserción. 
            La inserción permite colocar un elemento nuevo en cualquier posición válida del arreglo.
            Para lograr esto usamos el método Insert(). Este método necesita de dos parámetros, el primer parámetro es el índice donde deseamos insertar el elemento y
            el segundo parámetro es el elemento a insertar.
            Por ejemplo, si deseamos insertar el valor de 5 en el índice 2, hacemos lo siguiente: */
            datos.Insert(2, 5);

            /*          Para eliminar un elemento
            Es posible eliminar cualquier elemento del ArrayList y hacerlo de forma muy sencilla. Lo único que necesitamos es conocer el índice del elemento a eliminar. 
            El índice es un valor entero y debe ser válido. El método que se encarga de llevar a cabo la eliminación es RemoveAt(). 
            Este método solamente necesita de un parámetro, que es el índice del objeto que deseamos eliminar. Por ejemplo si queremos eliminar el elemento que se encuentra
            en el índice 1, podemos hacer lo siguiente:
             */
            datos.RemoveAt(1);

            /*          Para encontrar un elemento
            Con los ArrayList es posible saber si un elemento en particular se encuentra adentro de él. Para lograr esto hacemos uso del método IndexOf(). Este método requiere
            de un solo parámetro que es el objeto a buscar adentro del ArrayList. El método nos regresa un valor entero.
            
            Este valor es el índice donde se encuentra la primera ocurrencia del elemento, esto es debido a que podemos tener el elemento guardado en diferentes posiciones. 
            Si el elemento no se encuentra en el ArrayList, entonces simplemente recibimos el valor de -1.
            
            Si lo que deseamos es buscar el índice donde se encuentra el elemento 7 en nuestro ArrayList, hacemos lo siguiente:
             */

            int indice = datos.IndexOf(21);

            Console.WriteLine(indice);

            Console.ReadKey();
        }
    }
}
