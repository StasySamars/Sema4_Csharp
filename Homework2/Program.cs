/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. */

Console.Clear();
Console.Write("Введи число и я выведу тебе сумму цифр в числе: ");
string num = Console.ReadLine();
int sum = 0;
for (int i = 0; i < num.Length; i++)
{
    sum += Convert.ToInt32(Convert.ToString(num[i]));
}
Console.Write($"Сумма цифр в числе {num} равна: {sum}");


/*
Альтернативный вариант решения:

Console.Clear();
Console.Write("Напишите число (А):  ");
int sum = 0;
int a = int.Parse(Console.ReadLine());

    while(a != 0)
    { 
        sum += a%10;
        a/=10;
    }
Console.Write($"суммa цифр в числе: {sum}"); */

