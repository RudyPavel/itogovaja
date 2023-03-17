Console.WriteLine("введите M и N...");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;

if(m > n)
{
    return;
}
else
{
    while (m <= n)
    {
        sum += m;
        m++;
    }
}

Console.WriteLine(sum);