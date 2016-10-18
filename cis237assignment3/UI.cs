/**
 * Kyle sherman
 * Assignment 3
 * DUE 10/18/2016
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UI
    {
        private DroidCollection droidCollection = new DroidCollection();

        public override string ToString()
        {
            return "Welcome to the EMPIRE DROID EMPORIUM";
        }

        public int GetUserInput()
        {
            this.PrintMainMenu();
            string userOptionString = Console.ReadLine();

            while(userOptionString != "1" && userOptionString != "2" && userOptionString != "3")
            {
                Console.Clear();
                Console.WriteLine("That is not a valid option.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

                Console.Clear();
                this.PrintMainMenu();
                userOptionString = Console.ReadLine();
            }
            try
            {
                return Int32.Parse(userOptionString);
            }
            catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine("Input cannot be empty and must be a number");
                Console.WriteLine("Please try again.");
                return 0;
            }
        }

        public void PrintMainMenu()
        {
            Console.WriteLine("EMPIRE DROID EMPORIUM");
            Console.WriteLine("1) CREATE A NEW DROID.");
            Console.WriteLine("2) VIEW ALL CURRENT DROIDS.");
            Console.WriteLine("3) EXIT.");
            Console.Write(Environment.NewLine + "What would you like to do? ");
        }

        public void mainMenu()
        {
            Console.Clear();

            int userChoice = GetUserInput();

            while (userChoice != 3)
            {
                if (userChoice == 1)
                {
                    Console.Clear();
                    modelOptions();
                    int model = Int32.Parse(Console.ReadLine());

                    materialOptions();
                    int material = Int32.Parse(Console.ReadLine());

                    colorOptions();
                    int color = Int32.Parse(Console.ReadLine());

                    if (model == 1)
                    {
                        addProtocol(setModel(model), setMaterial(material), setColor(color), droidCollection);
                    }
                    else if (model == 2)
                    {
                        addUtility(setModel(model), setMaterial(material), setColor(color), droidCollection);
                    }
                    else if (model == 3)
                    {
                        addJanitor(setModel(model), setMaterial(material), setColor(color), droidCollection);
                    }
                    else if (model == 4)
                    {
                        addAstromech(setModel(model), setMaterial(material), setColor(color), droidCollection);
                    }
                }
                if (userChoice == 2)
                {
                    Console.Clear();
                    outputDroidArray();
                }

                // redisplay the main menu when an if statement is done doing its work
                Console.WriteLine("Press any Key to continue.");
                Console.ReadKey(); // wait for the user to press a key
                Console.Clear();
                userChoice = GetUserInput(); // prompt the user to enter some input again
            }
        }

        public void modelOptions()
        {
            Console.Clear();
            Console.WriteLine("Select a Model: ");
            Console.WriteLine("1) protocol  - $100");
            Console.WriteLine("2) utility   - $250");
            Console.WriteLine("3) janitor   - $150");
            Console.WriteLine("4) astromech - $325");
        }

        public void materialOptions()
        {
            Console.Clear();
            Console.WriteLine("Select a Material: ");
            Console.WriteLine("1) cerillium - $200");
            Console.WriteLine("2) Polyfibe  - $150");
            Console.WriteLine("3) Tekonite  - $100");
        }

        public void colorOptions()
        {
            Console.Clear();
            Console.WriteLine("Select a color: ");
            Console.WriteLine("1) red    - $200");
            Console.WriteLine("2) gold   - $500");
            Console.WriteLine("3) orange - $150");
        }

        public string setModel(int model)
        {
            switch(model)
            {
                case 1:
                    return "protocol";
                    break;
                case 2:
                    return "utility";
                    break;
                case 3:
                    return "janitor";
                    break;
                case 4:
                    return "astromech";
                    break;
                default:
                    return "";
                    break;
            }
            
        }

        public string setMaterial(int material)
        {
            switch (material)
            {
                case 1:
                    return "cerillium";
                    break;
                case 2:
                    return "Polyfibe";
                    break;
                case 3:
                    return "Tekonite";
                    break;
                default:
                    return "";
                    break;
            }
        }

        public string setColor(int color)
        {
            switch (color)
            {
                case 1:
                    return "red";
                    break;
                case 2:
                    return "gold";
                    break;
                case 3:
                    return "orange";
                    break;
                default:
                    return "";
                    break;
            }
        }

        public static void addProtocol(string model, string material, string color, DroidCollection droidCollection)
        {

            Console.Clear();
            Console.WriteLine("Language feature: $300 per language");
            Console.WriteLine("How many languages should the droid know? ");
            int numberOfLanguages = Int32.Parse(Console.ReadLine());

            droidCollection.addDroid(model, material, color, numberOfLanguages);
        }


        public static void addUtility(string model, string material, string color, DroidCollection droidCollection)
        {
            bool toolbox = false;
            bool computerConnection = false;
            bool arm = true;

            Console.Clear();
            Console.WriteLine("toolbox feature: $100");
            Console.WriteLine("Would you like a toolbox? 1 = yes; 2 = no");
            int toolboxInt = Int32.Parse(Console.ReadLine());
            if (toolboxInt == 1)
                toolbox = true;

            Console.WriteLine(Environment.NewLine + "Computer connection feature: $100");
            Console.WriteLine("Would you like a Computer Connection? 1 = yes; 2 = no");
            int computerConnectionInt = Int32.Parse(Console.ReadLine());
            if (computerConnectionInt == 1)
                computerConnection = true;

            Console.WriteLine(Environment.NewLine + "Arm feature: $100");
            Console.WriteLine("Would you like an arm? 1 = yes; 2 = no");
            int armInt = Int32.Parse(Console.ReadLine());
            if (armInt == 1)
                arm = true;

            droidCollection.addDroid(model, material, color, toolbox, computerConnection, arm);
        }

        public static void addJanitor(string model, string material, string color, DroidCollection droidCollection)
        {
            bool toolbox = false;
            bool computerConnection = false;
            bool arm = true;
            bool trashCompactor = false;
            bool vacuum = false;

            Console.Clear();
            Console.WriteLine("toolbox feature: $100");
            Console.WriteLine("Would you like a toolbox? 1 = yes; 2 = no");
            int toolboxInt = Int32.Parse(Console.ReadLine());
            if (toolboxInt == 1)
                toolbox = true;

            Console.WriteLine(Environment.NewLine + "Computer connection feature: $100");
            Console.WriteLine("Would you like a Computer Connection? 1 = yes; 2 = no");
            int computerConnectionInt = Int32.Parse(Console.ReadLine());
            if (computerConnectionInt == 1)
                computerConnection = true;

            Console.WriteLine(Environment.NewLine + "Arm feature: $100");
            Console.WriteLine("Would you like an arm? 1 = yes; 2 = no");
            int armInt = Int32.Parse(Console.ReadLine());
            if (armInt == 1)
                arm = true;

            Console.WriteLine(Environment.NewLine + "trash Compactor feature: $100");
            Console.WriteLine("Would you like an trash Compactor? 1 = yes; 2 = no");
            int trashCompactorInt = Int32.Parse(Console.ReadLine());
            if (trashCompactorInt == 1)
                trashCompactor = true;

            Console.WriteLine(Environment.NewLine + "vacuum feature: $100");
            Console.WriteLine("Would you like an trash Compactor? 1 = yes; 2 = no");
            int vacuumInt = Int32.Parse(Console.ReadLine());
            if (vacuumInt == 1)
                vacuum = true;

            droidCollection.addDroid(model, material, color, toolbox, computerConnection, arm, trashCompactor, vacuum);
        }

        public static void addAstromech(string model, string material, string color, DroidCollection droidCollection)
        {
            bool toolbox = false;
            bool computerConnection = false;
            bool arm = true;
            bool fireExtinguisher = false;

            

            Console.Clear();
            Console.WriteLine("toolbox feature: $100");
            Console.WriteLine("Would you like a toolbox? 1 = yes; 2 = no");
            int toolboxInt = Int32.Parse(Console.ReadLine());
            if (toolboxInt == 1)
                toolbox = true;

            Console.WriteLine(Environment.NewLine + "Computer connection feature: $100");
            Console.WriteLine("Would you like a Computer Connection? 1 = yes; 2 = no");
            int computerConnectionInt = Int32.Parse(Console.ReadLine());
            if (computerConnectionInt == 1)
                computerConnection = true;

            Console.WriteLine(Environment.NewLine + "Arm feature: $100");
            Console.WriteLine("Would you like an arm? 1 = yes; 2 = no");
            int armInt = Int32.Parse(Console.ReadLine());
            if (armInt == 1)
                arm = true;

            Console.WriteLine(Environment.NewLine + "Arm feature: $100");
            Console.WriteLine("Would you like an arm? 1 = yes; 2 = no");
            int fireExtinguisherInt = Int32.Parse(Console.ReadLine());
            if (fireExtinguisherInt == 1)
                fireExtinguisher = true;

            Console.WriteLine(Environment.NewLine + "Ships feature: $300 per ship");
            Console.WriteLine("How many ships would you like? ");
            int numberOfShips = Int32.Parse(Console.ReadLine());

            droidCollection.addDroid(model, material, color, toolbox, computerConnection, arm, fireExtinguisher, numberOfShips);
        }


        public void outputDroidArray()
        {
            Console.WriteLine();
            // Get the output string from the droidCollection class's method:
            Console.WriteLine(droidCollection.outputDroidArray());
        }
    }
}
