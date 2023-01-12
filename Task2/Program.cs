/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120 */

/* 
Решение: 

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());

void Mult (int N)
{
    int sum = 1;
    for (int i = 1; i <= Math.Abs(N); i++) sum*= i;
    Console.Write($"Произведение чисел равно {sum}");
}

Mult(num);
 */







/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */


/* Console.Write("Эй ты, глянь что умею) Я тебе сейчас сделаю рандомный массив с 0 и 1))) Смотри :)  ");
Console.WriteLine();
int [] mass = new int[8];
for(int i = 0; i < mass.Length; i++)
{
    mass [i] = new Random().Next(2);
    Console.Write(mass [i]);
} */

/*

2 вариант решения

int[] GenerateArray(int length, int minNum, int maxNum)
{
    int[] arr = new int[length];
    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = new Random().Next(minNum, maxNum + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i=0;i<array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int arr_len = 8;
PrintArray(GenerateArray(arr_len, 0, 1));
 */



/* 

3 вариант решения


int[] array = GetBinaryArray(8);

// String.Join - позволит разделить значения какими-либо знаками
Console.WriteLine($" [ {String.Join(", ", array)} ] ");


int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }

    return result;
}

 */





/* 
Задача 26: Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
 */
/* 
Решение:

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());

void NumNum (int num)
{
    int chase = 0;
    while (num != 0)
    {
        num = num/10;
        chase += 1;
    }
    Console.Write($"Колличество символов в числе {chase}");
}

NumNum(num);
 */

/*

2 вариант решения:

Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
/* void CountNumbs(int numb)
{
    int result = 0;
    if (numb == 0)
    {
        result = 1;
    }
    while(numb > 0)
    { 
        numb = numb / 10;
        result++;
    }
    Console.WriteLine(result);
}

Console.WriteLine("Введите число");
CountNumbs(Math.Abs(Convert.ToInt32(Console.ReadLine())));
 */