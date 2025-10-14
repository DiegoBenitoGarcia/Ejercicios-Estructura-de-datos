using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePila
{
    internal class Elemento<Tipo>
    {
        private Tipo _Value;
        private Elemento<Tipo> _Next;

        public Elemento(Tipo Value) 
        {
            _Value = Value;
            _Next = null;
        }

        
        public Tipo Value
        {
            get { return _Value; }
            set { _Value = value; }
        }
        public Elemento<Tipo> Next
        {
            get { return _Next; }
            set { _Next = value; }
        }

    }
}
