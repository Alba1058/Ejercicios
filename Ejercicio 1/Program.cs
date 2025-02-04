using System;

class Math
{
    static void Main()
    {
        float a, b, c, x;
        Console.WriteLine("Ingrese el valor de a:");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de b:");
        b = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de c:");
        c = float.Parse(Console.ReadLine());
        x = (a + (b / c)) / ((a / b) + c);
        Console.WriteLine($"X es igual a: {x}");
        Console.ReadLine();
    }

}


   


