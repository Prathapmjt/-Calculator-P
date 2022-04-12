class Calculator
{
    static void Main(string[] args)
    {
        double num1 = 0, num2 = 0, result = 0;
        Console.WriteLine("             Calculator");

        Console.WriteLine("Enter number 1");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter number 2");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter a option");
        Console.WriteLine("+ : Add");
        Console.WriteLine("- : Subtract");
        Console.WriteLine("* : Multiply");
        Console.WriteLine("/ : Divide");

        switch (Console.ReadLine())
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"your result: {num1} + {num2} = " + result);
                break;

            case "-":
                result = num1 - num2;
                Console.WriteLine($"your result: {num1} - {num2} = " + result);
                break;

            case "*":
                result = num1 * num2;
                Console.WriteLine($"your result: {num1} * {num2} = " + result);
                break;

            case "/":
                result = num1 / num2;
                Console.WriteLine($"your result: {num1} / {num2} = " + result);
                break;
        }
    }
}
