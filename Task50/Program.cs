// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Укажите размерность m вашего массива:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите размерность n вашего массива:  ");
int columns = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int[,] numbers = new int[rows, columns];
FillArray(numbers);
PrintArray(numbers);
FindElement(numbers);

void FillArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void FindElement(int[,] numbers)
{
    Console.WriteLine("Введите координаты числа для поиска в массиве: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > rows - 1 || b > columns - 1)
    {
        Console.WriteLine("Числа по заданным координатам в массиве нет!");
    }
    else
    {
        object c = numbers.GetValue(a, b);
        Console.WriteLine("Элемент с такими координатами найден, он равен: "+ c);
    }
}
