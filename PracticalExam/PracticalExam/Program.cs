using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExam
{
    public class Program
    {

        static void Main(string[] args)
        {
            //  ID_CTF3001.txt JOSEPH SAUNDERSON STUDENT NUMBER 0707476

            /////////////////////////////////////////////SECTION 1-2/////////////////////////////////////////////
            // Vairables represented in double because accurate decimal numbers are required for input
            //ResponseContinue is represented as a string variable
            double Height = 0;
            double Length = 0;
            double width = 0;
            double RoomVolume = 0;
            string responseContinue = "";
            double estimate = 0;
            //The BTU is represented as 124, as 124 is what is multiplied by the room volume to obtain the BTU estimate
            double BTU = 124;
            double answer;

            while (true)
            {
                //Welcoming the user
                Console.WriteLine("Welcome User");
                //This is the purpose of the program
                Console.WriteLine("This program will calculate the BTU (British Thermal Units) required to heat a room");
                //Adds a pause for 5 seconds, added this to allow the user time to read what is being displayed
                System.Threading.Thread.Sleep(5000);
                //Giving the user an option to continue or exit
                Console.WriteLine("Would you like to continue or exit?. Please type Y or N");
                //Converting user input to uppercase
                responseContinue = Console.ReadLine().ToUpper();
                //Peramiter for if the user chooses to leave
                if (responseContinue == "N")
                {
                    //This forces the program to close if the user wishes to leave
                    Environment.Exit(1);
                    //This clears what was previosuly displayed, I used this to keep things tidy
                    Console.Clear();
                }
                //If the user chooses to continue, the following will happen, hence the else statement
                else
                {
                    ////////////////////////////////////////////////SECTION 3////////////////////////////////////////
                    //This is to provide the user input for lenght 
                    Console.WriteLine("Please enter the length of the room");
                    //this converts the user input into double
                    Length = Convert.ToDouble(Console.ReadLine());
                    //This is to provide the user input for height
                    Console.WriteLine("Please enter the height of the room");
                    //this converts the user input in double
                    Height = Convert.ToDouble(Console.ReadLine());
                    //This is to provide the user input for width
                    Console.WriteLine("Please enter the width of the room");
                    //This converts the user input into double
                    width = Convert.ToDouble(Console.ReadLine());

                    //These are the calcualtions for the rooms volume, Height x Length x width as stated by the exam paper
                    RoomVolume = ((Height * Length) * width);

                    //This outputs the volume of the room to the user
                    Console.WriteLine("The volume of the room is.. ");
                    //This displays the room volume
                    Console.WriteLine(RoomVolume);

                    //Calculation for the room BTU, Room Volume x 124 (BTU)
                    estimate = RoomVolume * BTU;
                    Console.WriteLine("This is the BTU estimate");
                    //This displays the BTU estimate

                    Console.Write(estimate);
                    Console.ReadKey();
                    Console.Clear();

                    ////////////////////////////////SECTION 4////////////////////////////////////
                }

                //Giving the user options for above the room 
                Console.WriteLine("What is above the room? \n1. Pitched uninsulated roof?\n2. Pitched insulated roof\n3. Heated room");
                //Sting vairable for multipul choice senario
                String choice = Console.ReadLine();
                //Vairables for the conditions above the room
                Double PUROOF = 1.30, PIROOF = 1.18, HEATROOM = 0.97;

                //if statement for example, if the user chooses option 1 then etc will be calculated
                if (choice == "1")
                {
                    //This will add 30% to the BTU estimate, I have done this by simply multiplying the BTU estimate by 1.30
                    answer = estimate * PUROOF;
                    Console.WriteLine(answer);
                    Console.WriteLine("This is the BTU estimate including a Pitched uninsulated roof");
                    //This coverts the answer into a string to output 2 decimal places
                    Console.WriteLine(answer.ToString("#.##"));
                }
                //if statement for the second option
                else if (choice == "2")
                {
                    //This will add 18% to the BTU estimate, Done by multiplying the estimate by 1.18
                    answer = estimate * PIROOF;
                    Console.WriteLine(answer);
                    Console.WriteLine("This si the BTU estimate including a Pitched insulated roof");
                    Console.WriteLine(answer.ToString("#.##"));
                }
                //if statement for third option
                else if (choice == "3")
                {
                    //This will subtract 3% from the BTU estimate, Done by multiplying the estimate by 0.97
                    answer = estimate * HEATROOM;
                    Console.WriteLine(answer);

                    Console.WriteLine("This is the BTU estimate including a Heated room");
                    Console.WriteLine(answer.ToString("#.##"));

                    Console.ReadKey();
                    Console.Clear();
                }


                //else if statement, if the user reponse does not equal 1, 2 or 3 they will be prompted to retry
                else if (choice != "1" || choice != "2" || choice != "3")
                {
                    //This will be displayed if the user enters anything other than 1,2 or 3

                    Console.WriteLine("Please enter a number that matches one of the above options");
                }

                //Giving the user options regarding external walls
                //  \n for example moves each option onto a new line to make navigation easier for the user
                Console.WriteLine("What is the number of external walls? \n1. Three or Four external walls?\n2. Two external walls?\n3. One or no external walls?");
                //Vairables for the conditions above the room
                Double THREEFOUR = 1.10, TWO = 1.05, ONENONE = 1.02;
                choice = Console.ReadLine();
                //If statement for option 1
                if (choice == "1")
                {
                    //Adding 10% to the BTU estimate, done by multiplying the estimate by 1.10
                    answer = estimate * THREEFOUR;
                    Console.WriteLine(answer);
                    Console.WriteLine("This is the BTU estimate including Three of Four external walls");
                    Console.WriteLine(answer.ToString("#.##"));
                }
                //else if statement for option 2
                else if (choice == "2")
                {
                    //Adding 5% to BTU estimate, done by multiplying the estimate by 1.05
                    answer = estimate * TWO;
                    Console.WriteLine(answer);
                    Console.WriteLine("This is the BTU estimate including Two external walls");
                    Console.WriteLine(answer.ToString("#.##"));
                }
                //else if statement for option 3
                else if (choice == "3")
                {
                    //Adding 2% to BTU estimate. done by multiplying the estimate by 1.02
                    answer = estimate * ONENONE;
                    Console.WriteLine(answer);
                    Console.WriteLine("This is the BTU estimate including One or no external walls");
                    Console.WriteLine(answer.ToString("#.##"));
                    Console.ReadKey();
                    Console.Clear();

                }
                //If the user does not enter either 1, 2 or 3, they will be asked to retry
                else if (choice != "1" || choice != "2" || choice != "3")
                {
                    Console.WriteLine("Please enter a number that matches one of the above options");
                }

                //Giving the user options regarding what is under the floor
                Console.WriteLine("What is Beneath the floor? \n1. Soil under wooden floor?\n2. Soil under concrete floor?\n3. Heated Room?");
                choice = Console.ReadLine();
                //Vairables for the conditions under the room
                Double SOIL = 1.10, SOILCON = 1.07, HEATFLOOR = 0.95;

                //If statemnt for choice 1
                if (choice == "1")
                {
                    //Adds 10% by mulitplying the estimate by 1.10
                    answer = estimate * SOIL;
                    Console.WriteLine(answer);
                    Console.WriteLine("This is the BTU estimate including Soil under wooden floor ");
                    Console.WriteLine(answer.ToString("#.##"));
                }
                //if statement for choice 2
                else if (choice == "2")
                {
                    //Adds 7% by multiplying the estimate by 1.07
                    answer = estimate * SOILCON;
                    Console.WriteLine(answer);
                    Console.WriteLine("This is the BTU estimate including Soil under concrete floor ");
                }
                //if statement for choice 3
                else if (choice == "3")
                {
                    //Subtracts 5% by multiplying the estimate by 0.95
                    answer = estimate * HEATFLOOR;
                    Console.WriteLine(answer);
                    Console.WriteLine("This is the BTU estimate including Heated Room under the floor");
                    Console.WriteLine(answer.ToString("#.##"));
                    Console.ReadKey();
                    Console.Clear();
                }
                //If the user does not enter either 1, 2 or 3, they will be asked to retry
                else if (choice != "1" || choice != "2" || choice != "3")
                {
                    Console.WriteLine("Please enter a number that matches one of the above options");
                }

                //Giving the user options regarding windows
                Console.WriteLine("What is the Window type? \n1. Single Glazed?\n2. Double Glazed?\n3. No Windows?");
                choice = Console.ReadLine();
                //Vairables for windows
                Double SNG = 1.15, DBL = 0.95, NONE = 0.90;

                //if statement for user choice 1
                if (choice == "1")
                {
                    //adding 15% to the estimate by multiplying it by 1.15
                    answer = estimate * SNG;
                    Console.WriteLine(answer);
                    Console.WriteLine("This is the BTU estimate including Single Glazed windows");
                    Console.WriteLine(answer.ToString("#.##"));
                }
                //if statement for user choice 2
                else if (choice == "2")
                {
                    //subtracting 5% from the estimate by multiplying it by 0.95
                    answer = estimate * DBL;
                    Console.WriteLine(answer);
                    Console.WriteLine("This is the BTU estimate including Double Glazed windows");
                    Console.WriteLine(answer.ToString("#.##"));

                }
                //if statement for user choice 3
                else if (choice == "3")
                {
                    //subtracting 10% from the estimate by multiplying it by 0.90
                    answer = estimate * NONE;
                    Console.Write(answer);
                    Console.WriteLine("This is the BTU estimate including No windows");
                    Console.WriteLine(answer.ToString("#.##"));
                    Console.ReadKey();
                    Console.Clear();
                }
                //If the user does not enter either 1, 2 or 3, they will be asked to retry
                else if (choice != "1" || choice != "2" || choice != "3")
                {
                    Console.WriteLine("Please enter a number that matches one of the above options");
                }

                //Giving the user options regarding outer walls
                Console.WriteLine("What is the External wall type? \n1. Solid Brick wall?\n2. Uninsulated Brick Cavity?\n3. Insulated Brick Cavity?");
                choice = Console.ReadLine();
                //Vairables for outer walls
                Double SBW = 1.12, UBC = 1.05, IBC = 0.98;

                //If statement for choice
                if (choice == "1")
                {
                    answer = estimate * SBW;
                    Console.WriteLine(answer);
                    Console.WriteLine("This is the BTU estimate including Solid Brick wall ");
                    Console.WriteLine(answer.ToString("#.##"));
                }
                //If statement for chocie 2
                else if (choice == "2")
                {
                    answer = estimate * UBC;
                    Console.WriteLine(answer);
                    Console.WriteLine("This is the BTU estiamate including Uninsualted Brick Cavity");
                    Console.WriteLine(answer.ToString("#.##"));

                }
                //If statement for choice 3
                else if (choice == "3")
                {
                    answer = estimate * IBC;
                    Console.WriteLine(answer);
                    Console.WriteLine("This is the BTU estimate including Insulated Brick cavity");
                    Console.WriteLine(answer.ToString("#.##"));
                    Console.ReadKey();
                    Console.Clear();
                }

                //If the user does not enter either 1, 2 or 3, they will be asked to retry
                else if (choice != "1" || choice != "2" || choice != "3")
                {
                    Console.WriteLine("Please enter a number that matches one of the above options");
                }

                /////////////////////////////SECTION 5-6////////////////////////////////

                {
                    //Giving the user a choice to quit or reuse the program
                    choice = Console.ReadLine();
                    Console.WriteLine("Would you like to continue? \n1. Y?\n2. N?");

                    //if the response is not Yes
                    if (responseContinue != "Y")
                    {
                        //forces the program to close
                        Environment.Exit(1);
                    }

                }



            }

        }
    }
}
    




