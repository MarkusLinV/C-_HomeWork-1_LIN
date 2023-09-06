//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

using System.Diagnostics;

Console.Write("Введите число №1: ");
int nam1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2: ");
int nam2 = Convert.ToInt32(Console.ReadLine());
if(nam1 > nam2)
{
    Console.Write("max = ");
    Console.WriteLine(nam1);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(nam2);
}