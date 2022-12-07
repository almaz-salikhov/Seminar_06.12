// 1 Напишите программу, которая принимает на вход число (N) 
// 2 и помещает в массив таблицу кубов чисел от 1 до N. 
// 3 Полученный массив вывести на экран.

// получаем число N от пользователя
// находим ряд от 1 до N 
// возводим в куб каждое число 
// наполянем массив кубами этих чисел от1 
// выводим массив функцией 

// 1 принимаем число 
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
// находим ряд от 1 до N 
for (int i = 0; i < N; i++)
{
    array[i] = i + 1;
    Console.Write(array[i] + " ");

}
Console.WriteLine();
// Выводим на экран
for (int i = 0; i < N; i++)
{
    double stepen = 3;
    array[i] = (int)Math.Pow(array[i], stepen);
    Console.Write((array[i] + " "));

}