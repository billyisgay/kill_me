using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kill_me
{
   
    public class Exercise16
    {
        public static void Main()
        {
            string username, password;/// creates strings for username and password
            int ctr = 0;/// creates an integer set to 0 for counting how many attempts
            Console.Write("\n\nCheck username and password :\n");
            Console.Write("N.B. : Default user name and password is :abcd and 1234\n");
            Console.Write("------------------------------------------------------\n");

            do/// simple do statment to allow it to be recited until it reaches a certain number 
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username != "abcd" || password != "1234")
                    ctr++;
                else
                    ctr = 1;
                Console.WriteLine();
                    
                    
                
            }
            while ((username != "abcd" || password != "1234") && (ctr != 3));

            if (ctr == 3)/// if the user name and password is tried 3 times it will break out of the login system.
                Console.Write("\nLogin attemp three or more times. Try later!\n\n");
            else
                Console.Write("\nThe password entered successfully!\n\n");
            /// main page 
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
            bool startup = false;/// used for the while statment surronding the whole start up for the business
            int till_check = 0; /// integer for if the till is 0 or anything else used for a simple checking system and to make sure everything is done in the corret logical order.
            int float_check = 0; /// integer for if the till is 0 or anything else used for a simple checking system and to make sure everything is done in the corret logical order.
            Random rnd = new Random();/// used to allow a random number to be created
            int Float = rnd.Next(0, 101); /// used the before random function to create a random number between 1 and 100
            while (startup == false)/// start of the startup while loop 
            {
                /// simple menu to display all the options
                Console.WriteLine("what would u like to do");
                Console.WriteLine("press '1' to check the till");
                Console.WriteLine("press '2' to check the stock");
                Console.WriteLine("press '3' to start waiting for customers");
                string userinput = Console.ReadLine();/// string created for the users input (input can still be a number but will be taken as a string) ASLO MEANINGFUL VARIABLE NAME!!!

                if (userinput == "1")/// if user input is 1 
                {
                    Console.WriteLine("your till works");
                    till_check++;/// adds 1 to the int till_check to state that it has been checked
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    startup = false;
                    
                }
                
                
                else if (userinput == "2")/// if user input is 2 
                {
                    if (till_check > 0) /// checks if till , 0 if so then it has been checked and they can continue to check their float 
                    {
                        Console.WriteLine("float has been checked");
                        float_check++;/// adds 1 to the int float_check
                        Console.WriteLine("your float is now {0}", Float);
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        startup = false;

                    }
                    else if (till_check == 0)/// if the till_check int is 0 then they have not checked the till and will be instructed to do so.
                    {
                        Console.WriteLine("please check the till");
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();
                        startup = false;


                    }
                }
                else if (userinput == "3")/// if user input is 3 
                { 
                    if (till_check > 0)/// checks the till has been opened
                    {
                        
                        if(float_check > 0)/// then checks that the float has also been checked
                        {
                            System.Threading.Thread.Sleep(1500);
                            Console.Clear();

                            goto customers;/// jumps to the customers section of the code to allow easy transition
                            
                        }
                        else if(float_check == 0)/// if float_check is still 0 they will be instructed to go check it.
                        {
                            Console.WriteLine("please check your Float");
                            System.Threading.Thread.Sleep(1500);
                            Console.Clear();

                        }
                    }
                    else if (till_check == 0)/// if till_check is 0 then they will be instructed to go check the till before.
                    {

                        Console.WriteLine("please check the till");
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();
                    }

                }
                else /// else created in case user enters something that is not an option for safety.
                {
                    Console.WriteLine("please choose an option");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();

                }
                    
                
            }

        customers:/// used for the goto statment to code jump so that we can allow smooth breaks during the customer greeting process.
            {
                Console.WriteLine("working");
            }

           
           
        }
    }
}
