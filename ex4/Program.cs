// программа принимает три числа и выдает максимаьлное

Console.WriteLine("Данная программа определяеь максимальное из двух чисел");

Console.Write("Введите первое целое число: ");
string FirstNum = Console.ReadLine();
Console.Write("Введите второе целое число: ");
string SecondNum = Console.ReadLine();
Console.Write("Введите второе целое число: ");
string ThirdNum = Console.ReadLine();

int A = int.Parse(FirstNum);
int B = int.Parse(SecondNum);
int C = int.Parse(ThirdNum);

if(A < B)
{
    if(B < C)
    {
        Console.WriteLine($"Максимальное число - {C}");
    }
    else
    {
        Console.WriteLine($"Максимальное число - {B}");
    }
}
else
{
    Console.WriteLine($"Максимальное число - {A}");
}

