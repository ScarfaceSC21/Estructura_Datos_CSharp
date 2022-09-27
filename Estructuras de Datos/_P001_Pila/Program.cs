
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P001_Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();
            new Program().Menu(pila);
        }

        void Menu(Pila pila)
        {
            bool ejecutar = false;
            for (int tecla= 0; ; )
            {
                Console.CursorVisible = false;
                PintaMenu(tecla);
                ConsoleKeyInfo cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow: tecla--; break;
                    case ConsoleKey.DownArrow: tecla++; break;
                    case ConsoleKey.Enter: ejecutar = true; break;  
                }

                if (tecla > 5) tecla = 0; else if (tecla < 0) tecla = 5;

                if (ejecutar)
                {
                    ejecutar = false;
                    switch (tecla)
                    {
                        case 0: pila.InsertarNodo(); break;
                        case 1: pila.ImprimirPila(); break;
                        case 2: pila.BuscarNodo(); break;
                        case 3: pila.ModificarNodo(); break;
                        case 4: pila.EliminarNodo(); break;
                        case 5: return;
                    }
                }
            }
        }

        void PintaMenu(int tecla)
        {
            ConsoleColor cc = ConsoleColor.White;
            ConsoleColor sel = ConsoleColor.DarkRed;

            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = tecla == 0 ? sel : cc;
            Console.WriteLine("1. Ingresar un nodo a la pila");

            Console.SetCursorPosition(5, 7);
            Console.ForegroundColor = tecla == 1 ? sel : cc;
            Console.WriteLine("2. Imprimir la pila");

            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = tecla == 2 ? sel : cc;
            Console.WriteLine("3. Buscar un dato de un nodo en la pila");

            Console.SetCursorPosition(5, 11);
            Console.ForegroundColor = tecla == 3 ? sel : cc;
            Console.WriteLine("4. Modificar un dato de un nodo en la pila");

            Console.SetCursorPosition(5, 13);
            Console.ForegroundColor = tecla == 4 ? sel : cc;
            Console.WriteLine("5. Eliminar un dato de un nodo de la pila");

            Console.SetCursorPosition(5, 15);
            Console.ForegroundColor = tecla == 5 ? sel : cc;
            Console.WriteLine("6. Salir");
        }
    }
}
