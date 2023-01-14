// максимальное из трех чисел.

Console.WriteLine("введите три числа");
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
int C = int.Parse(Console.ReadLine()!);
int max = A;
if (B>A && B>C)
{
   max = B;
}
if (C>A && C>B)
{
   max = C;
}
Console.Write($" {max} большее из трех");
