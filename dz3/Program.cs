Console.WriteLine("Введите число");
string number1_str = Console.ReadLine();
int number = Convert.ToInt32(number1_str);
int a = number % 2;
if (a == 0)
{
Console.Write("число " + number + " четное");
}
else
{   
     Console.WriteLine("число " + number + " нечетное");
}