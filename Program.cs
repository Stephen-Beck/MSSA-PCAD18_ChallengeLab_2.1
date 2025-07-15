/*
Write a C# Sharp program to read temperature in Fahrenheit and display a suitable message according to temperature state below :
    Temp 0< 10 then Freezing weather
    Temp 11-20 then Very Cold weather
    Temp 21-35 then Cold weather
    Temp 36-50 then Normal in Weather
    Temp 51-65 then Its Hot
    Temp 66-80 then Its Very Hot

Test Data :
    67
Expected Output :
    Its very hot.
*/

using System.Security.Cryptography;

namespace ChallengeLab_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                bool validEntry = false;
                Console.Clear();

                Console.Write("Please enter a temperature value in Fahrenheit: ");

                while (!validEntry)
                {
                    float userTemperature;

                    if (Single.TryParse(Console.ReadLine(), out userTemperature))
                    {
                        switch (userTemperature)
                        {
                            case < 0:
                                Console.WriteLine("Layer up! It's sub-zero temperature outside!!");
                                break;
                            case >= 0 and <= 10:
                                Console.WriteLine("Freezing weather!");
                                break;
                            case > 10 and <= 20:
                                Console.WriteLine("Very cold weather!");
                                break;
                            case > 20 and <= 35:
                                Console.WriteLine("Cold weather.");
                                break;
                            case > 35 and <= 50:
                                Console.WriteLine("Normal weather.");
                                break;
                            case > 50 and <= 65:
                                Console.WriteLine("Hot weather.");
                                break;
                            case > 65 and <= 80:
                                Console.WriteLine("Very hot weather!");
                                break;
                            case > 80:
                                Console.WriteLine("OH LAWD IT SCORCHIN' OUTSIDE!!");
                                break;
                            default:
                                Console.WriteLine("Something went wrong. This message should never be triggered!");
                                break;
                        }
                        validEntry = true;
                    }
                    else
                    {
                        Console.Write("Invalid entry. Please enter a valid temperature value in Fahrenheit: ");
                    }
                }

                Console.WriteLine("\nPress 'Esc' key to exit or any other key to enter another temperature value.");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    exit = true;
                }
            }
        }
    }
}
