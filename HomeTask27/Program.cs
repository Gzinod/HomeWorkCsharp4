// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

System.Console.WriteLine("Num");
var num = Convert.ToInt32(Console.ReadLine());
int [] array = new int [GetLength(num)];
System.Console.WriteLine(array.Length);
var count = GetLength(num);

int GetLength(int num)
{
    var i = 0;
     for( i=0;num!=0;i++)
    {
        num/=10;
    }
     return i;
}

if (count == 1)
{
    Console.WriteLine(num);
}
else
    {
        if (count == 2)
        {
            int num1 = num / 10;
            int num2 = num % 10;
            int summ = num1 + num2;
            System.Console.WriteLine(summ);
        }
         else
        {
            if(count == 3)
            {
                int num1 = num / 100;
                int num2 = num % 100 / 10;
                int num3 = num % 10;
                int summ = num1 + num2 + num3;
                System.Console.WriteLine(summ);
            }
            else
            {
                if(count == 4)
                {
                    int num1 = num / 1000;
                    int num2 = num % 1000 / 100;
                    int num3 = num % 100 / 10;
                    int num4 = num % 10;
                    int summ = num1 + num2 + num3 + num4;
                    System.Console.WriteLine(summ);
                }
                
            }
        }
    }

        
   
    
    
