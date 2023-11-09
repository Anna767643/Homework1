//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

//Ввод чисел
Console.Write("Enter the first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Enter the third number: ");
int number3 = int.Parse(Console.ReadLine());

//Определение максимального числа и вывод
int max = number1;
if (number2 > max)  max = number2;
if (number3 > max)  max = number3;

Console.WriteLine($"max = {max}");

