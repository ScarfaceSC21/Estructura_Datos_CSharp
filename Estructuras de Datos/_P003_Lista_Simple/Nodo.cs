using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P003_Lista_Simple
{
    class Nodo
    {
        private int dato;
        private Nodo apuntarsiguentenodo;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public Nodo ApuntarSiguienteNodo
        {
            get { return apuntarsiguentenodo; }
            set { apuntarsiguentenodo = value; }
        }
    }
}
