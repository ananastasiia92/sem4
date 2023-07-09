//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());


int GetComposition(int n) //название в самом методе можно поменять
{
    int comp = 1;
    for (int i = 1; i <= N; i++){
        comp = comp*i;
    }    
    return comp;
}
Console.WriteLine($"Произведение чисел от 1 до {N} равна {GetComposition(N)}");