/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет

Алгоритм:
1. Запросить у user число и записать его (сконвертировав в int)
2. Добавить переменную, которая будет отражать результат деления
3. Произвести деление с остатком на 2
4. Добавить условие, чтобы проверить есть ли остаток от деления
5. Вывести результат
*/

Console.WriteLine("Input random number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 2;
if (result == 0)
{
    Console.WriteLine("The number " + number + " is even");
}
else
{
    Console.WriteLine("The number " + number + " is NOT even"); 
}
