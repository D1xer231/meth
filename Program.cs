using System;
using System.Threading.Tasks;

namespace Hisenberg;

class Program
{
    public static async Task Main()
    {
        Console.Clear();
        Walt.WaltIMG();
        await Task.Delay(3000); // hisenberg image appers for 3 sec and disappers
        Console.Clear();

        Walt.MethCalcTxt();

        System.Console.Write("Enter YOUR name: ");
        string? name = Console.ReadLine();

        System.Console.Write("Enter YOUR age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 18 || age <= 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("Age Error, YOU must be more than 18");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine($"Hi, {name}. YOUR age ({age}) passed the check!");
            Console.ResetColor();
        }

        await Task.Delay(3000);

        




    }
}