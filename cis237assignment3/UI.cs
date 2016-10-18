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

// UI class.
// holds all methods for the user interface
namespace cis237assignment3
{
    class UI
    {
        // instantiates the droid collection class
        private DroidCollection droidCollection = new DroidCollection();

        // used for testing
        public override string ToString()
        {
            return "Welcome to the EMPIRE DROID EMPORIUM";
        }

        // gets the user input and returns it as an integer
        public int GetUserInput()
        {
            this.PrintMainMenu(); // calls the print main menu method
            string userOptionString = Console.ReadLine(); // stores the user input as a string

            // checks to see if the input is within the defined constraints
            while(userOptionString != "1" && userOptionString != "2" && userOptionString != "3")
            {
                // if it is not within the constraints then 
                // let the user no and promt them for input again
                Console.Clear();
                Console.WriteLine("That is not a valid option.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

                Console.Clear();
                this.PrintMainMenu();
                userOptionString = Console.ReadLine();
            }
            // try catch throws any errors if incorrect input is 
            // entered by the user; user must enter an integer
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

        // print main menu method
        // displays the main menu
        public void PrintMainMenu()
        {
            Console.WriteLine("EMPIRE DROID EMPORIUM");
            Console.WriteLine("1) CREATE A NEW DROID.");
            Console.WriteLine("2) VIEW ALL CURRENT DROIDS.");
            Console.WriteLine("3) EXIT.");
            Console.Write(Environment.NewLine + "What would you like to do? ");
        }

        // main menu method
        // logic for what to do based on user input
        public void mainMenu()
        {
            Console.Clear();

            // store the users input as an integer
            int userChoice = GetUserInput();

            while (userChoice != 3) // check to see if the user has entered the exit code
            {
                if (userChoice == 1) // checks to see if the user entered a 1: add a new droid
                {
                    Console.Clear();
                    modelOptions(); // call the modelOptions method
                    int model = Int32.Parse(Console.ReadLine());    // stores user input as an integer

                    materialOptions(); // call the materialOptions method
                    int material = Int32.Parse(Console.ReadLine()); // stores user input as an integer

                    colorOptions(); // call the colorOptions method
                    int color = Int32.Parse(Console.ReadLine()); // stores user input as an integer

                    if (model == 1) // if the user entered a 1 for the model
                    {
                        // call the add protocol droid method
                        addProtocol(setModel(model), setMaterial(material), setColor(color), droidCollection);
                    }
                    else if (model == 2) // if the user entered a 1 for the model
                    {
                        // call the add Utility droid method
                        addUtility(setModel(model), setMaterial(material), setColor(color), droidCollection);
                    }
                    else if (model == 3) // if the user entered a 1 for the model
                    {
                        // call the add Janitor droid method
                        addJanitor(setModel(model), setMaterial(material), setColor(color), droidCollection);
                    }
                    else if (model == 4) // if the user entered a 1 for the model
                    {
                        // call the add Astromech droid method
                        addAstromech(setModel(model), setMaterial(material), setColor(color), droidCollection);
                    }
                }
                if (userChoice == 2) // checks to see if the user entered a 2: view all droids
                {
                    Console.Clear();
                    outputDroidArray(); // call the output droid array method
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
