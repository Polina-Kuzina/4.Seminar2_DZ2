// 18. Дано число, обозначающее день недели. Выяснить, является ли номер дня недели выходным
Console.Write("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());
if(a <= 7)
{
    if(a > 5) Console.WriteLine("Этот день недели выходной");
    else Console.WriteLine("Этот день недели не выходной");
}  
else Console.WriteLine("Такого дня недели нет");
