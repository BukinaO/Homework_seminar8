// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int marixDimension = ReadInt("Введите размерность трёхмерного массива (не более 4х): ");

int[,,] matrix =  new int[marixDimension,marixDimension,marixDimension];
int[] repetitionCheckArray = new int[99];

FillArrayNonRepetitionNumbers(matrix);
WriteArray(matrix);

void FillArrayNonRepetitionNumbers(int[,,] array)
{
    int i = 0;
    while(i < array.GetLength(0))
    {
        int j = 0;
        while(j < array.GetLength(1))
        {
            int k = 0;
            while(k < array.GetLength(2))
            {
                int number = new Random().Next(10, 99);
                if(repetitionCheckArray[number] != 1)
                {
                    repetitionCheckArray[number] = 1;
                    array[i, j, k] = number;
                    k++;
                }
            }
            j++;
        }
        i++;
    }
}

void WriteArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("[{1},{2},{3}] - {0} ", array[i, j, k], i, j, k);
            }
            Console.WriteLine();
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

