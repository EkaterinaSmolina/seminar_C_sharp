﻿//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Console.WriteLine("input a: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("input b: ");
//int b = Convert.ToInt32(Console.ReadLine());
//int num_1=a;
//int num_2=b;

//if (num_1>num_2)
//    Console.WriteLine("a=" + num_1 + "; b=" + num_2 + "->" + "max= " + num_1);
//        else Console.WriteLine("a=" + num_1 + "; b=" + num_2 + "->" + "max= " + num_2);   



//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input c: ");
int c = Convert.ToInt32(Console.ReadLine());

 if (a > b && a > c)
 Console.WriteLine("a=" + a + "; b=" + b + "; с= "+ c + "->" + "max= " + a); 
        else if (b > c)
        Console.WriteLine("a=" + a + "; b=" + b + "; с= "+ c + "->" + "max= " + b); 
                else
                    Console.WriteLine("a=" + a + "; b=" + b + "; с= "+ c + "->" + "max= "+ c);
