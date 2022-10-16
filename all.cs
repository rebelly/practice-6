using System;

public class Program
{
    static void first()
    {
        Console.WriteLine("\t\t    Таблица Пифагора");
        Console.WriteLine("  |2\t3\t4\t5\t6\t7\t8\t9");
        Console.WriteLine("__|_______________________________________________________");
        for (int i = 2; i < 10; i++)
        {
            Console.Write($" {i}|");
            for (int j = 2; j <= 9; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }
        Console.ReadLine();

    }
    static void sec()
    {
        for (int i = 1; i <= 9; i++)
        {
            Console.WriteLine($"{i}00");
            for (int j = i+1; j <= 9; j++)
            {
                Console.WriteLine($"{i}{j}{i}");
                Console.WriteLine($"{i}{i}{j}");


            }
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($"{i}{i}{j}");
                Console.WriteLine($"{i}{j}{i}");

            } 
            Console.WriteLine($"{i}{i}{i}");

        }
    }
    static float third_path(int n)
    {
        float path = 0f;
        for (int i = 1; i <= n; i++)
        {
            path += 1 / (float)i;
        }
        return path;
    }
    static float third_dist(int n)
    {
        float dist = 0f;
        for (int i = 1; i <= n; i += 2)
        {
            dist += 1 / (float)i;

        }
        for (int i = 2; i <= n; i += 2)
        {
            dist -= 1 / (float)i;
        }
        return dist;
    }
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        float res_path = third_path(n);
        float res_dist = third_dist(n);
        Console.WriteLine($"{res_path} {res_dist}");
        sec();

    }
}
