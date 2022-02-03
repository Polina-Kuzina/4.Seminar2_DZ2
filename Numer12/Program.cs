// 12. Удалить вторую цифру трехзначного числа
Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int a3 = a % 10;
int a1 = a / 100;
Console.WriteLine("Число без второй цифры: " + a1 + a3);
