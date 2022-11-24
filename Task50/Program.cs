// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите индекс строки: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void CheckCoordinates(int[,] matrix, int userRow, int userColumn)
{
    if (userRow < matrix.GetLength(0) && userColumn < matrix.GetLength(1)) Console.WriteLine($"Заданным индексам соответствует число: {matrix[userRow, userColumn]}");
    else Console.WriteLine($"Числа с индексом [{userRow}, {userColumn}] в массиве нет");

}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

int[,] array = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array);
CheckCoordinates(array, str, col);