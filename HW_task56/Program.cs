// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов, бОльшее чем строк: ");
int[,] numbers = new int[rows, columns]; 
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers); 

int minRowIndex = 0;
int minRowSum = 0;
for(int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        sum += numbers [i,j]; 
    }
    
    if(i == 0 || minRowSum > sum)
    {
        minRowSum = sum;
        minRowIndex = i;
    }
}
Console.WriteLine(minRowIndex+1 + " row");  
Console.WriteLine(minRowSum + " - min sum");  


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

