using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ShutdownerV2_CS
{
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Shutdowner V2 by Ali Diaa";
            Console.WriteLine("Shutdown [S], Restart [R]");
            try
            {
                char input = char.Parse(Console.ReadLine());
                if (input == 'S' || input == 's')
                {
                    Console.WriteLine("No time [0], time in seconds [integer value]");
                    int input2 = int.Parse(Console.ReadLine());
                    try
                    {
                        if (input2 == 0)
                        {
                            Process.Start("shutdown", "/s /t 0");
                        }
                        else
                        {
                            Process.Start("shutdown", "/r /t " + input2);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("You entered an invalid numberical value!" + Environment.NewLine + "Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                    }
                }
                else if (input == 'R' || input == 'r')
                {
                    Console.WriteLine("No time [0], time in seconds [integer value]");
                    int input3 = int.Parse(Console.ReadLine());
                    try
                    {
                        if (input3 == 0)
                        {
                            Process.Start("shutdown", "/r /t 0");
                        }
                        else
                        {
                            Process.Start("shutdown", "/r /t " + input3);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("You entered an invalid numberical value!" + Environment.NewLine + "Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                    }
                }
                else
                {
                    MessageBox.Show("You entered an invalid value!" + Environment.NewLine + "Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You entered an invalid value!" + Environment.NewLine + "Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}