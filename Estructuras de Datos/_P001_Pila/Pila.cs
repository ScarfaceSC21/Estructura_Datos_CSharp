using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P001_Pila
{
    class Pila
    {
        private Nodo PrimerNodo = new Nodo();

        public Pila()
        {
            PrimerNodo = null;
        }

        public void InsertarNodo()
        {
            Nodo NodoNuevo = new Nodo();
            int renglon = 17;
            Console.SetCursorPosition(5, renglon++);
            Console.Write("Ingresa el dato del nodo nuevo: ");
            NodoNuevo.Dato = int.Parse(Console.ReadLine());

            NodoNuevo.ApuntarSiguienteNodo = PrimerNodo;
            PrimerNodo = NodoNuevo;

            Console.SetCursorPosition(5, renglon++);
            Console.WriteLine("El nodo ha sido insertado con exito en la pila");
            Console.SetCursorPosition(5, renglon++);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public void ImprimirPila()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            int renglon = 17;
            if(PrimerNodo != null)
            {
                while(NodoActual != null)
                {
                    Console.SetCursorPosition(5, renglon++);
                    Console.WriteLine(NodoActual.Dato);
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                }
            }
            else
            {
                Console.SetCursorPosition(5, renglon++);
                Console.WriteLine("La pila se encuentra vacia");
            }
            Console.SetCursorPosition(5, renglon++);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public void BuscarNodo()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            int renglon = 17;
            bool NodoEncontrado = false;
            Console.SetCursorPosition(5, renglon++);
            Console.Write("Ingrese el dato del nodo a buscar: ");
            int NodoBuscar = int.Parse(Console.ReadLine());
            if(PrimerNodo != null)
            {
                while(NodoActual != null && NodoEncontrado != true)
                {
                    if(NodoActual.Dato == NodoBuscar)
                    {
                        Console.SetCursorPosition(5, renglon++);
                        Console.WriteLine("El dato del nodo a buscar si se encuentra en la pila");
                        NodoEncontrado = true;
                    }
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                }
                if (!NodoEncontrado)
                {
                    Console.SetCursorPosition(5, renglon);
                    Console.WriteLine("El dato del nodo a buscar no se encuentra en la pila");
                }
            }
            else
            {
                Console.SetCursorPosition(5, renglon++);
                Console.WriteLine("La pila se encuentra vacia");
            }
            Console.SetCursorPosition(5, renglon++);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public void ModificarNodo()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            int renglon = 17;
            bool NodoEncontrado = false;
            Console.SetCursorPosition(5, renglon++);
            Console.Write("Ingrese el dato del nodo a modificar: ");
            int NodoModificar = int.Parse(Console.ReadLine());
            if(PrimerNodo != null)
            {
                while(NodoActual != null && NodoEncontrado != true)
                {
                    if(NodoActual.Dato == NodoModificar)
                    {
                        Console.SetCursorPosition(5, renglon++);
                        Console.Write("Ingrese el nuevo dato del nodo: ");
                        NodoActual.Dato = int.Parse(Console.ReadLine());
                        NodoEncontrado = true;
                    }
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                }
                if (!NodoEncontrado)
                {
                    Console.SetCursorPosition(5, renglon++);
                    Console.WriteLine("El dato del nodo a modificar no se encuentra en la pila");
                }
            }
            else
            {
                Console.SetCursorPosition(5, renglon++);
                Console.WriteLine("La pila se encuentra vacia");
            }
            Console.SetCursorPosition(5, renglon++);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public void EliminarNodo()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            Nodo NodoAnterior = new Nodo();
            NodoAnterior = null;
            int renglon = 17;
            bool NodoEncontrado = false;
            Console.SetCursorPosition(5, renglon++);
            Console.Write("Ingrese el dato del nodo ha eliminar: ");
            int NodoEliminar = int.Parse(Console.ReadLine());
            if(PrimerNodo != null)
            {
                while(NodoActual != null && NodoEncontrado != true)
                {
                    if(NodoEliminar == NodoActual.Dato)
                    {
                        if(NodoEliminar == PrimerNodo.Dato) PrimerNodo = PrimerNodo.ApuntarSiguienteNodo; 
                        else  NodoAnterior.ApuntarSiguienteNodo = NodoActual.ApuntarSiguienteNodo; 
                        NodoEncontrado = true;
                    }
                    NodoAnterior = NodoActual;
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                }
                if (!NodoEncontrado)
                {
                    Console.SetCursorPosition(5, renglon++);
                    Console.WriteLine("El dato del nodo a eliinar no se encuentra en la pila");
                }
            }
            else
            {
                Console.SetCursorPosition(5, renglon++);
                Console.WriteLine("La pila se encuentra vacia");
            }
            Console.SetCursorPosition(5, renglon++);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
