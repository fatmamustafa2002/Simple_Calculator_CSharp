string value;
do
{
    float result;
    Console.Write("Enter First Number: ");
    float num1 = float.Parse(Console.ReadLine() ?? "0");
    Console.Write("Enter Second Number: ");
    float num2 = float.Parse(Console.ReadLine() ?? "0");
    Console.Write("Enter Symbol (/,+,-,*): ");
    string symbol = Console.ReadLine() ?? "Try Again, Use Symbols Specified !";
    switch (symbol)
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine("Addition: " + result);
            Console.WriteLine("You did it !");
            break;

        case "-":
            result = num1 - num2;
            Console.WriteLine("Subtraction: " + result);
            Console.WriteLine("You did it !");
            break;

        case "*":
            result = num1 * num2;
            Console.WriteLine("Multiplication: " + result);
            Console.WriteLine("You did it !");
            break;

        case "/":
            result = num1 / num2;

            if (num2 == 0)
            {
                Console.WriteLine(float.NaN);
            }
            else
            {
                Console.WriteLine("Division: " + result);
                Console.WriteLine("You did it !");
            }
            break;

        default:
            Console.WriteLine("Wrong input");
            break;
    }
    Console.Write("Do you want to continue(y/n):");
    value = Console.ReadLine() ?? "Please Enter (y/n) only";
}
while (value == "y" || value == "Y");