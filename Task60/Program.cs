/* Задача 60. ...Сформируйте трёхмерный массив 
**из неповторяющихся** двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
*/

int m = 3;
int n = 3;
int p = 3;

int[,,] array = new int[m, n, p];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int y = 0; y < p; y++) array[i, j, y] = new Random().Next(10, 100);
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int y = 0; y < p; y++)  Console.Write($"{array[i, j, y]}({i},{j},{y}) ");
            Console.WriteLine();
        }
    }
}

PrintArray(array);
