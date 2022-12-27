// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows,columns]; 

FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers); 

BubbleSort(numbers);
WriteMatrix(numbers);


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

void BubbleSort (int [,] array)
{
    for(int i = 0; i < numbers.GetLength(0); i++)
    {        
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            for(int a = 0; a < numbers.GetLength(1)-1-j; a++)
            {
                if(numbers[i, a+1] > numbers[i,a])
                {
                    int temp = numbers[i,a];
                    numbers[i,a] = numbers[i,a+1];
                    numbers[i, a+1] = temp;         
                }
            }
        }
    }
}

    
   

