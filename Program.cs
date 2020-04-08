using System;

namespace Lab_4
{
    class Program
    {
        enum Days{ Sunday=1, Monday,Tuesday , Wednesday,Thursday ,Friday ,Satuerday };
        static void Main(string[] args)
        {
            int menuOption, arrSize = 10, idxArr = 0;

            Employees [] arr = new Employees[arrSize];
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
                            Console.Write("Name:");
                            string name = Console.ReadLine();
                            Console.Write("Age:");
                            int age = int.Parse(Console.ReadLine());
                            Console.Write("ID:");
                            int id = int.Parse(Console.ReadLine());
                            arr[idxArr] = new Employees(name, age, id);
                            idxArr++;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Insert the name of worker:");
                            string tempName = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Insert the day (1-7)");
                                tempDay = int.Parse(Console.ReadLine());
                            }while(tempDay<1 && tempDay>7)
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
