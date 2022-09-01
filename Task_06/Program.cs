// В прямоугольной матрице найти строку с наименьшей суммой элементов.


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
    int minString = 0;
    int sum = 0;
    int minSum = matr.GetLength(0) * 9; // 9 - максимально допустимое рандомное число в массиве
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        Console.WriteLine($"сумма {i + 1}-й строчки = {sum}");
        if (sum < minSum)
        {
            minSum = sum;
            minString = i+1;
        }
        sum=0;
    }
    Console.WriteLine($"Строка {minString} с наименьшей суммой элементов ({minSum})");
}


int[,] matrix = new int[10, 4];

FillArray(matrix);
PrintArray(matrix);
ChangeArray(matrix);