// 1 Напишите программу, которая принимает на вход число (N) 
// 2 и помещает в массив таблицу кубов чисел от 1 до N. 
// 3 Полученный массив вывести на экран.

// 1 принимаем число 
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

void FillArray(int[] array)
{
    for (int i = 0; i < N; i++)
    {
        array[i] = i + 1;
        Console.Write(array[i] + " ");
    }
}
void PrintStepenArray(int[] array)
{
    for (int i = 0; i < N; i++)
    {
        double stepen = 3;
        array[i] = (int)Math.Pow(array[i], stepen);
        Console.Write((array[i] + " "));

    }
}

FillArray(array); // создаем массив от 1 до N 
Console.WriteLine(); // отделяем визуально 
PrintStepenArray(array);// Выводим на экран

