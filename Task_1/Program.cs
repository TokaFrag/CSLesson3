void Print(string text)
{
    Console.WriteLine(text);
}

int GetIntNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FindQuarter(int quarter)
{

    switch (quarter)
    {
        case 1:
            Print("X > 0 && Y > 0");
            break;
        case 2:
            Print("X < 0 && Y > 0");
            break;
        case 3:
            Print("X < 0 && Y < 0");
            break;
        case 4:
            Print("X > 0 && Y < 0");
            break;
        default:
            Print("Our or both coordinate equal zero");
            break;
    }
}

Print("Input number quarter");
int quarter = GetIntNumber();
FindQuarter(quarter);