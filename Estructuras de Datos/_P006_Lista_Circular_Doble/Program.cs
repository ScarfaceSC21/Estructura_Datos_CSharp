using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P006_Lista_Circular_Doble
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
            lista.ImprimirListaPU();
            lista.ImprimirListaUP();
            lista.BuscarNodo();
            lista.ModificarNodo();
            lista.ImprimirListaPU();
            lista.EliminarNodo();
            lista.ImprimirListaPU();
            Console.ReadKey();
        }
    }
}
