// ввести точки 
// использовать формулу нахождения расстояния между двумя точками в пространстве 
// корень суммы квадратов разностей 

Console.WriteLine("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Координаты первой точки: {x1}, {y1}, {z1}");
Console.WriteLine($"Координаты второй точки: {x2}, {y2}, {z2}");
Console.WriteLine();

double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
Console.WriteLine($"Расстояние между заданными точками равняется: {result}");
