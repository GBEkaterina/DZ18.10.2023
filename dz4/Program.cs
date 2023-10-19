Console.WriteLine("Введите число");
string number1_str = Console.ReadLine();
int number = Convert.ToInt32(number1_str);
int i = 1;
while(i <= number)
{
    if (i % 2 == 0)
    {
        Console. WriteLine( i );
        i++;
    }
    i++;
}