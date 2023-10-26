namespace ConsoleApp31
{
    internal class Program
    {
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
    
