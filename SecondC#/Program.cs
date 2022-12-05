 /* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. */

/*
int a = 0;
int b = 0;
    
{    
    Console.WriteLine("Введите ваше число: ", a);
        a = Convert.ToInt32(Console.ReadLine());
    
    
    int sot = a / 10;
    int ed = a / 100;  
    b = sot - (ed*10);
        Console.WriteLine(b);                                                            
}
*/




 /* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. */

/*
int a = 0;
int b = 0;

    Console.WriteLine("Введите число: ");
        a = Convert.ToInt32(Console.ReadLine());

if (a > 99 && a < 1000)
{
    b = a % 10;
    Console.WriteLine("Третья цифра - {0} ",b);
}
else if (a < 100 && a > 0)
{
    Console.WriteLine("Нет третьего числа ");
}
else 
{
    do
    {
        a = a / 10;
        b = a;
    } while (b > 1000 );
    b = b % 10;
    Console.WriteLine("Третья цифра - {0}",b);
} 
*/




 /* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. */

/*
 int a = 0;
    Console.WriteLine("Введите число: ");
    a = Convert.ToInt32(Console.ReadLine());

if (a > 0 && a < 6)
{
    Console.WriteLine("Не выходной");
}
else if (a == 6 || a == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Неверный ввод данных");
}
*/