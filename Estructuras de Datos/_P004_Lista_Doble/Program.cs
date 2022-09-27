using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P004_Lista_Doble
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
            Console.WriteLine("Imprimiendo lista del Primero al Ultimo");
            lista.ImprmirListaPU();
            Console.WriteLine("Imprimiendo lista del Ultimo al Primero");
            lista.ImprmirListaUP();
            lista.BuscarNodo();
            lista.ModificarNodo();
            lista.ImprmirListaPU();
            lista.EliminarNodo();
            lista.ImprmirListaPU();
            Console.ReadKey();
        }
    }
}
