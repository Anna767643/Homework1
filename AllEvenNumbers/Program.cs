//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//Ввод числа
Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine());

//Цикл
int evenNumber = 2;
while (evenNumber <= number)
{
    Console.Write($"{evenNumber}, ");
    evenNumber = evenNumber + 2;
}