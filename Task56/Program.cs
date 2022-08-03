/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
*/

int m = 5;
int n = 10;
int min = 100;
int sum = 0;
int index = 0;

int[,] array = new int[m, n];
/*
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 10);

    }
}
*/
void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        sum = 0;
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]} ");
            sum += array[i, j];
        }
        Console.Write($" {sum}");
        Console.WriteLine();
        if (sum < min) { min = sum; index = i + 1; };
    }
}

PrintArray(array);
Console.WriteLine($"Min sum is in line: {index}");