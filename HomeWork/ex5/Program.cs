﻿/*Задача 25:Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


Console.Clear();
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());

int GetPow(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++){
        result = result * a;
    }
    return result;
}    
Console.WriteLine($"{GetPow(A, B)}");