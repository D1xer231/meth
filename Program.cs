using System;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Serialization;
using System.IO;
using System.Collections;

namespace Hisenberg;

class Program
{
    public static async Task Main()
    {
        DateTime now = DateTime.Now;
        System.Console.WriteLine(now.ToString("g"));
        await Task.Delay(2000);
        Console.Clear();
        System.Console.WriteLine("Yo yo yo.");
        await Task.Delay(2000);
        System.Console.WriteLine("148-3 to the 3, ");
        await Task.Delay(2000);
        System.Console.WriteLine("6 to the 9, ");
        await Task.Delay(2000);
        System.Console.WriteLine("representing the ABQ, what up, biatch?!");
        await Task.Delay(2000);


        Console.Clear();
        Walt.WaltIMG();
        await Task.Delay(3000);
        Console.Clear();

        Walt.MethCalcTxt();

        Console.ResetColor();
        System.Console.Write("Enter YOUR name: ");
        string? name = Console.ReadLine();

        System.Console.Write("Enter YOUR age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 18 || age <= 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("Age Error, YOU must be more than 18");
            System.Console.WriteLine("Be careful!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine($"Hi, {name}. YOUR age ({age}) passed the check!");
            Console.ResetColor();
        }

        await Task.Delay(3000);
        Console.Clear();
        Walt.MethCalcTxt();

        System.Console.WriteLine("Choose the next two options: ");
        await Task.Delay(3000);

        System.Console.WriteLine("price per gramm[1]   or  total earnings[2]");
        string? key = Console.ReadLine();
        Console.Clear();
        Walt.MethCalcTxt();
        if (key == "1")
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.Write("How much do YOU want to earn $: ");
            int price1 = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("How much product: ");
            int quant1 = Convert.ToInt32(Console.ReadLine());

            int res1 = price1 / quant1;

            Walt.MethCalcTxt();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine($"Price per gramm of your product is $: {res1}.");
            Console.ResetColor();
        }
        if (key == "2")
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.Write("How much product YOU have: ");
            int price2 = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Price per gramm $: ");
            int quant2 = Convert.ToInt32(Console.ReadLine());

            int res2 = price2 * quant2;

            Console.Clear();
            Walt.MethCalcTxt();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine($"Total price is $: {res2}.");
            Console.ResetColor();
            if (res2 >= 1000)
            {
                for (int i = 0; i < 5; i++)
                {
                    await Task.Delay(500);
                    System.Console.WriteLine("WOW!!!");
                }
                await Task.Delay(3000);
                Console.Clear();

                Walt.MethCalcTxt();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine("BETTER CALL SOUL!!!");
                Console.ResetColor();
                await Task.Delay(500);
                // Process.Start("shutdown", "/s /t 0");
            }
        }


        Input user = new Input(name, age);
        XmlSerializer xml = new XmlSerializer(typeof(Input[]));
        await Task.Delay(300);
        using (FileStream file = new FileStream(name + "_order.xml", FileMode.OpenOrCreate))
        {
            Input[] users = new Input[] { user };
            xml.Serialize(file, users);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            System.Console.WriteLine("Well, Well");
            System.Console.WriteLine("YOUR order saved on your pc!");
            Console.ResetColor();
        }

        using (FileStream file = new FileStream(name + "_order.xml", FileMode.OpenOrCreate))
        {
            Input[] newuser = xml.Deserialize(file) as Input[] ?? new Input[0];

            foreach (var el in newuser)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine($"NAME: {el.name}\nAGE: {el.age}");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                System.Console.WriteLine("don't worry, that's not all");
                Console.ResetColor();
            }
                
        }
    }
}