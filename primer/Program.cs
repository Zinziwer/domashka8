void FillArray2d(int[,] collection, int minValue = 0, int maxValue = 500)
{
    Random random = new Random();
    int rows = collection.GetLength(0);
    int columns = collection.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            collection[i, j] = new Random().Next(minValue, maxValue);
        }
    }
}
void PrintArray2d(int[,] col)
{
    int rows = col.GetLength(0);
    int columns = col.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(col[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

//Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
void Zadacha54()
{
    Console.Clear();
    Random random = new Random();
    int rows = random.Next(4, 7);
    int columns = random.Next(3, 8);
    int[,] numbers = new int[rows, columns];
    FillArray2d(numbers, 0, 99);
    PrintArray2d(numbers);
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - j - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    (numbers[i, k], numbers[i, k + 1]) = (numbers[i, k + 1], numbers[i, k]);
                }
            }
        }
    }
    PrintArray2d(numbers);
}
//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Zadacha56()
{
    //Console.Clear();          // Денис, я мозг сломал, если раскомментировать Console.Clear происходит что-то непонятное
    Random random = new Random();
    int rows = random.Next(4, 7);
    int columns = random.Next(3, 8);
    int[,] numbers = new int[rows, columns];
    FillArray2d(numbers, 0, 10);
    PrintArray2d(numbers);
    Console.WriteLine();

    int minSumm = 1000;
    int minI = 0;

    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += numbers[i, j];
        }
        //Console.WriteLine($" Row {i+1} sum {sum}");

        if (sum < minSumm)
        {
            minSumm = sum;
            minI = i;
        }
    }
    Console.WriteLine($"Row {minI + 1} with minimal sum {minSumm}");
}

//Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4.
void Zadacha58()
{
    int rows = 4;
    int columns = 4;
    int num = 1;
    int[,] numbers = new int[rows, columns];

    for (int j = 0; j < columns; j++)           //Вижу что хреновое решение. Другое пока в голову не лезет((
    {
        numbers[0, j] = num;
        num++;
    }
    for (int i = 1; i < rows; i++)
    {
        numbers[i, 3] = num;
        num++;
    }
    for (int j = 2; j >= 0; j--)
    {
        numbers[3, j] = num;
        num++;
    }
    for (int i = 2; i >= 1; i--)
    {
        numbers[i, 0] = num;
        num++;
    }
    for (int j = 1; j < columns - 1; j++)
    {
        numbers[1, j] = num;
        num++;
    }
    for (int j = 2; j >= 1; j--)
    {
        numbers[2, j] = num;
        num++;
    }
    PrintArray2d(numbers);
}
//Zadacha56();
//Zadacha54();
Zadacha58();