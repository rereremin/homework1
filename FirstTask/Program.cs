// получить пользовательский ввод
Console.Write("Введите целое число: ");
string UserInput = Console.ReadLine() ?? "";

// преобразовать строку в числ
int number = int.Parse(UserInput);

// вычислячем квадрат числа
int square = number * number;

// вывод резулитата
Console.WriteLine($"{number} -> {square}");


