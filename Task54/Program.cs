/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
*/

int m = 5;
int n = 5;

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++) array[i, j] = new Random().Next(0, 10);
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m - 1; j++)
        {
            for (int sort = j + 1; sort < m; sort++)
            {
                if (array[i, j] < array[i, sort])
                {
                    temp = array[i, sort];
                    array[i, sort] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
}

PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);