using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Constraints: informa al compilador sobre las capacidades que debe tener un argumento de tipo.
// Struct--> El argumento de tipo debe ser un tipo de valor que no admita valores NULL
namespace Generic_Actions
{
    public class Generic_Action<T> where T : struct 
    {
        public T value1;
        public T value2;

        public Generic_Action(T value1, T value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public T add()
        {
            return (dynamic)value1 + (dynamic)value2;
        }

        public T susbtraction()
        {
            return (dynamic)value1 - (dynamic)value2;
        }

        public T multiply()
        {
            return (dynamic)value1 * (dynamic)value2;
        }

        public T div()
        {
            if((dynamic)value2 != 0)
            {
                return (dynamic)value1 / (dynamic)value2;
            }
            else
            {
                throw new ArithmeticException();
            }
        }

        public string toString()
        {
            return "Suma = " + add() + " Resta = " + susbtraction() + " Multiplicacion = " + multiply() + " División:" + div();
        }

    }
}
