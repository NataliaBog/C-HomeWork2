// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
double num1 = Convert.ToInt32(Console.ReadLine());
if(num1>99)
{
    if( num1<1000)
    {
        double num2 = ((num1-(num1 % 10))/10) % 10;
        Console.WriteLine("The second digit in " + num1 + " is " + num2);
    }
    else Console.WriteLine("Wrong number");
}
else Console.WriteLine("Wrong number");