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
FillArray(array, N); // функция, которая 
/*
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(1, 10+1); // new — создает объект
}
// имя, возвращаемое значение и параметры
*/

//3
int sum = 0;
float result = 0;
int countOfEvens = 0;

for (int i = 0; i < N; i++)
{
    // 1 обратиться к четному
    if(array[i] % 2 == 0)
    {
        // 2 прибавить к сумме 
        sum += array[i];
        // 3 вести подсчет четных элементов
        countOfEvens++;

    }
}

result = (float)sum / countOfEvens;
Console.WriteLine(result);

