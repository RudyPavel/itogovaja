int[, ,] arr3d2 = new int[2, 2, 2];
Random rand = new Random();  

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            arr3d2[i, j, k] = rand.Next(0, 100);
        }
    }
}

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            Console.WriteLine("a[{0},{1},{2}] = {3}", i, j, k, arr3d2[i, j, k]);
        }
    }
}