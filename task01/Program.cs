/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число: ");
int value1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int value2 = int.Parse(Console.ReadLine()!);

if(value1 > value2) 
{
    Console.WriteLine($"Число {value1} больше, чем число {value2}");
}
else 
{
    Console.WriteLine($"Число {value1} меньше, чем число {value2}");
}