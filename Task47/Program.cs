// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// Random random = new Random();

Console.WriteLine("Укажите размерность m массива:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите размерность n массива:  ");
int columns = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
double[,] massiv = new double[rows, columns];
FillArray(massiv);
PrintArray(massiv);

void FillArray(double[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = random.NextDouble();
            arr[i, j] = Math.Round((Convert.ToDouble(random.Next(0, 10)) + random.NextDouble()), 2);
        }
    }
}
void PrintArray(double[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}










