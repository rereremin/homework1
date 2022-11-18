// программа принимает на вход два числа и выдает максимальное из них

Console.WriteLine("Данная программа определяеь максимальное из двух чисел");

Console.Write("Введите первое целое число: ");
string FirstNum = Console.ReadLine();
Console.Write("Введите второе целое число: ");
string SecondNum = Console.ReadLine();

int A = int.Parse(FirstNum);
int B = int.Parse(SecondNum);

if(A >= B)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine($"A = {A}");
}
else
{
    Console.Write("Максимальное число: ");
    Console.WriteLine($"B = {B}");
}