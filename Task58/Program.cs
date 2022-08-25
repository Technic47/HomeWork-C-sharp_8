/* Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
*/

Console.WriteLine("Enter Maxtix A (X,..): ");
int m1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Maxtix A (..,Y): ");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Maxtix B (X,..): ");
int m2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Matrix B (..,Y): ");
int n2 = int.Parse(Console.ReadLine()!);

if (m1 != n2 || m2 != n1) // Защита от некорректных размеров для перемножения.
{
    Console.WriteLine("Incorect Mitrixs sizes for multiplication!");
    return;
}

int[,] FillArray(int m, int n) // Тут заполняются матрицы.
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array) // Тут выводятся матрицы.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0,3:d} ", array[i, j]));
        }
        Console.WriteLine();
    }
}

int[,] ArrayMult(int[,] array1, int[,] array2) // Тут какая-то матиматика. Вроде работает.
{
    int m = array1.GetLength(0); // Размер итоговой матрицы.
    int n = array2.GetLength(1);
    int[,] array3 = new int[m, n];

    int size = 0;
    if (array1.GetLength(0) < array1.GetLength(1)) size = array1.GetLength(1); // Выбор size для количества сложений.
    else size = array2.GetLength(0);

    for (int i = 0; i < m; i++) // Заполнение результирующей матрицы.
    {
        for (int j = 0; j < n; j++)
        {

            for (int p = 0; p < size; p++)
            {
                array3[i, j] += array1[i, p] * array2[p, j];
            }
        }

    }
    return array3;
}


int[,] array1 = FillArray(m1, n1);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = FillArray(m2, n2);
PrintArray(array2);
Console.WriteLine();
int[,] array3 = ArrayMult(array1, array2);
PrintArray(array3);
