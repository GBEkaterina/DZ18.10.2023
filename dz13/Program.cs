Console.WriteLine("Введите число");
string number1 = Console.ReadLine();
int number = Convert.ToInt32(number1);
if (number >= 100)
{
    string number2 = number1.ToString();
    char thirdDigit = number2[2];
    Console.WriteLine(thirdDigit);
}
else
{
     Console.WriteLine("третьего числа нет");
}