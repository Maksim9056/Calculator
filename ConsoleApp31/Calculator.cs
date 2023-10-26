using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{

    /// <summary>
    /// Calculator 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Calculator<T>
    {


        /// <summary>
        /// Конструктор класса Calculator
        /// </summary>
        public Calculator()
        {
        }

        public T X { get; set; }
        public T Y { get; set; }

        /// <summary>
        /// Метод Add Возращает Массив T
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public T[]  Add(T x, T y)
        {

            X = x;
            Y = y;

            T[] values = new T[2];

            values[0] = X; 
            values[1] = Y;
            return values;
        }

        /// <summary>
        /// Возращает нулевой элемент
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Zero<T>()
        {
            return default(T);
        }
    }
}
