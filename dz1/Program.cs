Console.WriteLine("Введите первое число");
string number1_str = Console.ReadLine();
int number1 = Convert.ToInt32(number1_str);
Console.WriteLine("Введите второе число");
string number2_str = Console.ReadLine();
int number2 = Convert.ToInt32(number2_str);
if (number1 > number2)
{
    Console.Write("max = " + number1);
}
if (number1 < number2)
{
    Console.Write("max=" + number2);
}
else
{
    Console.WriteLine("числа равны");
}