using System;

public class Program {
    static int sec()
    {
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 0; j <= 9; j++)
            {
                Console.WriteLine($"{i}{i}{j}");
            }
        }
        return 0;
    }
    static float third_path(int n)
    {
        float path = 0f;
        for (int i = 1; i <= n; i++)
        {
            path+=1/(float)i;
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
