// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int marixDimension = ReadInt("Введите размерность квадратной матрицы: ");

int[,] matrix =  new int[marixDimension,marixDimension];

FillMatrixPerimetr(0, marixDimension-1, 1, matrix);
WriteMatrix(matrix);


void FillMatrixPerimetr(int startColumnIndex, int endColumnIndex, int startValue, int[,] fillingArray)
{
    for(int i = startColumnIndex; i <= endColumnIndex; i++)
    {
        fillingArray[startColumnIndex, i] = startValue;
        startValue++;
    }
    for(int i = startColumnIndex+1; i <= endColumnIndex; i++)
    {
        fillingArray[i, endColumnIndex] = startValue;
        startValue++;
    }
    
    for(int i = endColumnIndex-1; i >= startColumnIndex; i--)
    {
        fillingArray[endColumnIndex, i] = startValue;
        startValue++;
    }
    
    for(int i = endColumnIndex-1; i >= startColumnIndex+1; i--)
    {
        fillingArray[i, startColumnIndex] = startValue;
        startValue++; 
    }

    if(startColumnIndex+1 < endColumnIndex-1)
        FillMatrixPerimetr(startColumnIndex+1, endColumnIndex-1, startValue, fillingArray);
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