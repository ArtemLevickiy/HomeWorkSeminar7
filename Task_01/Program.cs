// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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
void NumberSearchArray(int[,] matr, int numbers)
{
    int count =0;
    Console.Write($"Позиция числа {numbers} в массиве: ");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == numbers)
            {
                Console.Write($"({i},{j}) ");
                count++;
            }
        }
    }
    if(count == 0) 
    Console.WriteLine($"Отсутствует");

}

int[,] matrix = new int[5, 5];

Console.Write("Задайте число для поиска (0,9) = ");
int number = int.Parse(Console.ReadLine() ?? "0");

FillArray(matrix);
PrintArray(matrix);
NumberSearchArray(matrix, number);