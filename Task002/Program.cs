Console.WriteLine("Type in first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in third number:");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
if (secondNumber > max)
{
    max = secondNumber;
}
else
{
    max = firstNumber;
}
if (thirdNumber > max)
{
    max = thirdNumber;
}
System.Console.WriteLine("max = " + max);