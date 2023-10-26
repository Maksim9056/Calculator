namespace ConsoleApp31
{
    internal class Program
    {

        /// <summary>
        /// Напишите обобщенный класс Calculator<T>,
        /// который имеет статический метод T Add(T x, T y), который возвращает сумму двух значений типа T.
        /// Затем напишите ограничение для этого класса, чтобы он мог работать только с типами,
        /// которые имеют параметрless конструктор (new()). 
        /// Затем напишите метод T Zero(), который возвращает нулевое значение типа T с помощью параметрless конструктора.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Calculator<int> calculator = new ConsoleApp31.Calculator<int>();

           var Values =   calculator.Add(10, 20);
            foreach (var value in Values)
            {
                Console.WriteLine(value);
            }


            var Value = calculator.Zero<int>();

            Console.WriteLine(Value);

            Console.ReadLine();
        }

    } 
}
    
