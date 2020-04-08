using System;

namespace Lab_4
{
    class Program
    {
        enum Days{ Sunday=1, Monday,Tuesday , Wednesday,Thursday ,Friday ,Satuerday };
        static void Main(string[] args)
        {
            int menuOption;
                
            do
            {
                Console.Clear();
                string menu = "\n\n\t Employees Shift Manager \n\n\t1 - Add New Worker \n\t2 - Assign Working Day \n\t3 - Print Employees By Day \n\t4 - Print Employee List\n\t5 - Exit";

                Console.WriteLine(menu);
                menuOption = int.Parse(Console.ReadLine());

                switch (menuOption)
                {
                    case 1:
                        {
                            // Add New Worker

                            break;
                        }

                    case 2:
                        {
                            // Assign Worker

                            break;
                        }

                    case 3:
                        {
                            // Print Worker By Day

                            break;
                        }

                    case 4:
                        {

                            break;
                        }

                    case 5:
                        {
                            // Exit
                            Console.WriteLine("Bye-Bye!");

                            break;
                        }

                    default:
                        Console.WriteLine("Choose number according to the menu!");
                        Console.ReadLine();
                        break;
                }
            } while (menuOption != 5);
        }
    }
}
