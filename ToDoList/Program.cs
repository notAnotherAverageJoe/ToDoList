bool calcOn = true;

while (calcOn)
{
    Console.WriteLine("Welcome to the calculator!");

    Console.WriteLine("Enter the first number: ");
    string input1 = Console.ReadLine();
    int num1 = int.Parse(input1);

    Console.WriteLine("Enter the second number: ");
    string input2 = Console.ReadLine();
    int num2 = int.Parse(input2);

    Console.WriteLine("Choose your operation '+','-','*','/' or q to quit");
    string op = Console.ReadLine();

    int result = 0;
    bool validOperation = true;

    switch (op)
    {
        case "+":
            result = num1 + num2;
            break;
        case "-":
            result = num1 - num2;
            break;
        case "q":
            Console.WriteLine("Have a great rest of the day!!");
            break;
        case "*":
            result = num1 * num2;
            break;
        case "/":
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                validOperation = false;
            }
            break;
        default:
            Console.WriteLine("Operation not recognized!");
            validOperation = false;
            break;
    }

    if (validOperation)
    {
        Console.WriteLine($"The result of {num1} {op} {num2} is: {result}");
    }

    Console.WriteLine("'yes' to continue or 'quit' to quit");
    string cont = Console.ReadLine();
    if (cont != "quit" || cont != "q")
    {
        Console.WriteLine("CALC ON!");
    } else
    {
        calcOn = false;
    }
}
Console.ReadKey();
