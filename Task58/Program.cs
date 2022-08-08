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

//int m = 6; // Для ручного тестирования.
//int n = 3;

int[,] FillArray(int m, int n) // Тут заполняются и выводятся матрицы.
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

void ArrayMult(int[,] array1, int[,] array2)
{
    int sum = 0;
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

            for (int p = 0; p < size; p++) sum += array1[i, p] * array2[p, j]; // Тут какая-то матиматика. Честно, сам делал) Вроде работает.
            array3[i, j] = sum;
            sum = 0;
            Console.Write(string.Format("{0,3:d} ", array3[i, j]));
        }
        sum = 0;
        Console.WriteLine();
    }
}

int[,] array1 = FillArray(m1, n1);
Console.WriteLine();
int[,] array2 = FillArray(m2, n2);
Console.WriteLine();
ArrayMult(array1, array2);