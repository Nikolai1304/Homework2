// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("____TASK 10_____ ");
Console.WriteLine("Ведите любое трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
num1 = num%100;
num1 = num1/10;
if (num<100 || num>999)
{
  Console.WriteLine("Поробуйте еще раз");
}
else 
{
  Console.WriteLine(num1);
}

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("____TASK 13_____ ");
Console.WriteLine("Ведите любое число");
int res = Convert.ToInt32(Console.ReadLine());
while (res>999)
{
 res = res / 10;
}
if (res<1000 && res>99)
{
  res = res%10;
  Console.WriteLine(res);
}
else
{
  Console.WriteLine("Данное число не удовлетворяет условию задачи");
  Console.WriteLine("Повторите ввод");
}


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("____TASK 15_____ ");
Console.WriteLine("Ведите любое число, соответствующее дню недели");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
case 6: Console.WriteLine("Выходной - Суббота");break;
case 7: Console.WriteLine("Выходной - Воскресенье");break;
default: Console.WriteLine("Не выходной"); break;
}
