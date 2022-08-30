/* Задача 60. ...Сформируйте трёхмерный массив 
**из неповторяющихся** двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
*/

int m = 3;
int n = 3;
int p = 3;

int[] Numbers(int min, int max)
{
    int[] numbers = new int[max - min];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = min + i;
        Console.Write($"{numbers[i]} ");
    }
    return numbers;
}

int[,,] CreateMatrixRndNoDoubles(int m, int n, int p, int min, int max)
{
    int[,,] array = new int[m, n, p];
    int[] numbers = Numbers(min, max);
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int y = 0; y < p; y++)
            {
                int index = 0;
                while (index == 0)
                {
                    int number = rnd.Next(min, max);
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (number == numbers[k]) break;


                        index = 1;
                        array[i, j, y] = number;

                    }


                }

            }
        }
    }
    return array;
}

void PrintArray3D(int[,,] array)
{
    Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int y = 0; y < p; y++) Console.Write($"{array[i, j, y]}({i},{j},{y}) ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array = CreateMatrixRndNoDoubles(m, n, p, 10, 40);
PrintArray3D(array);

