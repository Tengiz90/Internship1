namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Console.WriteLine("To continue enter C, to end enter X");
            var prompt = Console.ReadLine().ToUpper();
                switch (prompt)
                {
                    case "C":
                        {

                            Console.WriteLine("Enter operation +-/*");
                            var operation = Console.ReadLine();
                            while (operation != "+" && operation != "-" && operation != "/" && operation != "*")
                            {
                                Console.WriteLine("Enter correct operation (+-/*)");
                                operation = Console.ReadLine();
                            }
                            Console.WriteLine("Enter first number");
                            var num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter second number");
                            var num2 = Convert.ToDouble(Console.ReadLine());
                            switch (operation)
                            {
                                case "+":
                                    {
                                        Console.WriteLine(MyCalculator.Add(num1, num2));
                                        break;
                                    }
                                case "-":
                                    {
                                        Console.WriteLine(MyCalculator.Subtract(num1, num2));
                                        break;
                                    }
                                case "/":
                                    {
                                        Console.WriteLine(MyCalculator.Divide(num1, num2));
                                        break;
                                    }
                                case "*":
                                    {
                                        Console.WriteLine(MyCalculator.Multiply(num1, num2));
                                        break;
                                    }
                            }

                            break;
                        }
                    case "X":
                        {
                            return;
                        }
                    default: {
                            break;
                        }
                }
            }

        }
    }
}
