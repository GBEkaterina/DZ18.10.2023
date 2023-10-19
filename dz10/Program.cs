Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number >=100 && number < 1000)
{
    int Lastnumber = number % 100;
    int secondnum = Lastnumber / 10;
    Console. WriteLine(secondnum);
}
else
{
    Console.WriteLine("Введите число меньше 1000");
}