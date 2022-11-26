// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

System.Console.WriteLine("Num");
var num = Convert.ToInt32(Console.ReadLine());

int GetLength(int num)
{
     for(int i=0;num%10!=0;i++)
     return i;
}