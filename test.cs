using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        string line = Console.ReadLine();

        string b = "";
        string c = "";

        bool foundSpace = false;

        for (int i = 0; i < line.Length; i++)
        {
            char x = line[i];

            if (x == ' ')
            {
                foundSpace = true;
            }
            else
            {
                if (!foundSpace)
                {
                    b += x;
                }
                else
                {
                    c += x;
                }
            }
        }

        int B = int.Parse(b);
        int C = int.Parse(c);

        int result = a + B - C;

        Console.WriteLine(result);
    }
}