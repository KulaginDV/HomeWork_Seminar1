/*
Задача 4: Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Алгоритм:
1. Запросить у user 3 числа (а,b,c) и записать их (сконвертировав в int)
2. Обозначить переменную max, присвоив ей значение (a)
3. Сравнить поочередно все переменные
4. Вывести результат
*/

Console.WriteLine("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
    {
        if (a > c)
        {
            Console.WriteLine("Max number: " + a);
        }
        else
        {
            Console.WriteLine("Max number: " + c);
        }
    }
else 
    if (b > c)
        {
            Console.WriteLine("Max number: " + b);
        }
    else
        {
            Console.WriteLine("Max number: " + c);
        }

