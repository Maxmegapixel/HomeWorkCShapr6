﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. (Можно изучить метод Split.
// Пример: stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);, где первый аргумент это разделитель чисел, второе обработчик введеной последовательности)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите последовательность чисел через пробел: ");
string StVal = Console.ReadLine()!;
Console.WriteLine($"Чисел больше нуля: {GetNumber(GetArray(StVal))}");

int[] GetArray(string StNum)  // метод получения массива из строки чисел
{
    int Count = 1;
    foreach (var ch in StNum) if (ch == ' ') Count += 1;
    int[] Array = new int[Count];
    int j = 0;
    for (int i = 0;i<Count; i++)
    {
        string Str = "";
        for (; StNum[j] != ' '; j++)
        {
            Str += StNum[j];
            if (j==StNum.Length -1) break;
        }
        Array[i] = int.Parse(Str);
        j++;
    }
    return Array;
}
int GetNumber(int[] Array)  //метод получения количества чисел больших 0 в массиве
{
    int Num =0;
    foreach (int item in Array)
    {
        Num += item > 0? 1:0;
    }
    return Num;
}
