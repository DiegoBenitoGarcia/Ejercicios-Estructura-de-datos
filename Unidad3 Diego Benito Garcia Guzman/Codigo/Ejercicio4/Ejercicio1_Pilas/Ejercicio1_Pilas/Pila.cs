using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Pilas
{
    public class Pila <Tipo>
    {
        private Elemento<Tipo> _ElementoSuperior;
        private int _intTamanio;
        public int Tamanio
        {
            get { return _intTamanio; }
            set { _intTamanio = value; }
        }

        public Pila()
        {
            _ElementoSuperior = null;
            _intTamanio = 0;
        }

        public void AgregarPila(Tipo ObjAgregarPila)
        {
            Elemento<Tipo> NuevoElemento = new Elemento<Tipo>(ObjAgregarPila);
            NuevoElemento.Next = _ElementoSuperior;
            _ElementoSuperior = NuevoElemento;
            _intTamanio++;
        }
        public Tipo EliminarPila()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La pila está vacía.");

            Tipo valor = _ElementoSuperior.Value;
            _ElementoSuperior = _ElementoSuperior.Next;
            _intTamanio--;
            return valor;
        }
        public bool EstaVacia()
        {
            return _ElementoSuperior == null;
        }
    }
}
