﻿//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine($" В числе {CountNumbers(A)} цифр");

int CountNumbers(int n) //название в самом методе можно поменять
{
    int count = 0;
    while(n > 0){
        n /= 10;
        count++;
    }
    return count;
}