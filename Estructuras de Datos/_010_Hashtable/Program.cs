using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _010_Hashtable
{
    /*                                                          HashTable
    Es una estructura de datos un poco compleja de implementar, pero afortunadamente C# nos provee de una clase que nos da toda la funcionalidad necesaria y podemos
    utilizarla tan fácilmente como las colecciones anteriores.
    El Hashtable es una colección indexada. Es decir que vamos a tener un índice y un valor referenciado a ese índice. Sin embargo, la indexación no se lleva a cabo 
    como en el arreglo o el ArrayList. El lugar adentro del Hashtable donde se coloca el elemento va a depender de un valor conocido como key o llave. El valor contenido
    en key es usado para calcular la posición del elemento en el Hashtable. El elemento que vamos a colocar se conoce como value.
    En el Hashtable siempre utilizaremos una pareja de key y value para trabajar con él.
     */
    class Program
    {
        static void Main(string[] args)
        {
            /*Declaración del Hashtable
            La declaración del Hashtable es muy sencilla y similar a la declaración de las otras colecciones. Para hacerlo, simplemente creamos una instancia de la clase 
            Hashtable y después podemos hacer uso de las operaciones de la colección por medio de los métodos que nos provee.
            Si lo que deseamos es declarar e instanciar un Hashtable llamado miTabla, es posible realizarlo prosiguiendo de la siguiente manera:*/
            Hashtable miTabla = new Hashtable();

                                                                /*Adición de elementos al Hashtable
            Para insertar un elemento usamos el método Add(). Este método a diferencia delos de las otras colecciones, va a necesitar de dos parámetros. En el primer 
            parámetro colocamos el key que será usado para indexar al elemento. Este key puede ser de cualquier tipo, pero generalmente se utilizan cadenas. El segundo 
            parámetro será el valor o elemento a insertar, también puede ser de cualquier tipo.
            Hay que recordar que cuando hagamos uso de esta colección siempre trabajamos la información en parejas key-value.*/
            miTabla.Add("Pan", 5.77);
            miTabla.Add("Soda", 10.85);
            miTabla.Add("Atun", 15.50);
            /*El lugar donde quedaron colocados estos elementos adentro del Hashtable depende del algoritmo de hashing que se use. Realmente a nosotros no nos interesa, 
            ya que cualquier acceso que necesitemos lo haremos por medio de key.
            
                                                                        Recorriendo el Hashtable
            Para poder recorrer el Hashtable, haremos uso del ciclo foreach. Si queremos obtener la pareja key-value, nos apoyaremos en una clase conocida como DictionaryEntry. 
            El diccionario también guarda parejas de datos*/
            foreach (DictionaryEntry datos in miTabla) Console.WriteLine("Key – {0}, Value – {1}", datos.Key, datos.Value);

            /*Si lo deseamos podemos extraer solamente los valores y colocar una copia de ellos en una colección. Esto nos permitiría trabajar con los valores de una forma 
            más parecida a lo que hemos aprendido anteriormente.*/
            ICollection valores = miTabla.Values;
            foreach (double valor in valores) Console.WriteLine("El valor es {0}", valor);
            /*ICollection es una interfase usada para implementar las colecciones, de tal forma que valores puede actuar como cualquier colección válida que tengamos, 
            en este caso la colección que representa los valores extraídos del Hashtable.
            
                                                                 Para encontrar si ya existe un key
            Como no podemos repetir el mismo key para dos elementos, es necesario poder saber si ya existe determinado key en el Hashtable. Poder hacerlo es fácil, 
            pues C# nos provee del método Contains(). Este método necesita de un único parámetro que es el key a buscar y regresa un valor de tipo bool. Si el valor 
            regresado es true significa que el key ya existe, y si es false que no se encuentra en el Hashtable.*/
            bool existe = miTabla.Contains("Pan");
            if (existe == true) Console.WriteLine("El elemento Pan si exite ");
            else Console.WriteLine("El elemento Pan no exite");

                                                                /*Para encontrar si ya existe un value
            Igualmente podemos buscar adentro del Hashtable por un value en particular. En este caso, usaremos el método ContainsVale(). Como parámetro colocaremos el valor
            a buscar y el método regresará un bool. Si el valor regresado es true, el value existe en el Hashtable y el valor de false nos indica que no se encuentra.*/
            existe = miTabla.ContainsValue(17.50);
            if (existe == true) Console.WriteLine("El valor 17.50 si existe ");
            else Console.WriteLine("El valor 17.50 no existe");

                                                        /*Para conocer la cantidad de parejas en el Hashtable
            Si deseamos saber cuantas parejas key-value existen adentro de nuestro Hashtable, podemos usar la propiedad de Count. No hay que olvidar que el valor regresado 
            es un entero que dice el número de parejas.*/
            int cantidad = miTabla.Count;
            Console.WriteLine("La tabla contiene "+ cantidad +" elementos");

            /*Para eliminar un elemento del Hashtable
            En el Hashtable no solamente podemos adicionar elementos, también podemos eliminarlos. Al eliminarlos removemos la pareja key-value del Hashtable. Para poder
            llevar a cabo la eliminación, necesitamos conocer el key del valor a eliminar y utilizar el método Remove(). Este método necesita de un solo parámetro que es 
            el key del elemento a borrar.*/
            miTabla.Remove("Pan");
            Console.WriteLine("El elemento Pan ha sido eliminado");
            foreach (DictionaryEntry datos in miTabla) Console.WriteLine("Key – {0}, Value – {1}", datos.Key, datos.Value);

            Console.ReadKey();
        }
    }
}
