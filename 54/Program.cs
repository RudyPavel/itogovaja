int[] GenerateArray(int length)
{
    int[] a = new int[length];

    Random rand = new Random();    

    for (int i = 0; i < length; i++)
    {
        a[i] = rand.Next(0, 100);
    }

    return a;
}

void PrintMatrix(int[][] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i][j]} ");
        }
        Console.WriteLine();
    }
}

void SortMatrix(int[][] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        var a = matrix[i];
        Array.Sort(a);
        Array.Reverse(a);
        matrix[i] = a;
    }
}

Console.WriteLine("введите M x N для массива...");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[][] matrix = new int[m][];

for (int i = 0; i < m; i++)
{
    matrix[i] = GenerateArray(n);
}

PrintMatrix(matrix, m, n);
SortMatrix(matrix, m, n);
Console.WriteLine("Matrix after row DESC sort");
PrintMatrix(matrix, m, n);