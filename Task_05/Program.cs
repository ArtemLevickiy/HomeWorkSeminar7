// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно 
//(в случае, если матрица не квадратная).

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
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[j, i]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Задайте длинну массива = ");
int length = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Задайте высоту массива = ");
int height = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[length, height];

if (length != height)
{
    Console.Write("замена строк на столбцы - невозможна (матрица не квадратная)");
    return;
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangeArray(matrix);