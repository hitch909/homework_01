// принимает два числа и выдает, какое из чисел большее а какое меньшее.

Console.Write("введите первое число");
int num1 =int.Parse(Console.ReadLine()!);
Console.Write("введите второе число");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 > num2)
{
    Console.WriteLine($"число {num1} большее из двух , число {num2} меньшее");
}
{    
if (num2 > num1)
    Console.WriteLine($"число {num2} большее из двух , число {num1} меньшее");
}
// готово )).