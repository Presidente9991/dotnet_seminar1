/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

Console.Write("Введите первое число: ");
int value1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int value2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int value3 = int.Parse(Console.ReadLine()!);

int max_value = value1;

if(value2 > max_value)
{
    max_value = value2;
}

if(value3 > max_value) 
{
    max_value = value3;
}

Console.WriteLine($"Из указанных чисел наибольшее {max_value}");