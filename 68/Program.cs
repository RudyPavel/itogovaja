Console.WriteLine("введите M и N...");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());


int ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if((m > 0) && (n == 0))
    {
        return ack(m - 1, 1);
    }
    else if((m > 0) && (n > 0))
    {
        return ack(m - 1, ack(m, n - 1));
    }
    else
    {
        return n + 1;
    }
}

Console.WriteLine(ack(m, n));