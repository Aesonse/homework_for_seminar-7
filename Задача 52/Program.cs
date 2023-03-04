//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

Console.Clear();
int[,] matrix = CreateIntMatrix(10, 10, 1, 10);
PrintIntMatrix(matrix);
PrintMediumCol(matrix);

int[,] CreateIntMatrix(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            result[i, j] = new Random().Next(minValue, maxValue);
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

void PrintMediumCol(int[,] mtx)
{
    double[] mediumCol = new double[mtx.GetLength(1)];
    for (int j = 0; j < mtx.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < mtx.GetLength(0); i++)
        {
            sum += mtx[i, j];
        }
        mediumCol[j] = (double) sum / mtx.GetLength(0);
    }
    Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", mediumCol)}.");
}