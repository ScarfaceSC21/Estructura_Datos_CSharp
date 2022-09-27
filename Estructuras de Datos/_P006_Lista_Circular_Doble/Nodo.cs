using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P006_Lista_Circular_Doble
{
    class Nodo
    {
        private int dato;
        private Nodo apuntarsiguientenodo;
        private Nodo apuntaranteriornodo;

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

        public Nodo ApuntarAnteriorNodo
        {
            get { return apuntaranteriornodo; }
            set { apuntaranteriornodo = value; }
        }
    }
}
