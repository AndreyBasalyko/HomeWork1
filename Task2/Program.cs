Console.WriteLine("Введите первое число...");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число...");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число...");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
int MaxNumber = FirstNumber;
if(MaxNumber < SecondNumber)
{
    MaxNumber = SecondNumber;
}
if (MaxNumber < ThirdNumber)
{
    MaxNumber = ThirdNumber;
}
Console.WriteLine("Максимальное число");
Console.WriteLine(MaxNumber);