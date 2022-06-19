// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.WriteLine("Введите число A: ");
string NumberA = Console.ReadLine(); 
int A = int.Parse(NumberA);
Console.WriteLine("Введите число B: ");
string NumberB = Console.ReadLine();
int B = int.Parse(NumberB);
int result = 1;

for (int i=0; i<B; i++)
{
    result = result*A;
}

Console.WriteLine($"A в натуральной степени B это {result}");