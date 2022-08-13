// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.


double ThirdNumber(double arg1, double arg2) 
{
    while(arg1>=100)
    {
        arg2 = arg1 % 10;
        arg1=(arg1-arg2)/10;
    }
    return arg2;
}

Console.WriteLine(" Угодаю третью цифру вашего числа. Введите число");
double num1 = Convert.ToInt32(Console.ReadLine());
double num2 = 0;
if (num1<100) Console.WriteLine("Третьей цифры не существует");
else
{
   double num3 = ThirdNumber(num1, num2);

    Console.WriteLine("Третья цифра из " + num1 + " is " + num3);
}