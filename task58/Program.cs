// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int rows1 = GetNum("Введите количество строк матрицы 1: ");
int columns1 = GetNum("Введите количество столбцов матрицы 1: ");
int[,] matrix1 = GetMatrix(rows1, columns1);

int rows2 = GetNum("Введите количество строк матрицы 2: ");
int columns2 = GetNum("Введите количество столбцов матрицы 2: ");
int[,] matrix2 = GetMatrix(rows2, columns2);

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
int[,] resultMatrix = MultiplyMatrx(matrix1, matrix2);

Console.WriteLine("Матрица 1 :");
PrintArray(matrix1);
Console.WriteLine("Матрица 2 :");
PrintArray(matrix2);
Console.WriteLine("Произведение матриц :");
PrintArray(resultMatrix);
} 
 else
 {
     Console.WriteLine("Количество столбцов 1 матрицы не равно количеству строк 2 матрицы");
 }
int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
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

int[,] MultiplyMatrx(int[,] matrix1, int[,] matrix2)
{
    int rowsA = matrix1.GetLength(0);
    int columnsB = matrix2.GetLength(1);

    int[,] result = new int[rowsA, columnsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < columnsB; j++)
        {
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                result[i,j]+= matrix1[i, n] * matrix2[n, j];
            }
        }
    }
    return result;
}