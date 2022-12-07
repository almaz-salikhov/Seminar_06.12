// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом

Console.WriteLine("Введите 5-значное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int one = N / 10000;
int two = N / 1000 % 10;
int four = N % 100 / 10;
int five = N % 100 % 10;
// Console.WriteLine("one: " + one);
// Console.WriteLine("two: " + two);
// Console.WriteLine("four: " + four);
// Console.WriteLine("five: " + five);

if(N > 9999 & N <= 99999) // проверяем, является ли оно 5-значным
{
    if(one == five & two == four) // проверяем, является ли оно палиндромом
    {
        Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Введенное число НЕ является палиндромом");
    }

}
else
{
    Console.WriteLine("Число не является 5-значным");
}