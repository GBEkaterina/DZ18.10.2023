Console.WriteLine("Введите первое число");
string number1_str = Console.ReadLine();
int number1 = Convert.ToInt32(number1_str);
Console.WriteLine("Введите второе число");
string number2_str = Console.ReadLine();
int number2 = Convert.ToInt32(number2_str);
Console.WriteLine("Введите третье число");
string number3_str = Console.ReadLine();
int number3 = Convert.ToInt32(number3_str);
int count=0;
while (count < 3)
{
    if (number1 > number2 && number1 > number3)
    {
    Console.Write("max = " + number1);
    count++;
    break;
    }
    if (number1 < number2 && number3 < number2)
    {
    Console.Write("max=" + number2);
    count++;
    break;
    }
    if (number1 < number3 && number2 < number3)
    {
    Console.Write("max=" + number3);
    count++;
    break;
    }
    else
    {   
    Console.WriteLine("числа равны");
    break;
    }
}