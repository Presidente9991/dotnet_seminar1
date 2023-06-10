/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int i = 1;
bool not = true;

Console.Write("Введите число: ");
int value = int.Parse(Console.ReadLine()!);

Console.Write($"Чётные числа от 1 до {value}: ");

while (i <= value)
{
    if(i % 2 != 1)
    {
        Console.Write(i + " ");
        not = false;
    }
    i++;
}

if(not)
{
    Console.WriteLine("в указанном числовом ряде нет чётных чисел!");
}