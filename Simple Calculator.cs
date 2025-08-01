namespace ProjectPractice
{
    internal class Program
    {
        int a ,b, c; 
        void Input()
        {
            Console.WriteLine("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        void Add()
        {
            c = a + b;
            Console.WriteLine("The sum of {0} and {1} is: {2}", a, b, c);
        }

        void Subtract()
        {
            c = a - b;
            Console.WriteLine("The difference of {0} and {1} is: {2}", a, b, c);
        }

        void Multiply()
        {
            c = a * b;
            Console.WriteLine("The product of {0} and {1} is: {2}", a, b, c);
        }
        void Divide()
        {
            if (b != 0)
            {
                c = a / b;
                Console.WriteLine("The quotient of {0} and {1} is: {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple Calculator!");
            Program calculator = new Program();
            calculator.Input();
            calculator.Add();
            calculator.Subtract();

        }
    }
}
