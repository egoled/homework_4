// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B 
// Показателем нат. степени является натуральное число.
//  натуральными называют целые числа, которые больше нуля
Console.WriteLine("Введите число A: ");
string NumberA = Console.ReadLine(); 
int A = int.Parse(NumberA);
Console.WriteLine("Введите число B: ");
string NumberB = Console.ReadLine();
int B = int.Parse(NumberB);
int result = 1;

if (B>0)
{
for (int i=0; i<B; i++)
{
    result = result*A;
}
Console.WriteLine($"A в натуральной степени B это {result}");
}
else
{
    System.Console.WriteLine("B не натуральное число");
}

