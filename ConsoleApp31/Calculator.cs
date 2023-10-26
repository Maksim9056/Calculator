using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public class Calculator<T>
    {
        

        public  Calculator()
        {
        }

        public T X { get; set; }
        public T Y { get; set; }
        public T[]  Add(T x, T y)
        {

            X = x;
            Y = y;

            T[] values = new T[2];

            values[0] = X; 
            values[1] = Y;
            return values;
        }

        public T Zero<T>()
        {
            return default(T);
        }
    }
}
