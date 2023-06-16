/*
Задача 2: Напишите программу, которая на вход принимает два числа 
и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Алгоритм:
1. Запросить у user 2 числа и записать их (сконвертировав в int)
2. Обозначить переменную max, присвоить ей значение 1 числа
3. Сравнить max с 2 числом и записать какое число максимальное
4. Вывести результат
*/

Console.WriteLine("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
{
    max = b;
    Console.Write("Max number: " + max);
}
else
{
    Console.Write("Max number: " + max);
}
