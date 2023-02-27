
//int Tal1 = Convert.ToInt32(GetInput("tal1"));
//int Tal2 = Convert.ToInt32(GetInput("tal1"));


//var Input = GetInput(""" 
//    Chose a fun thing:
//    1: Addition
//    2: Subtraction
//    3: Multiplication
//    4: Division
//    """);


Calc(GetInput("Input first number: "), GetInput("Input second number: "), GetInput("+ | - | * | /"));

void Calc(string numb1, string ope, string numb2)
{ //Uses two arrays of different types, 1 for operators and another for the results from each
    string[] op = { "+", "-", "*", "/" };
    double[] res = new double[4];
    //The inputs after seeing if they are numbers
    double inp1 = 0;
    double inp2 = 0;
    //Where the inputs are checked to see if they are numbers
    double.TryParse(numb1, out inp1);
    double.TryParse(numb2, out inp2);
    //Where the math happens and getting added to their personalized housing

    string result = "";
    for (int i = 0; i < op.Length; i++)
    {
        if (op[i] == ope)
        {
            result = (numb1 + op[i].OfType(operator) + numb2);
            return;
        }
    }
    Console.WriteLine(result);
    //res[0] = inp1 + inp2;
    //res[1] = inp1 - inp2;
    //res[2] = inp1 * inp2;
    //res[3] = inp1 / inp2;

    //Console.WriteLine("-------------------------------");
    //for (int i = 0; i < op.Length; i++) //Prints out every equation
    //    Console.WriteLine($"{numb1} {op[i]} {numb2} = {res[i]}");
}

Console.ReadKey();


string GetInput(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}