// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void FillArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write($"{newArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SearchElement(int[,] newArray)
{
    Console.WriteLine("Введите номер искомой строки");
    int row1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер искомого столбца");
    int column1 = Convert.ToInt32(Console.ReadLine());

    if (row1 <= newArray.GetLength(0) && column1 <= newArray.GetLength(1))
    {

        Console.Write($"Значение элемента {row1} строки и {column1} столбца = {newArray[row1 - 1, column1 - 1]}");
    }
    else
    {
        Console.WriteLine("Tакого элемента нет");
    }
    Console.WriteLine();
}


Console.Write("Введите количество строк для генерации массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для генерации массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] newArray = new int[rows, columns];
FillArray(newArray);
SearchElement(newArray);
Console.WriteLine("В массиве:");
PrintArray(newArray);




