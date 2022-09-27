using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P005_Lista_Circular_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.InsertarNodo();
            lista.InsertarNodo();
            lista.InsertarNodo();
            lista.InsertarNodo();
            lista.InsertarNodo();
            lista.ImprimirLista();
            lista.BuscarNodo();
            lista.ModificarNodo();
            lista.ImprimirLista();
            lista.EliminarNodo();
            lista.ImprimirLista();
            Console.ReadKey();

            Console.ReadKey();
        }
    }

    public struct Agenda
    {
        public string nombre;
        public int edad;
        public string telefono;
    }
}
