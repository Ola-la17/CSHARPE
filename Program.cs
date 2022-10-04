// See https://aka.ms/new-console-template for more information
Console.WriteLine("OLA-LA");

Console.WriteLine("Введите первое число: 2,3,7");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: 44,5,78");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: 22,3,9");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("Максимальное число: " + firstNumber);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + thirdNumber);
    }
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine("Максимальное число: " + secondNumber);
}
else
{
    Console.WriteLine("Максимальное число: " + thirdNumber);
}
