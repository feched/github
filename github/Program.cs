
int x;
Console.WriteLine("Введите число х");
x = Convert.ToInt32(Console.ReadLine());
// решение задачи
Console.WriteLine($"y={((5 * x) * 2) + 20}");

//возведение в степень
Console.WriteLine(Math.Pow(x, 2));

//возведение в корень
Console.WriteLine(Math.Sqrt(x));

// логарифм
Console.WriteLine(Math.Log10(x));
