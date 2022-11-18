// программа на вход принимает число N и выводит все четные числа от 1 до N

Console.WriteLine("Вывод всех четных чисел от 1 до N");
Console.Write("Введите число N: ");
string UserN = Console.ReadLine();

int N = int.Parse(UserN);

int i = 0;
while(i <= N)
{
    if(i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i ++;
}