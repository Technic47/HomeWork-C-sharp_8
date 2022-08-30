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
    Console.WriteLine("Incorect Mitrix sizes for multiplication!");
    return;
}

int[,] FillArray(int m, int n, int min, int max)
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0,3:d} ", array[i, j]));
        }
        Console.WriteLine();
    }
}

int[,] ArrayMult(int[,] array1, int[,] array2) // Тут какая-то математика. Вроде работает.
{
    int m = array1.GetLength(0); // Размер итоговой матрицы.
    int n = array2.GetLength(1);
    int[,] array3 = new int[m, n];
    int size = 0;
    if (array1.GetLength(0) < array1.GetLength(1)) size = array1.GetLength(1); // Выбор size для количества сложений. Нужно, если матрицы не равны.
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


int[,] array1 = FillArray(m1, n1, 0, 9);
PrintArray(array1);
int[,] array2 = FillArray(m2, n2, 0, 9);
PrintArray(array2);
int[,] array3 = ArrayMult(array1, array2);
PrintArray(array3);
