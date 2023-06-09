Console.Clear();

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
int result = 0;

while (A > 0)
{
    int chislo = A % 10;
    A = A / 10;
    result = result + chislo;
}

Console.WriteLine($"Сумма цифр числа: {result}");
