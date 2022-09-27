using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P004_Lista_Doble
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
                PrimerNodo.ApuntarSiguienteNodo = null;
                PrimerNodo.ApuntarAnteriorNodo = null;
                UltimoNodo = NodoNuevo;
            }
            else
            {
                UltimoNodo.ApuntarSiguienteNodo = NodoNuevo;
                NodoNuevo.ApuntarSiguienteNodo = null;
                NodoNuevo.ApuntarAnteriorNodo = UltimoNodo;
                UltimoNodo = NodoNuevo;
            }
        }

        public void ImprmirListaPU()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            if(PrimerNodo != null)
            {
                while (NodoActual != null)
                {
                    Console.WriteLine(NodoActual.Dato);
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                }
            }
            else
            {
                Console.WriteLine("Lista Vacia");
            }
        }

        public void ImprmirListaUP()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = UltimoNodo;
            if(NodoActual != null)
            {
                while (NodoActual != null)
                {
                    Console.WriteLine(NodoActual.Dato);
                    NodoActual = NodoActual.ApuntarAnteriorNodo;
                }
            }
        }

        public void BuscarNodo()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            bool NodoEncontrado = false;
            Console.Write("Ingrese el dato del nodo a buscar: ");
            int NodoBuscar = int.Parse(Console.ReadLine());
            while (NodoActual != null && NodoEncontrado != true)
            {
                if(NodoBuscar == NodoActual.Dato)
                {
                    Console.WriteLine("El dato del nodo a buscar si se encuentra en la lista");
                    NodoEncontrado = true;
                }
                NodoActual = NodoActual.ApuntarSiguienteNodo;
            }
            if (!NodoEncontrado) Console.WriteLine("El dato del nodo a buscar no se encuentra en la lista");
        }

        public void ModificarNodo()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            bool NodoEncontrado = false;
            Console.Write("Ingrese el dato del nodo a modificar: ");
            int NodoModificar = int.Parse(Console.ReadLine());
            while (NodoActual != null && NodoEncontrado != true)
            {
                if (NodoModificar == NodoActual.Dato)
                {
                    Console.Write("Ingrese el nuevo dato del nodo: ");
                    NodoActual.Dato = int.Parse(Console.ReadLine());
                    NodoEncontrado = true;
                    Console.WriteLine("El nodo ha sido modificado con exito");
                }
                NodoActual = NodoActual.ApuntarSiguienteNodo;
            }
            if (!NodoEncontrado) Console.WriteLine("El dato del nodo a buscar no se encuentra en la lista");
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
            while (NodoActual != null && NodoEncontrado != true)
            {
                if (NodoEliminar == NodoActual.Dato)
                {
                    if(NodoActual == PrimerNodo)
                    {
                        PrimerNodo = PrimerNodo.ApuntarSiguienteNodo;
                        PrimerNodo.ApuntarAnteriorNodo = null;
                    }
                    else if(NodoActual == UltimoNodo)
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
            }
            if (!NodoEncontrado) Console.WriteLine("El dato del nodo a buscar no se encuentra en la lista");
        }
    }
}
