// принимаем число и определяем является ли оно четным/нечетным
Console.WriteLine("Опредлеим является число четным или нечетным. ");
Console.Write("Введите число: ");
string UserNumber = Console.ReadLine();

int number = int.Parse(UserNumber);

if(number % 2 == 0)
{
    Console.WriteLine("Число явяляется четным.");
}
else
{
    Console.WriteLine("Число явяляется нечетным.");
}
