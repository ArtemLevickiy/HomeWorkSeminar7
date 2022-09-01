// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void AverageArray(double[,] matr)
{
    Console.WriteLine($"Среднее арифметическое:");
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double summ=0;
        int count =0;
        double average=0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            summ =summ+matr[i, j];
            count++;
        }
        average= summ/count;
        //Console.WriteLine($"{j+1}-го столбца = {average} ");
        Console.Write($"{average}\t");
    }
}

double[,] matrix = new double[10, 10];

FillArray(matrix);
PrintArray(matrix);
AverageArray(matrix);

