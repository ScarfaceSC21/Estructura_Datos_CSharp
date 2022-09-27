using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P005_Lista_Circular_Simple
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
                PrimerNodo.ApuntarSiguienteNodo = PrimerNodo;
                UltimoNodo = NodoNuevo;
            }
            else
            {
                UltimoNodo.ApuntarSiguienteNodo = NodoNuevo;
                NodoNuevo.ApuntarSiguienteNodo = PrimerNodo;
                UltimoNodo = NodoNuevo;
            }
        }

        public void ImprimirLista()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;

            if(NodoActual != null)
            {
                do
                {
                    Console.WriteLine(NodoActual.Dato);
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                } while (NodoActual != PrimerNodo);
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

            if (NodoActual != null)
            {
                do
                {
                    if(NodoActual.Dato == NodoBuscar)
                    {
                        Console.WriteLine("El nodo a buscar si se encuentra en la lista");
                        NodoEncontrado = true;
                    }
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                } while (NodoActual != PrimerNodo && NodoEncontrado != true);
                if (!NodoEncontrado) Console.WriteLine("El nodo a buscar no se encuentra en la lista");
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

            if (NodoActual != null)
            {
                do
                {
                    if (NodoActual.Dato == NodoModificar)
                    {
                        Console.Write("Ingrese el dato nuevo del nodo: ");
                        NodoActual.Dato = int.Parse(Console.ReadLine());
                        NodoEncontrado = true;
                    }
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                } while (NodoActual != PrimerNodo && NodoEncontrado != true);
                if (!NodoEncontrado) Console.WriteLine("El nodo a buscar no se encuentra en la lista");
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

            if (NodoActual != null)
            {
                do
                {
                    if (NodoActual.Dato == NodoEliminar)
                    {
                        if(NodoActual == PrimerNodo)
                        {
                            PrimerNodo = PrimerNodo.ApuntarSiguienteNodo;
                            UltimoNodo.ApuntarSiguienteNodo = PrimerNodo;
                        }
                        else if(NodoActual == UltimoNodo)
                        {
                            NodoAnterior.ApuntarSiguienteNodo = PrimerNodo;
                            UltimoNodo = NodoAnterior;
                        }
                        else
                        {
                            NodoAnterior.ApuntarSiguienteNodo = NodoActual.ApuntarSiguienteNodo;
                        }
                        NodoEncontrado = true;
                        Console.WriteLine("El nodo ha sido eliminado con exito de la lista");
                    }
                    NodoAnterior = NodoActual;
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                } while (NodoActual != PrimerNodo && NodoEncontrado != true);
                if (!NodoEncontrado) Console.WriteLine("El nodo a buscar no se encuentra en la lista");
            }
            else Console.WriteLine("Lista vacia");
        }
    }
}
