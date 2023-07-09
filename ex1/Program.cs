//Напишите программу, которая принимает число A
//и на выходе выдает сумму чисел от 1 до А

Console.Clear();
Console.Write("Введите число: ");
int limit = int.Parse(Console.ReadLine());

int GetSum(int n) //название в самом методе можно поменять
{
    int sum = 0;
    for (int i = 1; i<= n; i++){
        sum += i;
        sum++;
    }
    return sum;
}
Console.WriteLine($"Сумма числе от 1 до {limit} равна {GetSum(limit)}");