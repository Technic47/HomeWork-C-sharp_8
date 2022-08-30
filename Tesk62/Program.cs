﻿/* Задача 62. Напишите программу, 
которая заполнит спирально массив 4 на 4.
*/

Console.WriteLine("Enter array length: ");
int n = int.Parse(Console.ReadLine()!);

int[,] CreateMatrix (n)
{
int[,] matrix = new int[N, N]; // Работае при N > 4.
int a = 1;
int i = 0;
int j = 0;
int count = 0;


while (matrix[(i + 1), j] == 0 || matrix[(i - 1), j] == 0 || matrix[i, (j + 1)] == 0 || matrix[i, (j - 1)] == 0 || matrix[i, j] == 0)
{
    while (i < (N - count)) // строка направо
    {
        matrix[i, j] = a;
        a++;
        i++;
    }
    i--;
    j++;

    while (j < (N - count)) // столбец вниз
    {
        matrix[i, j] = a;
        a++;
        j++;
    }
    j--;
    i--;

    while (i >= (0 + count)) // строка налево
    {
        matrix[i, j] = a;
        a++;
        i--;
    }
    i++;
    j--;
    count++;

    while (j >= (0 + count)) // столбец вверх
    {
        matrix[i, j] = a;
        a++;
        j--;
    }
    j++;
    i++;
}
}



void PrintArray(int[,] matr)
{
    for (int j = 0; j < N; j++)
    {
        for (int i = 0; i < N; i++)
        {
            Console.Write(string.Format("{0,2:d} ", matr[i, j]));
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(N,N);
PrintArray(matrix);