using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P006_Lista_Circular_Doble
{
    class Lista
    {
        private Nodo PrimerNodo = new Nodo();
        private Nodo UltimoNodo = new Nodo();

        public Lista()
        {
            PrimerNodo = null;
            UltimoNodo = null;
        }

        public void InsertarNodo()
        {
            Nodo NodoNuevo = new Nodo();
            Console.Write("Ingrese el dato del nodo nuevo: ");
            NodoNuevo.Dato = int.Parse(Console.ReadLine());

            if(PrimerNodo == null)
            {
                PrimerNodo = NodoNuevo;
                UltimoNodo = NodoNuevo;
                PrimerNodo.ApuntarSiguienteNodo = PrimerNodo;
                PrimerNodo.ApuntarAnteriorNodo = UltimoNodo;
            }
            else
            {
                UltimoNodo.ApuntarSiguienteNodo = NodoNuevo;
                NodoNuevo.ApuntarAnteriorNodo = UltimoNodo;
                NodoNuevo.ApuntarSiguienteNodo = PrimerNodo;
                UltimoNodo = NodoNuevo;
                PrimerNodo.ApuntarAnteriorNodo = UltimoNodo;
            }
        }

        public void ImprimirListaPU()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            if(NodoActual != null)
            {
                Console.WriteLine("Imprimiendo lista del Primero al ultimo");
                do
                {
                    Console.WriteLine(NodoActual.Dato);
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                } while (NodoActual != PrimerNodo);
            }
            else Console.WriteLine("Lista vacia");
        }

        public void ImprimirListaUP()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = UltimoNodo;
            if (NodoActual != null)
            {
                Console.WriteLine("Imprimiendo lista del Ultimo al primero");
                do
                {
                    Console.WriteLine(NodoActual.Dato);
                    NodoActual = NodoActual.ApuntarAnteriorNodo;
                } while (NodoActual != UltimoNodo);
            }
            else Console.WriteLine("Lista vacia");
        }

        public void BuscarNodo()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            bool NodoEncontrado = false;
            Console.Write("Ingrese el dato del nodo a buscar: ");
            int NodoBuscar = int.Parse(Console.ReadLine());
            if(PrimerNodo != null)
            {
                do
                {
                    if (NodoActual.Dato == NodoBuscar)
                    {
                        Console.WriteLine("El nodo si se encuentra en la lista");
                        NodoEncontrado = true;
                    }
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                } while (NodoActual != PrimerNodo && NodoEncontrado != true);
                if (!NodoEncontrado) Console.WriteLine("El nodo no se encuentra en la lista");
            }
            else Console.WriteLine("Lista vacia");
        }

        public void ModificarNodo()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            bool NodoEncontrado = false;
            Console.Write("Ingrese el dato del nodo a modificar: ");
            int NodoModificar = int.Parse(Console.ReadLine());
            if (PrimerNodo != null)
            {
                do
                {
                    if (NodoActual.Dato == NodoModificar)
                    {
                        Console.Write("Ingrese el nuevo dato del nodo: ");
                        NodoActual.Dato = int.Parse(Console.ReadLine());
                        NodoEncontrado = true;
                    }
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                } while (NodoActual != PrimerNodo && NodoEncontrado != true);
                if (!NodoEncontrado) Console.WriteLine("El nodo no se encuentra en la lista");
            }
            else Console.WriteLine("Lista vacia");
        }

        public void EliminarNodo()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            Nodo NodoAnterior = new Nodo();
            NodoAnterior = null;
            bool NodoEncontrado = false;
            Console.Write("Ingrese el dato del nodo a eliminar: ");
            int NodoEliminar = int.Parse(Console.ReadLine());
            if(PrimerNodo != null)
            {
                do
                {
                    if (NodoEliminar == NodoActual.Dato)
                    {
                        if (NodoActual == PrimerNodo)
                        {
                            PrimerNodo = PrimerNodo.ApuntarSiguienteNodo;
                            PrimerNodo.ApuntarAnteriorNodo = null;
                        }
                        else if (NodoActual == UltimoNodo)
                        {
                            NodoAnterior.ApuntarSiguienteNodo = null;
                            UltimoNodo = NodoAnterior;
                        }
                        else
                        {
                            NodoAnterior.ApuntarSiguienteNodo = NodoActual.ApuntarSiguienteNodo;
                            NodoActual.ApuntarSiguienteNodo.ApuntarAnteriorNodo = NodoAnterior;
                        }
                    }
                    NodoAnterior = NodoActual;
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                } while (NodoActual != PrimerNodo && NodoEncontrado != true);
                if(!NodoEncontrado) Console.WriteLine("El dato del nodo a eliminar no se encuentra en la lista");
            }
            else Console.WriteLine("La lista se encuentra vacia");
        }
    }
}
