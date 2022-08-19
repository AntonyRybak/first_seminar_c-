Console.Clear();
Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine());
int i = 0;
int lenght = n - 1;
while (i < lenght) 
{
    i += 2;
    Console.Write($"{i}, ");  
}

    



