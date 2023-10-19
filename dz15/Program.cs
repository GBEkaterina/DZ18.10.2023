Console.WriteLine("Введите число дня недели");
string strnumber = Console.ReadLine();
int number = Convert.ToInt32(strnumber);
if(number >=1 && number <8)
    if (number < 6 && number >= 1)
    {   
        Console.Write("Нет");
    }
    else
    {
        Console.Write("Да");
    }
else
{
    Console.Write("Ошибка ввода данных");
}