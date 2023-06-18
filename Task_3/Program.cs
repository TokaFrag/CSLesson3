void Print(string text)
{
    Console.WriteLine(text);
}

int GetIntNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void GetSquare(int number)
{
    Console.Clear();
    Print($"table of squares number {number}:");
    int index = 1;
    while (number >= index)
    {
        double result = Math.Pow(index, 2);
        Print($"{result}");
        index++;
    }
}

Print("Input number");
int number = GetIntNumber();
GetSquare(number);
