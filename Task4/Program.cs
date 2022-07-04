Console.WriteLine("Введите число.");
int Number = Convert.ToInt32(Console.ReadLine());
int H = 1;
while (Number > H)
{
     if (H % 2 == 0)
 {
    Console.Write(H);
    Console.Write(";");
    H++;
 }
 else
 {
    H++;
 }
}
if (Number % 2 == 0)
{
   Console.WriteLine(Number);
}