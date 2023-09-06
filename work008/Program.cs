// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
while(count <= num - 2)
{
    count = count + 2;
    Console.Write(count);
    Console.Write("; ");
}
