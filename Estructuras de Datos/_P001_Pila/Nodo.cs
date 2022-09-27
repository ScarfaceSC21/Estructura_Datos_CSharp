using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P001_Pila
{
    class Nodo
    {
        private int dato;
        private Nodo apuntarsiguientenodo;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }   
        }

        public Nodo ApuntarSiguienteNodo
        {
            get { return apuntarsiguientenodo; }
            set { apuntarsiguientenodo = value; }
        }
    }
}
