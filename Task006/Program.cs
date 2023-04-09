// 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine ("ВВедите два числа ");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0)
number = -number;
if ( number%2 == 1)
{ 
    Console.WriteLine("нечетное");
}
else
{
    Console.WriteLine("четное");
}