/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
*/

int m = 5;
int n = 5;

int[,] CreateMatrixRnd(int m, int n, int min, int max)
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

void PrintArray2D(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j],2} ");
        }
        Console.WriteLine();
    }
}

int[] SumLine(int[,] array)
{
    int[] sum = new int[m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            sum[i] += array[i, j];
    }
    return sum;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Sum{i} = {array[i],2} ");
    }
}

int MinSum(int[] array)
{
    int index = 0;
    int min = array[0];
    for (int i = 0; i < m; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    return index;
}

int[,] array = CreateMatrixRnd(m, n, 0, 9);
PrintArray2D(array);
int[] sum = SumLine(array);
PrintArray(sum);
Console.WriteLine($"Min Sum is in line: {MinSum(sum) + 1}");