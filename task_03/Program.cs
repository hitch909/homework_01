// четное или не четное.

Console.WriteLine("введите любое целое число");
int number = int.Parse(Console.ReadLine()!);
if (number % 2 == 0)
{
    Console.Write($"введенное число {number} является ЧЕТНЫМ");
}
if (number % 2 != 0)
{
    Console.Write($"введенное число {number} является НЕЧЕТНЫМ");    
}
