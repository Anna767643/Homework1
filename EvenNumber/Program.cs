//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

//Ввод числа
Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0) 
{
    Console.WriteLine($"Tne number {number} is even");
}
else
{
     Console.WriteLine($"Tne number {number} is NOT even");  
}