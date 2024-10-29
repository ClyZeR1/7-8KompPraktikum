//Задание 1
//using System;

//class Program
//{
//    static void Main()
//    {
//        int count = 0;
//        while (count < 10)
//        {
//            Console.WriteLine("Привет");
//            count++;
//        }
//    }
//}
//Задание 2
//using System;

//class Program
//{
//    static void Main()
//    {
//        int number = 1;
//        int count = 0;
//        while (count < 10)
//        {
//            Console.WriteLine(number);
//            number++;
//            count++;
//        }
//    }
//}
//Задание 3
//using System;

//class Program
//{
//    static void Main()
//    {
//        int number = 5;
//        int count = 0;
//        while (count < 5)
//        {
//            Console.WriteLine(number);
//            number--;
//            count++;
//        }
//    }
//}
//Задание 4
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите значение n: ");
//        int n = int.Parse(Console.ReadLine());
//        int number = 1;
//        while (number <= n)
//        {
//            Console.WriteLine(number);
//            number++;
//        }
//    }
//}
//Задание 5
//using System;

//class Program
//{
//    static void Main()
//    {
//        string[] words = new string[5];
//        for (int i = 0; i < 5; i++)
//        {
//            Console.Write($"Введите слово {i + 1}: ");
//            words[i] = Console.ReadLine();
//        }

//        int count = 0;
//        while (count < 5)
//        {
//            if (count % 2 == 0)
//            {
//                Console.Write(words[count] + "   " + words[count]);
//            }
//            else
//            {
//                Console.Write(words[count] + "   " + words[count] + "   " + words[count]);
//            }
//            count++;
//        }
//    }
//}
//8Комп Практикум Задание 1
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] omas = new int[8];

//        for (int i = 0; i < 8; i++)
//        {
//            Console.Write($"omas[{i}] = ");
//            omas[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Введенные числа:");
//        for (int i = 0; i < 8; i++)
//        {
//            Console.WriteLine($"omas[{i}] = {omas[i]}");
//        }
//    }
//}
//Задание 2
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] omas = new int[] { 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3 };

//        Console.WriteLine("Элементы массива:");
//        for (int i = 0; i < omas.Length; i++)
//        {
//            Console.WriteLine($"omas[{i}] = {omas[i]}");
//        }
//    }
//}
//Задание 3
//using System;

//class Program
//{
//    static void Main()
//    {
//        Random random = new Random();
//        int[] omas = new int[12];

//        for (int i = 0; i < 12; i++)
//        {
//            omas[i] = random.Next(163, 191);
//        }

//        Console.WriteLine("Росты людей:");
//        for (int i = 0; i < omas.Length; i++)
//        {
//            Console.WriteLine($"omas[{i}] = {omas[i]}");
//        }
//    }
//}
//while