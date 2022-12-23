// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateArray(int rows, int columns, int hight)
{
    int[,,] array = new int[rows, columns, hight];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int h = 0; h < hight; h++)
            {
                array[i, j, h] = new Random().Next(0, 11);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                Console.Write($"{array[i, j, h]} ({i}, {j}, {h})\t");
            }
            Console.WriteLine(" ");
        }
    }
}
Console.Write("Enter the number of rows...");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns..");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of hight...");
int hight = int.Parse(Console.ReadLine()!);
int[,,] array = new int[rows, columns, hight];
array = CreateArray(rows, columns, hight);
Console.WriteLine(" ");
PrintArray(array);
Console.WriteLine(" ");