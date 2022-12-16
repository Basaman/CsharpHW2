//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число 1: ");
string userInput_A = Console.ReadLine() ?? "";
Console.Write("Введите число 2: ");
string userInput_B = Console.ReadLine() ?? "";
Console.Write("Введите число 3: ");
string userInput_C = Console.ReadLine() ?? "";

double number_A = double.Parse(userInput_A);
double number_B = double.Parse(userInput_B);
double number_C = double.Parse(userInput_C);
double max = double.Parse(userInput_A);

if (number_B > max) max = number_B;
if (number_C > max) max = number_C;


Console.WriteLine ("Максимальное из трёх чисел равно: ");
Console.WriteLine (max);
