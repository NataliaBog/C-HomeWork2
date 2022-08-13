// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

string[] Days = {"Mondey", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        for (int i=0; i<Days.Length-1; i++)
        {
            Console.Write(i+1 + "-" + Days[i] + ", ");
        }
    Console.WriteLine(Days.Length + "-" + Days[Days.Length-1] + ", ");
    Console.WriteLine("Выберите день");
    int numberDay = Convert.ToInt32(Console.ReadLine());
    if (numberDay>0)
    {
        if (numberDay<8)
        {
            if(numberDay >5) Console.WriteLine("Ура! это выходной день!");
            else Console.WriteLine("Этот день является будним. ");
        }
        else Console.WriteLine("Нет номера дня " + numberDay);
    }
    else Console.WriteLine ("Нет номера дня" + numberDay);