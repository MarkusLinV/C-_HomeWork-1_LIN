// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число №1 ");
int nam1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2 ");
int nam2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №3 ");
int nam3 = Convert.ToInt32(Console.ReadLine());

int max = nam1;

if(nam2 > max)
{
    max = nam2;
}
if(nam3 > max)
{
    max = nam3;
}
Console.Write(max);