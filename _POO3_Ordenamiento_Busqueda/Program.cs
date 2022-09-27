using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _POO3_Ordenamiento_Busqueda
{
    class Program
    {
        ArregloDesordenado Array = new ArregloDesordenado(6);
        static void Main(string[] args)
        {
            new Program().Menu();
        }

        void Menu()
        {
            bool ejecutar = false;

            for (int k = 0; ;)
            {
                PintaMenu(k);
                ConsoleKeyInfo cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow: k--; break;
                    case ConsoleKey.DownArrow: k++; break;
                    case ConsoleKey.Enter: ejecutar = true; break;
                }

                if (k < 0) k = 8; else if (k > 8) k = 0;

                if (ejecutar)
                {
                    ejecutar = false;
                    switch (k)
                    {
                        case 0: Opcion1(); break;
                        case 1: Opcion2(); break;
                        case 2: Opcion3(); break;
                        case 3: Opcion4(); break;
                        case 4: Opcion5(); break;
                        case 5: Opcion6(); break;
                        case 6: Opcion7(); break;
                        case 7: Opcion8(); break;
                        case 8: return;
                    }
                }
            }
        }

        void PintaMenu(int k)
        {
            ConsoleColor cc = ConsoleColor.White;
            ConsoleColor sel = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = k == 0 ? sel : cc;
            Console.WriteLine("1. Precargar el arreglo con {7,3,9,4,6,5}");
            Console.SetCursorPosition(5, 7);
            Console.ForegroundColor = k == 1 ? sel : cc;
            Console.WriteLine("2. Insertar dato en el arreglo");
            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = k == 2 ? sel : cc;
            Console.WriteLine("3. Eliminar dato del arreglo");
            Console.SetCursorPosition(5, 11);
            Console.ForegroundColor = k == 3 ? sel : cc;
            Console.WriteLine("4. Vaciar el arreglo");
            Console.SetCursorPosition(5, 13);
            Console.ForegroundColor = k == 4 ? sel : cc;
            Console.WriteLine("5. Mostrar el arreglo");
            Console.SetCursorPosition(5, 15);
            Console.ForegroundColor = k == 5 ? sel : cc;
            Console.WriteLine("6.  Ordenar el arreglo");
            Console.SetCursorPosition(5, 17);
            Console.ForegroundColor = k == 6 ? sel : cc;
            Console.WriteLine("7. Buscar dato en el arreglo con el metodo de busqueda lineal");
            Console.SetCursorPosition(5, 19);
            Console.ForegroundColor = k == 7 ? sel : cc;
            Console.WriteLine("8. Buscar dato en el arreglo con el metodo de busqueda binaria");
            Console.SetCursorPosition(5, 21);
            Console.ForegroundColor = k == 8 ? sel : cc;
            Console.WriteLine("9. Salir");
        }

        void Opcion1()
        {
            Console.SetCursorPosition(5, 25);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Precargando el Arreglo");
            Array.Insertar(7);
            Array.Insertar(3);
            Array.Insertar(9);
            Array.Insertar(4);
            Array.Insertar(6);
            Array.Insertar(5);
            Console.ReadKey();
            Console.Clear();
        }

        void Opcion2()
        {
            Console.SetCursorPosition(5, 25);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingresae un dato para insertar al arreglo");
            Console.SetCursorPosition(5, 26);
            int dato = int.Parse(Console.ReadLine());
            Array.Insertar(dato);
            Console.ReadKey();
            Console.Clear();
        }

        void Opcion3()
        {
            Console.SetCursorPosition(5, 25);
            System.Console.WriteLine("Ingrese el dato que desea eliminar en el arreglo: ");
            Console.SetCursorPosition(5, 26);
            int dato = int.Parse(Console.ReadLine());
            Array.Eliminar(dato);
            Console.Clear();
        }

        void Opcion4()
        {
            Array.Vaciar();
            Console.Clear();
        }

        void Opcion5()
        {
            Console.Clear();
            System.Console.WriteLine(Array.Mostrar());
            Console.ReadKey();

        }

        void Opcion6()
        {

            Console.WriteLine("Seleccione el algoritmo de ordenamiento");
            Console.WriteLine("\t1: BubbleSort");
            System.Console.WriteLine("\t2: HeapSort");
            System.Console.WriteLine("\t3: InsertSort");
            System.Console.WriteLine("\t4: QuickSort");
            System.Console.WriteLine("\t5: PancakeSort");
            System.Console.WriteLine("\t6: SelectionSort");
            System.Console.WriteLine("\t7: Regresar al menu principal");
            System.Console.Write("\tOpcion: ");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Array.BubbleSort();
                    break;

                case 2:
                    Array.HeapSort();
                    break;

                case 3:
                    Array.InsertSort();
                    break;

                case 4:
                    Array.QuickSort();
                    break;

                case 5:
                    Array.PancakeSort();
                    break;

                case 6:
                    Array.SelectionSort();
                    break;
            }
        }

        void Opcion7()
        {
            Console.WriteLine("Ingrese el dato a buscar en el arrreglo por busqueda lineal");
            int dato = int.Parse(Console.ReadLine());
            Console.WriteLine("El dato "+dato+" se encuentra en la posicion " +Array.BusquedaLinea(dato));
            Console.ReadKey();
        }

        void Opcion8()
        {
            Console.WriteLine("Ingrese el dato a buscar en el arrreglo por busqueda binaria");
            int dato = int.Parse(Console.ReadLine());
            int posicion = Array.BuscarBinaria(dato);
            Console.WriteLine("El dato se encuentra en la posicion "+ posicion);
            Console.ReadKey();
        }
    }
}
