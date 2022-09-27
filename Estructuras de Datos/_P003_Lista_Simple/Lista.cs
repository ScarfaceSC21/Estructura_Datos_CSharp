using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P003_Lista_Simple
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
            Console.Write("Ingrese un dato en el nodo: ");
            NodoNuevo.Dato = int.Parse(Console.ReadLine());

            if(PrimerNodo == null)
            {
                PrimerNodo = NodoNuevo;
                PrimerNodo.ApuntarSiguienteNodo = null;
                UltimoNodo = NodoNuevo;
            }
            else
            {
                UltimoNodo.ApuntarSiguienteNodo = NodoNuevo;
                NodoNuevo.ApuntarSiguienteNodo = null;
                UltimoNodo = NodoNuevo;
            }
        }

        public void ImprimirLista()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            if(PrimerNodo != null)
            {
                while(NodoActual != null)
                {
                    Console.WriteLine(NodoActual.Dato);
                    NodoActual = NodoActual.ApuntarSiguienteNodo; 
                }
            }
            else Console.WriteLine("La lista se encuentra vacia");
        }

        public void BuscarNodo()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            bool NodoEncontrado = false;
            Console.Write("Ingrese el dato del nodo a buscar: ");
            int NodoBuscar = int.Parse(Console.ReadLine());
            if (PrimerNodo != null)
            {
                while (NodoActual != null && NodoEncontrado != true)
                {
                    if (NodoActual.Dato == NodoBuscar)
                    {
                        Console.WriteLine("El dato del nodo a buscar si se encuentra en la lista");
                        NodoEncontrado = true;
                    }
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                }
                if (!NodoEncontrado) Console.WriteLine("El dato del nodo a buscar no se encuentra en la lista");
            }
            else Console.WriteLine("La lista se encuentra vacia");
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
                while (NodoActual != null && NodoEncontrado != true)
                {
                    if (NodoActual.Dato == NodoModificar)
                    {
                        Console.Write("Ingrese el nuevo dato del nodo ha modificar: ");
                        NodoActual.Dato = int.Parse(Console.ReadLine());
                        NodoEncontrado = true;
                    }
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                }
                if (!NodoEncontrado) Console.WriteLine("El dato del nodo a buscar no se encuentra en la lista");
            }
            else Console.WriteLine("La lista se encuentra vacia");
        }

        /* public void EliminarNodo()
         {
             Nodo NodoActual = new Nodo();
             NodoActual = PrimerNodo;
             Nodo NodoAnterior = new Nodo();
             NodoAnterior = null;
             bool NodoEncontrado = false;
             Console.Write("Ingrese el dato del nodo a eliminar: ");
             int NodoEliminar = int.Parse(Console.ReadLine());
             if (PrimerNodo != null)
             {
                 while (NodoActual != null && NodoEncontrado != true)
                 {
                     if (NodoActual.Dato == NodoEliminar)
                     {
                         if (PrimerNodo == NodoActual) PrimerNodo = PrimerNodo.ApuntarSiguienteNodo;
                         else NodoAnterior.ApuntarSiguienteNodo = NodoActual.ApuntarSiguienteNodo;
                         NodoEncontrado = true;
                     }
                     NodoAnterior = NodoActual;
                     NodoActual = NodoActual.ApuntarSiguienteNodo;
                 }
                 if (!NodoEncontrado) Console.WriteLine("El dato del nodo a buscar no se encuentra en la lista");
             }
             else Console.WriteLine("La lista se encuentra vacia");
         }*/

        public void EliminarNodo()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            Nodo NodoAnterior = new Nodo();
            NodoAnterior = null;
            bool NodoEncontrado = false;
            Console.Write("Ingrese el dato del nodo a eliminar: ");
            int NodoEliminar = int.Parse(Console.ReadLine());
            if (PrimerNodo != null)
            {
                while (NodoActual != null && NodoEncontrado != true)
                {
                    if (NodoActual.Dato == NodoEliminar)
                    {
                        if (PrimerNodo == NodoActual) PrimerNodo = PrimerNodo.ApuntarSiguienteNodo;
                        else if(NodoActual == UltimoNodo)
                        {
                            NodoAnterior.ApuntarSiguienteNodo = null;
                            UltimoNodo = NodoAnterior;
                        }
                        else NodoAnterior.ApuntarSiguienteNodo = NodoActual.ApuntarSiguienteNodo;
                        NodoEncontrado = true;
                    }
                    NodoAnterior = NodoActual;
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                }
                if (!NodoEncontrado) Console.WriteLine("El dato del nodo a buscar no se encuentra en la lista");
            }
            else Console.WriteLine("La lista se encuentra vacia");
        }
    }
}
