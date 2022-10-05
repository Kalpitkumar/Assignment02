using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter rectangle Length");

            bool valueIsValid = false;
            int length = 0;

            while (valueIsValid == false)
            {

                string input = Console.ReadLine();
                if (int.TryParse(input, out length))
                {
                    if (length > 0)
                    {
                        valueIsValid = true;
                    }
                }
                else
                {
                    Console.WriteLine("invalid input. Please enter Length in number");
                }

            }

            Console.WriteLine("Please enter rectangle Width");

            valueIsValid = false;
            int width = 0;

            while (valueIsValid == false)
            {

                string input = Console.ReadLine();
                if (int.TryParse(input, out width))
                {
                    if (width > 0)
                    {
                        valueIsValid = true;
                    }
                }
                else
                {
                    Console.WriteLine("invalid input. Please enter Width in number");
                }

            }


            Rectangle rect = new Rectangle(length, width);
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("*** Enter your choice to perform following operation. *** \n1.Get Rectangle Length \n2.Change Rectangle Length\n3.Get Rectangle Width\n4.Change Rectangle Width\n5.Get Rectangle Perimeter\n6.Get Rectangle Area\n7.Exit");

                valueIsValid = false;
                int choice = 0;

                while (valueIsValid == false)
                {

                    string input = Console.ReadLine();
                    if (int.TryParse(input, out choice))
                    {
                        if (choice > 0)
                        {
                            valueIsValid = true;
                            // exit = true;

                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine($"The Rectangle length is {rect.GetCurrentLength()} \n\n");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter length to chnage rectangle length");
                                    bool lenIsValid = false;
                                    int len = 0;

                                    while (lenIsValid == false)
                                    {

                                        string newLength = Console.ReadLine();
                                        if (int.TryParse(newLength, out length))
                                        {
                                            if (length > 0)
                                            {
                                                lenIsValid = true;
                                                Console.WriteLine($"new rectangle length is {rect.SetNewLength(length)} \n\n");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("invalid input. Please enter length in number \n\n");
                                        }

                                    }
                                    break;
                                case 3:
                                    Console.WriteLine($"The Rectangle width is {rect.GetCurrentWidth()} \n\n");
                                    break;
                                case 4:
                                    Console.WriteLine("Enter width to chnage rectangle length");
                                    bool widIsValid = false;
                                    int wid = 0;

                                    while (widIsValid == false)
                                    {

                                        string newLength = Console.ReadLine();
                                        if (int.TryParse(newLength, out length))
                                        {
                                            if (length > 0)
                                            {
                                                widIsValid = true;
                                                Console.WriteLine($"new rectangle width is {rect.SetNewWidth(length)} \n\n");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("invalid input. Please enter Width in number \n\n");
                                        }

                                    }
                                    break;
                                case 5:
                                    Console.WriteLine($"The rectangle Perimeter is {rect.GetPerimeter()} \n\n");
                                    break;
                                case 6:
                                    Console.WriteLine($"The rectangle Area is {rect.GetArea()} \n\n");
                                    break;
                                case 7:
                                    Console.WriteLine("Thank you!");
                                    break;
                                default:
                                    Console.WriteLine("Please enter valid choice and try again \n\n");
                                    break;

                            }


                        }
                    }
                    else
                    {
                        Console.WriteLine("invalid input. Please enter valid selection");
                    }

                }

            }




        }
    }
}
