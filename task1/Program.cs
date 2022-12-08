void FillArray(int[] arr, int len)
{
    for (int i = 0; i < len; i++)
    {   
        arr[i] = new Random().Next(1, 10+1); // new — создает объект
    }
}

//1 
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N]; // все, что вводит пользователь, важно проверять на валидность!

//2
FillArray(array, N);

//3
int sum = 0;
float result = 0; // float, чтобы сохранить дробное значение 
int countOfEvens = 0; // доп переменная для подсчета количества четных чисел

for (int i = 0; i < N; i++) // перебор элементов, удовлетворяющих условию
{
    // 1 обратиться к четному
    if(array[i] % 2 == 0)
    {
        // 2 прибавить к сумме, "накопить"
        sum += array[i];
        // 3 вести подсчет четных элементов
        countOfEvens++; // even — четное, odd - нечетное
    }
}

result = (float)sum / countOfEvens; // без float он "округлит" значение, обрезав после запятой 
Console.WriteLine(result);

