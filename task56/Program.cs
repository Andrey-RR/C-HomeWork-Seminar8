// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка




int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов: ");
int[,] array = GetArray(rows, columns);

PrintArray(array);

int[] SummArray = RowSum(array);

PrintArray1(SummArray);
MinSum(SummArray);

int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetArray(int row, int column)
{
    int[,] res = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            res[i, j] = new Random().Next(1, 10);
        }
    }
    return res;
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] RowSum(int[,] arr)
{
    int[] result = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ = summ + arr[i, j];
        }
        result[i] = summ;
    }
    return result;
}

void PrintArray1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Сумма элементов в строке номер {i+1} = {array[i] + "  "}");
    }
    Console.WriteLine();

}

void MinSum (int[] array)
{
    int minNumb = 0;
for (int i = 1; i < array.Length; i++)
    {
         if(array[i]<array[minNumb])
            minNumb = i;
    }
    Console.WriteLine($"Натменьшая сумма элементов: {minNumb+1} строка");
}
