/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
*/

int m = 5;
int n = 5;

int[,] CreateMatrixRnd (int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    Random rnd = new Random(); 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j], 2} ");
        }
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

int[,] array = CreateMatrixRnd(m, n, 0, 9);
PrintArray(array);
SortArray(array);
PrintArray(array);