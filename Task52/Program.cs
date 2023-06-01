// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(double[,] newArray)
{
    
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(double[,] newArray)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write($"{newArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SearchAverage(double[,] newArray)
{
    
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            average = average + newArray[i, j] / newArray.GetLength(0);
            average = Math.Round(average,1);
        }
        Console.Write($"{average}; ");
    }
   
}


Console.Write("Введите количество строк для генерации массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для генерации массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] newArray = new double[rows, columns];
FillArray(newArray);
PrintArray(newArray);
Console.Write("Среднее арифметическое элементов в каждом столбце = ");
SearchAverage(newArray);


