// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine($"Введите количество чисел:");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
for (int i = 0; i < M; i++)
{
    Console.WriteLine($"Введите число {i + 1}:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Введены числа:  {String.Join("; ", array)}");
int countPositive = 0;
for (int i = 0; i < M; i++)
{
    if (array[i] > 0)
    {
        countPositive++;
    }
}
Console.WriteLine($"Количество положительных чисел: {countPositive}");