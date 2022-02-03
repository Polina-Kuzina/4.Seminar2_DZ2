// 14. Найти третью цифру числа или сообщить, что ее нет
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
if(a / 100 >= 1)
{
    while(a / 1000 >= 1) a = a / 10;    
    Console.WriteLine("Третьей цифра числа " + a % 10);
}
else Console.WriteLine("В числе нет третьей цифры");
