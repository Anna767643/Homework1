//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

//Ввод двух чисел
Console.Write("Enter the first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int number2 = int.Parse(Console.ReadLine());

//Определение меньшего и большего числа, вывод 

if (number1 > number2)
{
    Console.WriteLine($"max = {number1}, min = {number2}");
}
else 
{
    Console.WriteLine($"max = {number2}, min = {number1}");
}
