// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int SecondNum (int num)
{
    int result=(num % 100)/10;
    return result;
}

Console.Write("Input three-digit number: ");
int num=Convert.ToInt32(Console.ReadLine());
int result=SecondNum(num);
Console.WriteLine(result);
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int ThirdNum (int num)

{
    if(num<100) return ("третьей цыфры нет");
    if(num
    int result=(num % 100)/10;
    return result;
}

Console.Write("Input number: ");
int num=Convert.ToInt32(Console.ReadLine());
int result=ThirdNum(num);
Console.WriteLine(result);


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли он выходным.
/*
string Weekday (int num) 
{
    if
        (num<1 || num>7) Console.Write  ("Такого дня недели пока-что не существует");
    else
        (num==1) Console.Write("Понедельник");
        (num==2) Console.Write("Вторник");
        (num==3) Console.Write  ("Среда");
        (num==4) Console.Write  ("Четверг");
        (num==5) Console.Write  ("Пятница");
        (num==6) Console.Write  ("Суббота! Ура выходной!");
        (num==7) Console.Write  ("Воскресенье! Ура выходной!");

}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

/*
bool Weekday (int num) 
{
  if(num==1 || num==2 || num==3 || num==4 || num==5) return false;
  if(num==6 || num==7) return true;
}
Console.Write("Input number: ");
int num=Convert.ToInt32(Console.ReadLine());
bool result=Weekday(num);
Console.Write(result); */