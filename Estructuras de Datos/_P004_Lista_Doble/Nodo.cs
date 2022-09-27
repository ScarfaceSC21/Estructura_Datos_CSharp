using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P004_Lista_Doble
{
    class Nodo
    {
        private int dato;
        private Nodo apuntarsiguientenodo;
        private Nodo apuntaranteriornodo;

        public int Dato
        {
            get => dato; 
            set => dato = value;
        }

        public Nodo ApuntarSiguienteNodo
        {
            get => apuntarsiguientenodo; 
            set => apuntarsiguientenodo = value;
        }

        public Nodo ApuntarAnteriorNodo
        {
            get => apuntaranteriornodo;
            set => apuntaranteriornodo = value;
        }
    }
}
