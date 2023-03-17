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

int GetMinRowMatrixRowId(int[][] matrix, int m, int n)
{
    int minRowId = 0;
    int minRowSum = int.MaxValue;

    for (int i = 0; i < m; i++)
    {
        var a = matrix[i];
        var rowSum = a.Sum();
        
        if(rowSum < minRowSum)
        {
            minRowSum = rowSum;
            minRowId = i;
        }
    }

    return minRowId;
}

Console.WriteLine("введите M x M для массива...");
int m = Convert.ToInt32(Console.ReadLine());

int[][] matrix = new int[m][];

for (int i = 0; i < m; i++)
{
    matrix[i] = GenerateArray(m);
}

PrintMatrix(matrix, m, m);
int rowId = GetMinRowMatrixRowId(matrix, m, m);
Console.WriteLine($"{rowId + 1} строка");