//Exersise1
Console.Write("введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
if (firstValue > secondValue)
{
    Console.WriteLine("максимальное число: " + firstValue + " минимальное число: " + secondValue);
  
}
else
{
  Console.WriteLine(" минимальное число: " + firstValue + ", максимальное число: " + secondValue);   
}
