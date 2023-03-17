void PrintNumbers(int N)
{
    if(N <= 0)
    {
        return;
    }
    else
    {
        Console.Write(N);
        Console.Write(", ");
        PrintNumbers(N - 1);
    }
}

int N = Convert.ToInt32(Console.ReadLine());

PrintNumbers(N);