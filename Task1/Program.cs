/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int x = 0; x <= a; x++)
{
    sum += x;
}
Console.Write(sum);

/* 
2 вариант
Console.Clear();

int a = int.Parse(Console.ReadLine());

int Sum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++) sum+= i;
    return sum;
}

Console.Write(Sum(a)); */


/* 
3 вариант
int SumOfNumberFrom(int from, int number)
{
    int sum = 0;
    for (int i=from;i<=number;i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Input number");

int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum is {SumOfNumberFrom(1, number)}"); */

/* 
!!!Решение при помощи Void - огонь прост!!!!

void GetSumNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++)
    {
        sum += i;
    } 
    Console.WriteLine($"Cумма цифр от 1 до {Math.Abs(number)}: {sum}");

}

Console.Clear();

GetSumNums(-5);
GetSumNums(58);
GetSumNums(25);
GetSumNums(16);

Console.WriteLine("Введите число A");
int n = Convert.ToInt32(Console.ReadLine());
GetSumNums(n);

Console.WriteLine("Введите число A");
GetSumNums(Convert.ToInt32(Console.ReadLine()));
 */