// 1 Напишите программу, которая принимает на вход число (N) 
// 2 и помещает в массив таблицу кубов чисел от 1 до N. 
// 3 Полученный массив вывести на экран.

// 1 принимаем число 

int[] FillArray(int[] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = i + 1;
        Console.Write(array[i] + " ");
    }
    return array;
}
void PrintStepenArray(int[] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        double stepen = 3;
        array[i] = (int)Math.Pow(array[i], stepen);
        Console.Write((array[i] + " "));
    }
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

int[] FilledArray = FillArray(array, N); // создаем массив от 1 до N 
Console.WriteLine(); // отделяем визуально 
PrintStepenArray(FilledArray, N);// Выводим на экран

