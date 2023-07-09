﻿/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());

int SumNumbers(int n) //название в самом методе можно поменять
{
    int sum = 0;
    while(n > 0){
        sum += n % 10;
        n = n/10;
    }
    return sum;
}Console.WriteLine($"  Cумма цифр в числе {SumNumbers(A)}");
