// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3

//Результирующая матрица будет:
//18 20
//15 18

int rowCount = ReadInt("Введите количество строк в матрице: ");
int columnCount = ReadInt("Введите количество столбцов в матрице: ");
int[,] firstMatix = new int[rowCount, columnCount]; 

int[,] secondMatrix = new int[rowCount, columnCount]; 

FillMatrixRandomNumbers(firstMatix);
FillMatrixRandomNumbers(secondMatrix);
WriteMatrix(firstMatix);
WriteMatrix(secondMatrix);

int[,] resultMatix = new int [rowCount, columnCount]; 

for(int i = 0; i < resultMatix.GetLength(0); i++)
{
    for(int j = 0; j < resultMatix.GetLength(1); j++)
    {
        resultMatix[i, j] = CalculateMatixElement(i, j, firstMatix, secondMatrix);
    }
}

WriteMatrix(resultMatix);


int CalculateMatixElement(int rowIndex, int columnIndex, int[,] fMatix, int[,] sMatix)
{
    int result = 0;

    for(int i = 0; i < fMatix.GetLength(1); i++)
    {
        result += fMatix[rowIndex, i] * sMatix[i, columnIndex];
    }
    return result;
}

void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 

