/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.Clear();
int[,] matrix = CreateIntMatrix(10, 10, 1, 10);
int row = DataInput("строку ");
int col = DataInput("столбец ");
PrintIntMatrix(matrix);
if (CorrectIndexes(row, col, matrix))
    Console.WriteLine($"Указан элемент {ElementInIndexes(row, col, matrix)}");
else Console.WriteLine("Такого элемента нет");

int DataInput(string message)
{
    Console.Write("Введите " + message + ": ");
    int result = int.Parse(Console.ReadLine());
    return result;
}

void PrintIntMatrix(int[,] mtx)
{
    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < mtx.GetLength(1); j++)
            Console.Write($"{mtx[i, j]} ");
        Console.WriteLine("]");
    }
}

int[,] CreateIntMatrix(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            result[i, j] = new Random().Next(minValue, maxValue);
    return result;
}

int ElementInIndexes(int row, int col, int[,] mtx)
{
    return mtx[row-1, col-1];
}

bool CorrectIndexes(int row, int col, int[,] mtx)
{
    if (row <= mtx.GetLength(0) && col <= mtx.GetLength(1) && row > 0 && col > 0) return true;
    else return false;
}