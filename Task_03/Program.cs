// Написать программу, которая обменивает элементы первой строки и последней строки

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void ChangeArray(int[,] matr)
{
    int N = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == 0 || i == matr.GetLength(0))
            {
                N = matr[i, j];
                matr[i, j] = matr[matr.GetLength(0) - 1, j];
                matr[matr.GetLength(0)-1, j] = N;
                Console.Write($"{matr[i, j]} ");
            }
            else
            {
                Console.Write($"{matr[i, j]} ");
            }

        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4, 5];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangeArray(matrix);