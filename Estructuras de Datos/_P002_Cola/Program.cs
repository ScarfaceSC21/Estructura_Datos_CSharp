using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P002_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola cola = new Cola();
            new Program().Menu(cola);
        }

        void Menu(Cola cola)
        {
            bool ejecutar = false;
            for (int tecla = 0; ; )
            {
                PintaMenu(tecla);
                ConsoleKeyInfo cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow: tecla--;  break;
                    case ConsoleKey.DownArrow: tecla++; break;
                    case ConsoleKey.Enter: ejecutar = true; break;
                }

                if (tecla < 0) tecla = 5; else if (tecla > 5) tecla = 0;

                if (ejecutar)
                {
                    ejecutar = false;
                    switch (tecla)
                    {
                        case 0: cola.InsertarNodo(); Console.Clear(); break;
                        case 1: cola.ImprimirCola(); Console.Clear();break;
                        case 2: cola.BuscarNodo(); Console.Clear(); break;
                        case 3: cola.ModificarNodo(); Console.Clear(); break;
                        case 4: cola.EliminarNodo(); Console.Clear(); break;
                        case 5: return;
                    }
                }
            }
        }

        void PintaMenu(int tecla)
        {
            ConsoleColor cc = ConsoleColor.White;
            ConsoleColor sel = ConsoleColor.Red;

            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = tecla == 0 ? sel : cc;
            Console.WriteLine("Insertar un nodo en la cola");

            Console.SetCursorPosition(5, 7);
            Console.ForegroundColor = tecla == 1 ? sel : cc;
            Console.WriteLine("Imprimir la cola");

            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = tecla == 2 ? sel : cc;
            Console.WriteLine("Buscar un nodo en la cola");

            Console.SetCursorPosition(5, 11);
            Console.ForegroundColor = tecla == 3 ? sel : cc;
            Console.WriteLine("Modificar un nodo en la cola");

            Console.SetCursorPosition(5, 13);
            Console.ForegroundColor = tecla == 4 ? sel : cc;
            Console.WriteLine("Eliminar un nodo en la cola");

            Console.SetCursorPosition(5, 15);
            Console.ForegroundColor = tecla == 5 ? sel : cc;
            Console.WriteLine("Salir");
        }
    }
}
