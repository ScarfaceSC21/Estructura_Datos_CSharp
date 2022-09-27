using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _POO3_Ordenamiento_Busqueda
{
    internal class ArregloDesordenado
    {
        private readonly int Max;

        private int Top;

        private int[] Arreglo;

        public ArregloDesordenado(int Max)
        {
            this.Max = Max;

            this.Top = 0;

            this.Arreglo = new int[this.Max];
        }

        public bool EstaLleno()
        {
            if (this.Top == this.Max) return true;

            else return false;
        }

        public bool EstaVacio()
        {
            if (this.Top == 0) return true;

            else return false;
        }

        public bool Insertar(int Dato)
        {
            if (!EstaLleno())
            {
                for (int i = 0; i < Top - 1; i++)
                {
                    if (this.Arreglo[i] == Dato) return false;
                }

                this.Arreglo[this.Top] = Dato;

                this.Top++;

                return true;
            }
            else return false;
        }

        public bool Vaciar()
        {
            this.Top = 0;

            return true;
        }

        public bool Eliminar(int Dato)
        {
            if (!EstaVacio())
            {
                for (int i = 0; i <= this.Top; i++)
                {
                    if (this.Arreglo[i] == Dato)
                    {
                        for (int j = i; j < this.Top - 1; j++)
                        {
                            this.Arreglo[j] = this.Arreglo[j + 1];
                        }
                        this.Top--;

                        return true;
                    }
                }
                return false;
            }
            else return false;
        }

        public string Mostrar()
        {
            string respuesta = " Top = " + this.Top + "\n\n";

            if (!EstaVacio())
            {
                for (int i = 0; i <= this.Top - 1; i++)
                {
                    respuesta = respuesta + "\t [" + i + "]  ==>  " + this.Arreglo[i] + "\n";
                }
            }
            else respuesta = "El arreglo esta vacio";

            return respuesta;
        }

        #region BubbleSort
        public void BubbleSort()
        {
            int temp;

            for (int j = 0; j <= Arreglo.Length - 2; j++)
            {
                for (int i = 0; i <= Arreglo.Length - 2; i++)
                {
                    if (Arreglo[i] > Arreglo[i + 1])
                    {
                        temp = Arreglo[i + 1];
                        Arreglo[i + 1] = Arreglo[i];
                        Arreglo[i] = temp;

                    }
                }
            }
        }
        #endregion

        #region HeapSort
        public void HeapSort()
        {
            int n = this.Arreglo.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(this.Arreglo, n, i);

            for (int i = n - 1; i > 0; i--)
            {
     
                int temp = this.Arreglo[0];
                this.Arreglo[0] = this.Arreglo[i];
                this.Arreglo[i] = temp;

                heapify(this.Arreglo, i, 0);
            }
        }


        void heapify(int[] arr, int n, int i)
        {
            int masLargo = i; 
            int izquierdo = 2 * i + 1;
            int derecho = 2 * i + 2;  

            if (izquierdo < n && arr[izquierdo] > arr[masLargo])
                masLargo = izquierdo;

            if (derecho < n && arr[derecho] > arr[masLargo])
                masLargo = derecho;

            if (masLargo != i)
            {
                int swap = arr[i];
                arr[i] = arr[masLargo];
                arr[masLargo] = swap;

                heapify(arr, n, masLargo);
            }
        }
        #endregion

        #region InsertSort
        public void InsertSort()
        {
            int n = this.Arreglo.Length;
            for (int i = 1; i < n; ++i)
            {
                int clave = this.Arreglo[i];
                int j = i - 1;

                while (j >= 0 && this.Arreglo[j] > clave)
                {
                    this.Arreglo[j + 1] = this.Arreglo[j];
                    j = j - 1;
                }
                this.Arreglo[j + 1] = clave;
            }
        }
        #endregion

        #region QuickSort
        static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static int partition(int[] arr, int men, int may)
        {
            int pivot = arr[may];


            int i = (men - 1);

            for (int j = men; j <= may - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, may);
            return (i + 1);
        }

        static void Sort(int[] arr, int men, int may)
        {
            if (men < may)
            {
                int pi = partition(arr, men, may);

                Sort(arr, men, pi - 1);
                Sort(arr, pi + 1, may);
            }   
        }

        public void QuickSort()
        {
            Sort(this.Arreglo, 0, this.Top - 1);
        }
        #endregion

        #region PancakeSort
        static void flip(int[] arr, int i)
        {
            int temp, inicio = 0;
            while (inicio < i)
            {
                temp = arr[inicio];
                arr[inicio] = arr[i];
                arr[i] = temp;
                inicio++;
                i--;
            }
        }

        static int findMax(int[] arr, int n)
        {
            int mi, i;
            for (mi = 0, i = 0; i < n; ++i)
                if (arr[i] > arr[mi])
                    mi = i;

            return mi;
        }


        public void PancakeSort()
        {
            for (int tam_act = this.Top; tam_act > 1; --tam_act)
            {

                int mi = findMax(this.Arreglo, tam_act);

                if (mi != tam_act - 1)
                {
                    flip(this.Arreglo, mi);

                    flip(this.Arreglo, tam_act - 1);
                }
            }
        }
        #endregion

        #region SelectionSort
        public void SelectionSort()
        {
            int n = this.Top;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (this.Arreglo[j] < this.Arreglo[min_idx])
                        min_idx = j;
                int temp = this.Arreglo[min_idx];
                this.Arreglo[min_idx] = this.Arreglo[i];
                this.Arreglo[i] = temp;
            }
        }
        #endregion


        public static int BuscarLineal(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        public int BusquedaLinea(int dato)
        {
            return BuscarLineal(this.Arreglo, dato);
        }

        public int BuscarBinaria(int busqueda)
        {
            int izquierda = 0, derecha = this.Arreglo.Length - 1;
            while (izquierda <= derecha)
            {

                int indiceCentral = Convert.ToInt32(Math.Floor(Convert.ToDouble(izquierda + derecha) / 2));
                int valorCentral = this.Arreglo[indiceCentral];
                if (valorCentral == busqueda)
                {
                    return indiceCentral;
                }
                if (busqueda < valorCentral)
                {
                    derecha = indiceCentral - 1;
                }
                else
                {
                    izquierda = indiceCentral + 1;
                }

            }
            return -1;
        }

    }
}
