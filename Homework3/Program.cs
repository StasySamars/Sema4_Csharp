﻿/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */
Console.Clear();
Console.WriteLine("Го замутим рандомный массив :) ");

int [] mass = new int[8];
for(int i = 0; i < mass.Length; i++)
{
    mass [i] = new Random().Next(9999);
} 
Console.WriteLine($" [ {String.Join(", ", mass)} ] ");