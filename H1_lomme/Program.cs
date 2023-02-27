
int Tal1 = Convert.ToInt32(GetInput("tal1"));
int Tal2 = Convert.ToInt32(GetInput("tal1"));

string[] ope = new string[] { "+" };

var Input = GetInput(""" 
    Chose a fun thing:
    1: Addition
    2: Subtraction
    3: Multiplication
    4: Division
    """);

switch (Input)
{
    case "+":
        char op = Convert.ToChar(Input);
        int res = (Tal1 + op + Tal2); 
        Console.WriteLine(op);
        break;
    case "2":
        Console.WriteLine(Tal1 - Tal2);
        break;
    case "3":
        Console.WriteLine(Tal1 * Tal2);
        break;
    case "4":
        Console.WriteLine(Tal1 / Tal2);
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}

Console.ReadKey();


string GetInput(string text)
{
    Console.WriteLine(text);
    return Console.ReadLine();
}