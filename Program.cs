﻿System.Console.WriteLine("numA");
var numA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("numB");
var numB = Convert.ToInt32(Console.ReadLine());

int GetNum(int numA,int numB) 
{
    var result =1;
    var i = 1;
    while(i<=numB)
    {
        result = result*numA;
        i++;
    }
    return result;
}

System.Console.WriteLine(GetNum(numA,numB));

// int GetNum(int numA,int numB) 
// {
//     var result = (Math.Pow(numA,numB));
//     return result;
// }   
