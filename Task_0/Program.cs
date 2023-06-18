string data = "data";
string error = "error";
string result = "result";

void Print(string text, string arg)
{
    switch (arg)
    {
        case "data":
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;
        case "error":
            Console.ForegroundColor = ConsoleColor.Red;
            break;
        case "result":
            Console.ForegroundColor = ConsoleColor.Green;
            break;
    }
    Console.WriteLine(text);
    Console.ResetColor();
}

int GetIntNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FindQuarter(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Print("Our or both coordinate equal zero", error);
    }
    else
    {
        switch ((x, y))
        {
            case ( > 0, > 0):
                Print("First quarter.", result);
                break;
            case ( < 0, > 0):
                Print("Second quarter.", result);
                break;
            case ( < 0, < 0):
                Print("Third quarter.", result);
                break;
            case ( > 0, < 0):
                Print("Fourth quarter.", result);
                break;
        }
    }
}

Print("Input X coordinate", data);
int coordinateX = GetIntNumber();
Print("Input Y coordinate", data);
int coordinateY = GetIntNumber();
FindQuarter(coordinateX, coordinateY);