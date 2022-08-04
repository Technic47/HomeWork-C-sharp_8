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

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        sum = 0; // Обнуляем сумму.
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10); // Заполняем.
            Console.Write($"{array[i, j]} "); // Показываем.
            sum += array[i, j]; // Добавляем к сумме.
        }
        Console.Write($" Sum = {sum}");
        Console.WriteLine();
        if (sum < min) { min = sum; index = i + 1; }; // Смотрим какая меньше.
    }
}

PrintArray(array);
Console.WriteLine($"Min Sum is in line: {index}");