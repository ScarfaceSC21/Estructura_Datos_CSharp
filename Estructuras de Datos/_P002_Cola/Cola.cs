using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P002_Cola
{
    class Cola
    {
        private Nodo PrimerNodo = new Nodo();
        private Nodo UltimoNodo = new Nodo();

        public Cola()
        {
            PrimerNodo = null;
            UltimoNodo = null;
        }

        public void InsertarNodo()
        {
            int renglon = 17;
            Nodo NodoNuevo = new Nodo();
            Console.SetCursorPosition(5, renglon++);
            Console.Write("Ingrese el dato del nuevo nodo: ");
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

            Console.SetCursorPosition(5, renglon++);
            Console.WriteLine("El nodo ha sido ingresado correctamnete");
            Console.SetCursorPosition(5, renglon++);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
        
        public void ImprimirCola()
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
                Console.WriteLine("La cola se encuentra vacia");
            }

            Console.SetCursorPosition(5, renglon++);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        public void BuscarNodo()
        {
            int renglon = 17;
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            bool NodoEncontrado = false;
            Console.SetCursorPosition(5, renglon++);
            Console.Write("Ingrese el dato del nodo a buscar: ");
            int NodoBuscar = int.Parse(Console.ReadLine());
            if (PrimerNodo != null)
            {
                while (NodoActual != null && NodoEncontrado != true)
                {
                    if (NodoBuscar == NodoActual.Dato)
                    {
                        Console.SetCursorPosition(5, renglon++);
                        Console.WriteLine("El dato del nodo a buscar si se encuentra en la cola");
                        NodoEncontrado = true;
                    }
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                }
                if (!NodoEncontrado)
                {
                    Console.SetCursorPosition(5, renglon++);
                    Console.WriteLine("El dato del nodo a buscar no se encuentra en la cola");
                }
            }
            else
            {
                Console.SetCursorPosition(5, renglon++);
                Console.WriteLine("La cola se encuentra vacia");
            }

            Console.SetCursorPosition(5, renglon++);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        public void ModificarNodo()
        {
            int renglon = 17;
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            bool NodoEncontrado = false;
            Console.SetCursorPosition(5, renglon++);
            Console.Write("Ingrese el dato del nodo a modificar: ");
            int NodoModificar = int.Parse(Console.ReadLine());
            if (PrimerNodo != null)
            {
                while (NodoActual != null && NodoEncontrado != true)
                {
                    if (NodoModificar == NodoActual.Dato)
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
                    Console.WriteLine("El dato del nodo a buscar no se encuentra en la cola");
                }
            }
            else
            {
                Console.SetCursorPosition(5, renglon++);
                Console.WriteLine("La cola se encuentra vacia");
            }
            Console.SetCursorPosition(5, renglon++);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        public void EliminarNodo()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            Nodo NodoAnterior = null;
            bool NodoEncontrado = false;
            int renglon = 17;
            Console.SetCursorPosition(5, renglon++);
            Console.Write("Ingrese el dato del nodo a eliminar: ");
            int NodoEliminar = int.Parse(Console.ReadLine());
            if (PrimerNodo != null)
            {
                while (NodoActual != null && NodoEncontrado != true)
                {
                    if (NodoEliminar == NodoActual.Dato)
                    {
                        if (NodoEliminar == PrimerNodo.Dato) PrimerNodo = PrimerNodo.ApuntarSiguienteNodo;
                        else NodoAnterior.ApuntarSiguienteNodo = NodoActual.ApuntarSiguienteNodo;
                        NodoEncontrado = true;
                        Console.SetCursorPosition(5, renglon++);
                        Console.WriteLine("El nodo ha sido eliminado con exito de la cola");
                    }
                    NodoAnterior = NodoActual;
                    NodoActual = NodoActual.ApuntarSiguienteNodo;
                }
                if (!NodoEncontrado)
                {
                    Console.SetCursorPosition(5, renglon++);
                    Console.WriteLine("El dato del nodo a buscar no se encuentra en la cola");
                }
            }
            else
            {
                Console.SetCursorPosition(5, renglon++);
                Console.WriteLine("La cola se encuentra vacia");
            }

            Console.SetCursorPosition(5, renglon++);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        /*public void EliminarNodo()
        {
            Nodo NodoActual = new Nodo();
            NodoActual = PrimerNodo;
            Nodo NodoAnterior = new Nodo();
            NodoAnterior = null;
            bool NodoEncontrado = false;
            Console.WriteLine("Ingrese el dato del nodo a eliminar: ");
            int NodoEliminar = int.Parse(Console.ReadLine());
            if (PrimerNodo != null)
            {
                while (NodoActual != null && NodoEncontrado != true)
                {
                    if (NodoEliminar == NodoActual.Dato)
                    {
                        if (NodoActual == PrimerNodo) PrimerNodo = PrimerNodo.ApuntarSiguienteNodo; 
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
                if (!NodoEncontrado) Console.WriteLine("El dato del nodo a buscar no se encuentra en la cola"); 
            }
            else Console.WriteLine("La cola se encuentra vacia"); 
        }*/
    }
}
