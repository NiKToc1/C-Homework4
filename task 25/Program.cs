Console.Clear();

Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);
int result = A;

for(int i = 1; i < B; i++)
result = result * A;

Console.WriteLine(result);