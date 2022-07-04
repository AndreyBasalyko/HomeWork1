Console.WriteLine("Введите первое число...");
int FirstNumber = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе число...");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if(FirstNumber < SecondNumber)
{
    int maxNumber = SecondNumber;
    int minNumber = FirstNumber;
    Console.WriteLine("Большее число");
    Console.WriteLine(SecondNumber);
    Console.WriteLine("Меньшее число");
    Console.WriteLine(FirstNumber);
}
else
{
   Console.WriteLine("Большее число...");
   Console.WriteLine(FirstNumber);
   Console.WriteLine("Меньшее число...");
   Console.WriteLine(SecondNumber);
}

