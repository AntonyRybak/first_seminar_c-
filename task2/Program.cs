Console.Clear();
Console.Write("Введите первое число ");
int numberone = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int numbertwo = int.Parse(Console.ReadLine());
Console.Write("Введите третье число ");
int numberthree = int.Parse(Console.ReadLine());
int max = 0;
if (numberone > numbertwo)
{
    max = numberone;
}
if (numbertwo > numberone)
{
    max = numbertwo;
}
if (numberthree > max)
{
    max = numberthree;
}
Console.Write($"Наибольшее число {max}");




