// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Console.Write("Input a three-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int number_1 = number/10;
// int number_2 = number_1%10;
// Console.Write(number_2);

// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Console.Write("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int number_1 = number/100;
// if (number_1 == 0)
// Console.Write("no third digit");
// else
// Console.Write(number % 10);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Enter a number representing the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6)
Console.Write("Day off");
else
if (number == 7)
Console.Write("Day off");
else
if (number > 0 & number < 6)
Console.Write("Working day");
else
Console.Write("Please enter a valid number");