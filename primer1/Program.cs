Random generatenumber = new Rundom();
int number = generatenumber.Next(100,1000);
Console.WriteLine(number)
int numberA= number / 100;
Console.WriteLine(numberA);
int numberB= number % 10;
Console.WriteLine(numberB);
Console.WriteLine(numberA.Tostring() + numberB.Tostring()); //Console.WriteLine($"{b}" + $"{a}");
