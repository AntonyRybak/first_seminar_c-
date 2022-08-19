Console.Clear();
Console.Write("Напишите первое число ");
int numberone = int.Parse(Console.ReadLine());
Console.Write("Напишите второе число ");
int numbertwo = int.Parse(Console.ReadLine());
if (numberone > numbertwo)
{
    Console.WriteLine("Первое число больше, а второе число меньше");
}
else
{
    Console.WriteLine("Второе число больше, а первое число меньше");
}