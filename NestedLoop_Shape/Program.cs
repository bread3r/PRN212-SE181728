void hinh1(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; i++)
        {
            if (j == 0 || j == n -1 || i == j)
            {
                Console.WriteLine("*");
            }
            else
            {
                Console.WriteLine(" ");
            }
            Console.WriteLine();
        }
    }
}