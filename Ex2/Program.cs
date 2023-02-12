// Exercise2
Console.Write("введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число: ");
int thirdValue = Convert.ToInt32(Console.ReadLine());
if ((firstValue > secondValue) && (firstValue > thirdValue))
{
    Console.WriteLine(" максимальное число: " + firstValue);
}
else
{
   if (secondValue > thirdValue)
   {
    Console.WriteLine(" максимальное число: " + secondValue);
   }
   else
   {
    Console.WriteLine(" максимальное число: " + thirdValue);
   }
}
