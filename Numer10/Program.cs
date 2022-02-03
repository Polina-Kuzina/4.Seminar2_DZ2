// 10. Показать вторую цифру трехзначного числа
Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая цифра числа: " + a / 10 % 10);

