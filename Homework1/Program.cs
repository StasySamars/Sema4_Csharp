/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

 */
 
Console.Clear();

Console.WriteLine("Привет, сейчас мы возведем какое-нибудь число в какую-нибудь степень, для этого нужно ввести два числа. Погнали: ");
Console.WriteLine("Введи 1-е число = ");
int a =  int.Parse(Console.ReadLine());
Console.Write("Введи 2-е число = ");
int b =  int.Parse(Console.ReadLine());
int mult = 1;
for (int i = 1; i <= b; i++)
{
    mult *= a;
}
Console.Write($"Число {a} в степени {b} равно: ");
Console.Write(mult);

