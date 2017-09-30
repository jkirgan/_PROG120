using System;
using VendingMachine;

namespace PROG120_Kirgan_Joe_HW2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Machine machine1 = new Machine();

            string uiCommand;

            Console.WriteLine();
            Console.WriteLine("Welcome to a virtual coke machine please choose from the following;");
            Console.WriteLine();
            Console.WriteLine("P to enter a dollar.");
            Console.WriteLine("B to buy a coke.");
            Console.WriteLine("R to get a refund of remaining funds");
            Console.WriteLine("Q to quit the virtual coke machine");
            Console.Write("Your choice:");
            uiCommand = Console.ReadLine();
            uiCommand = uiCommand.ToUpper();
            
            while (uiCommand !="Q")
            {
                switch (uiCommand)
                {
                    default:
                       Console.WriteLine();
                       Console.WriteLine("Invalid please try again");
                       break;
                    case "P":
                        Console.WriteLine();
                        machine1.AcceptCash();
                        Console.WriteLine("Thank you your new balance is ${0}", machine1.PubBalance);
                        break;
                    case "B":
                        
                        machine1.BuyCoke();
                        int rtrnValue = machine1.BuyCoke();
                        Console.WriteLine("{0}",rtrnValue);
                        if (rtrnValue == 1)// please see notes on class
                        {
                            Console.WriteLine("Enjoy your coke! Your remaining balance is {0}",machine1.PubBalance);
                        }
                        
                        else if (rtrnValue == 2)
                        {
                            Console.WriteLine("Please add money to buy a coke");
                        }
                        else if (rtrnValue ==3)// as below 
                        {
                            Console.WriteLine("There arent any cokes left and you have no money in the machine please come back after we've restocked");
                        }
                        else if (rtrnValue ==4)// will tell us there are no more cokes left if we just bought the last one
                        {
                            Console.WriteLine("There are no more cokes hit R for a refund of any remaining funds on the next screen then come back after we've restocked");
                        }
                        
                        Console.WriteLine();
                        break;
                        case "R":
                        Console.WriteLine();
                        Console.WriteLine("You will be refunded ${0}",machine1.PubBalance);
                        machine1.GiveRefund();
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Welcome to a virtual coke machine please choose from the following;");
                Console.WriteLine();
                Console.WriteLine("P to enter a dollar.");
                Console.WriteLine("B to buy a coke.");
                Console.WriteLine("R to get a refund of remaining funds");
                Console.WriteLine("Q to quit the virtual coke machine");
                Console.Write("Your choice:");
                uiCommand = Console.ReadLine();
                uiCommand = uiCommand.ToUpper();
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using the virtual coke machine");
            Console.ReadLine();
        }
    }
}
