// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.WriteLine("Введите число: ");
string Num = Console.ReadLine(); 
int N = int.Parse(Num);
int Sum = 0;

while (N>0)
{
    Sum = Sum + N % 10;
    N = (N-N % 10)/10;
}

System.Console.WriteLine($"Сумма цифр в числе равна {Sum}");