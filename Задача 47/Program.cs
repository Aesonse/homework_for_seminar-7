/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
Console.Clear();
int m = DataInput("число строк");
int n = DataInput("число столбцов");
int min = DataInput("минимальное значение");
int max = DataInput("максимальное значение");
double[,] matrix = CreateDoubleMatrix(m, n, min, max);
PrintDobleMatrix(matrix, 2);

int DataInput(string message)
{
    Console.Write("Введите " + message + ": ");
    int result = int.Parse(Console.ReadLine());
    return result;
}

void PrintDobleMatrix(double[,] mtx, int accuracy)
{
    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < mtx.GetLength(1); j++)
            Console.Write($"{Math.Round(mtx[i, j], accuracy)} ");
        Console.WriteLine("]");
    }
}
double[,] CreateDoubleMatrix(int row, int col, int minValue, int maxValue)
{
    double[,] result = new double[row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    return result;
}