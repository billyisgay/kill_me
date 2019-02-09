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
            startup:
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

            customers:/// used for the goto statment to code jump so that we can allow smooth breaks during the customer greeting process. DONT @ ME
            bool idk = true;
            while (idk)
            {
                bool going = true;
                Console.Clear();
                Random customer_wait = new Random();
                int wait_time = customer_wait.Next(1000, 4000);
                System.Threading.Thread.Sleep(wait_time);

                while (going)
                {

                    Random nd1 = new Random();
                    int s1 = nd1.Next(1, 10);
                    string stock1 = s1.ToString();
                   
                    int s2 = nd1.Next(1, 10);
                    string stock2 = s2.ToString();
                    
                    int s3 = nd1.Next(1, 10);
                    string stock3 = s3.ToString();
                    
                    int s4 = nd1.Next(1, 10);
                    string stock4 = s4.ToString();
                  
                    int s5 = nd1.Next(1, 10);
                    string stock5 = s5.ToString();
                    
                    int s6 = nd1.Next(1, 10);
                    string stock6 = s5.ToString();

                    int p1 = 3;
                    string price1 = p1.ToString();
                    int p2 = 4;
                    string price2 = p2.ToString();
                    int p3 = 1;
                    string price3 = p3.ToString();
                    int p4 = 1;
                    string price4 = p4.ToString();
                    int p5 = 1;
                    string price5 = p5.ToString();
                    int p6 = 1;
                    string price6 = p6.ToString();
                    //wagwan this is where i am (billybear)
                    Console.WriteLine("hello pick sum food");

                   menu:
                    
                    string[] menu0 = new string[] { " " };
                    string[] menu1 = new string[] { "borgor [1]", " £", price1, " stock = ", stock1 };
                    string[] menu2 = new string[] { "cheese borgor [2]", " £", price2, " stock = ", stock2 };
                    string[] menu3 = new string[] { "chips [3]", " £", price3, " stock = ", stock3 };
                    string[] menu4 = new string[] { "lemonade [4]", " £", price4, " stock = ", stock4 };
                    string[] menu5 = new string[] { "coke [5]", " £", price5, " stock = ", stock5 };
                    string[] menu6 = new string[] { "fanta [6]", " £", price6, " stock = ", stock6 };
                    string[][] menuall = new string[][] { menu1, menu2, menu3, menu4, menu5, menu6 };
                    string[][] Order = new string[7][] { menu0, menu0, menu0, menu0, menu0, menu0, menu0, };

                    if (idk == false)
                    {
                        break;
                    }

                    foreach (string[] i in menuall)
                    {
                        foreach (string j in i)
                        {
                            Console.Write(j);
                        }
                        Console.WriteLine(" ");
                    }

                    Console.WriteLine("if you would like quit or if your finished enter [q]");

                    int kys = 0;
                    bool ded = true;
                    while (ded)
                    {
                        
                        string choice = Console.ReadLine();

                        foreach (char i in choice)
                        {
                            if (i == '1')
                            {
                                Order[1] = menu1;
                            }
                            if (i == '2')
                            {
                                Order[2] = menu2;
                            }
                            if (i == '3')
                            {
                                Order[3] = menu3;
                            }
                            if (i == '4')
                            {
                                Order[4] = menu4;
                            }
                            if (i == '5')
                            {
                                Order[5] = menu5;
                            }
                            if (i == '6')
                            {
                                Order[6] = menu6;
                            }
                            if (i == 'q')
                            {
                                
                                
                                
                                Console.WriteLine("would you like to do");
                                Console.WriteLine("see the menu (1) or go back to start up(2)");
                                string answer = Console.ReadLine();
                                if (answer == "1")
                                {
                                    Console.Clear();
                                    goto menu;
                                }
                                else if (answer == "2") 
                                {
                                    Console.Clear();
                                    goto startup;
                                }
                                else
                                {
                                    Console.WriteLine("choose an option");
                                    

                                }


                            }
                            if (i == ' ')
                            {
                                kys = kys - 1;
                            }
                            else
                            {
                                kys = kys + 1;

                            }
                        }

                        if (ded == false)
                        {
                            break;
                        }

                        if (kys > 1)
                        {
                            Console.WriteLine("lisen Here u, type an order");
                        }

                        foreach (string[] i in Order)
                        {
                            foreach (string j in i)
                            {
                                if (j == " ")
                                {

                                }
                                else
                                {
                                    Console.Write(j);
                                }
                            }
                            Console.WriteLine(" ");
                        }
                        Console.WriteLine("is this everything? [y] ");
                        string die = Console.ReadLine();
                      
                        
                            if (die == "y")
                            {

                                ded = false;
                                break;
                            }
                            if (die == "n")
                            {
                                Console.Clear();
                                goto menu;
                            }
                            else
                            {
                                Console.Clear();
                                goto menu;
                            }

                        
                    }

                    bool money = true;
                    int total = 0;
                    while (money == true)
                    {
                           ////  PRICES DONT FULLY WORK NEED TO BE FIXED ON MONDAY!
                        foreach (string[] i in Order)
                        {
                            foreach (string j in i)
                            {
                                if (j == price1)
                                {
                                    total = total + p1;
                                    
                                }
                                if (j == price2)
                                {
                                    total = total + p2;
                                }
                                if (j == price3)
                                {
                                    total = total + p3;
                                }
                                if (j == price4)
                                {
                                    total = total + p4;
                                }
                                if (j == price5)
                                {
                                    total = total + p5;
                                }
                                if (j == price6)
                                {
                                    total = total + p6;
                                }

                            }

                        }
                        int pay1 = 0;
                        //string total1 = total.ToString();
                        Console.WriteLine($"this costs £{total}");

                        Console.WriteLine("please put the amount you will pay");
                        string pay = Console.ReadLine();
                        try
                        {

                            pay1 = pay1 + Int32.Parse(pay);
                        }
                        catch
                        {
                            Console.WriteLine("what u doing with your life");
                        }

                        if (pay1 >= total)
                        {
                            int change = pay1 - total;
                            int newFloat = Float - pay1;
                            Float = newFloat;
                            
                            Console.WriteLine("your new float is {0}", newFloat);
                            System.Threading.Thread.Sleep(1500);
                            string pay2 = change.ToString();
                            Console.Clear();
                            Console.WriteLine($"gives *order* with £{pay2}");
                            System.Threading.Thread.Sleep(500);
                            Console.Clear();
                            goto menu;

                        }
                        if (pay1 == total)
                        {
                            Console.Clear();
                            Console.WriteLine("*gives order*");
                            System.Threading.Thread.Sleep(1000);
                            goto exit;
                            
                        }
                        if (pay1 <= total)
                        {
                            Console.Clear();
                            Console.WriteLine("this is not enough kys , NO FOOD 4 U");
                            System.Threading.Thread.Sleep(1000);
                            goto exit;
                            
                        }
                        else
                        {
                            Console.Clear();
                            money = false;
                            ded = false;
                            idk = false;
                           
                            
                        }


                    }

                }
                if (idk == false)
                {
                    break;
                }

            close_down:
                {
                    Console.WriteLine("what would you like to do");
                    Console.WriteLine("check your final float (1)");
                    Console.WriteLine("close down the till");

                    string userinput2 = Console.ReadLine();
                    if (userinput2 == "1")
                    {
                        Console.WriteLine("your final float for the day is {0}", Float);
                        System.Threading.Thread.Sleep(1500);
                        goto close_down;
                    }
                    else if (userinput2 == "2")
                    {
                        Console.WriteLine("till is now closed");
                        goto close_down;
                    }
                    else if (userinput2 == "3")
                    {
                        goto exit;
                    }

                }
                exit:
                
                    Console.WriteLine("thank you for using the lemon shop application, to exit press 'E' to go to close down press 'c'");
                    string userinput = Console.ReadLine().ToUpper();
                    if (userinput == "C")
                    {
                        Console.WriteLine("close down code needed here");
                        goto close_down;
                    }
                    else if (userinput == "E") 
                    {
                        Console.WriteLine("thank you for playing");
                        System.Threading.Thread.Sleep(1500);
                        Environment.Exit(0);
                    }
            
            }

        }
    }
}



    