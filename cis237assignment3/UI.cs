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

        // this method will show the different options for model types
        public void modelOptions()
        {
            Console.Clear();
            Console.WriteLine("Select a Model: ");
            Console.WriteLine("1) protocol  - $100");
            Console.WriteLine("2) utility   - $250");
            Console.WriteLine("3) janitor   - $150");
            Console.WriteLine("4) astromech - $325");
        }

        // this method will show the different options for material types
        public void materialOptions()
        {
            Console.Clear();
            Console.WriteLine("Select a Material: ");
            Console.WriteLine("1) cerillium - $200");
            Console.WriteLine("2) Polyfibe  - $150");
            Console.WriteLine("3) Tekonite  - $100");
        }

        // this method will show the different options for colors
        public void colorOptions()
        {
            Console.Clear();
            Console.WriteLine("Select a color: ");
            Console.WriteLine("1) red    - $200");
            Console.WriteLine("2) gold   - $500");
            Console.WriteLine("3) orange - $150");
        }


        // this method comvers the model int input from the user into a string
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

        // this method converts the material int input from the user into a string
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

        // this method converts the color int input from the user into a string
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

        // this method does the propper functions / calls to add a protocol droid
        public static void addProtocol(string model, string material, string color, DroidCollection droidCollection)
        {
            // prompt the user for language feature
            Console.Clear();
            Console.WriteLine("Language feature: $300 per language");
            Console.WriteLine("How many languages should the droid know? ");
            int numberOfLanguages = Int32.Parse(Console.ReadLine());

            // call the addDroid method in the droid collection class
            // pass parameters for protocol droid
            droidCollection.addDroid(model, material, color, numberOfLanguages);
        }

        // this method does the propper functions / calls to add a utility droid
        public static void addUtility(string model, string material, string color, DroidCollection droidCollection)
        {
            // initialize the required bools
            bool toolbox = false;
            bool computerConnection = false;
            bool arm = true;

            // prompt the user for toolbox
            Console.Clear();
            Console.WriteLine("toolbox feature: $100");
            Console.WriteLine("Would you like a toolbox? 1 = yes; 2 = no");
            int toolboxInt = Int32.Parse(Console.ReadLine());
            if (toolboxInt == 1)
                toolbox = true;

            // prompt the user for computer connection
            Console.WriteLine(Environment.NewLine + "Computer connection feature: $850");
            Console.WriteLine("Would you like a Computer Connection? 1 = yes; 2 = no");
            int computerConnectionInt = Int32.Parse(Console.ReadLine());
            if (computerConnectionInt == 1)
                computerConnection = true;

            // prompt the user for an arm
            Console.WriteLine(Environment.NewLine + "Arm feature: $600");
            Console.WriteLine("Would you like an arm? 1 = yes; 2 = no");
            int armInt = Int32.Parse(Console.ReadLine());
            if (armInt == 1)
                arm = true;

            // call the addDroid method in the droid collection class
            // pass parameters for utility droid
            droidCollection.addDroid(model, material, color, toolbox, computerConnection, arm);
        }

        // this method does the propper functions / calls to add a janitor droid
        public static void addJanitor(string model, string material, string color, DroidCollection droidCollection)
        {
            // initialize the required bools
            bool toolbox = false;
            bool computerConnection = false;
            bool arm = true;
            bool trashCompactor = false;
            bool vacuum = false;

            // prompt the user for toolbox
            Console.Clear();
            Console.WriteLine("toolbox feature: $100");
            Console.WriteLine("Would you like a toolbox? 1 = yes; 2 = no");
            int toolboxInt = Int32.Parse(Console.ReadLine());
            if (toolboxInt == 1)
                toolbox = true;

            // prompt the user for computer connection
            Console.WriteLine(Environment.NewLine + "Computer connection feature: $850");
            Console.WriteLine("Would you like a Computer Connection? 1 = yes; 2 = no");
            int computerConnectionInt = Int32.Parse(Console.ReadLine());
            if (computerConnectionInt == 1)
                computerConnection = true;

            // prompt the user for an arm
            Console.WriteLine(Environment.NewLine + "Arm feature: $600");
            Console.WriteLine("Would you like an arm? 1 = yes; 2 = no");
            int armInt = Int32.Parse(Console.ReadLine());
            if (armInt == 1)
                arm = true;

            // prompt the user for trash compactor feature
            Console.WriteLine(Environment.NewLine + "trash Compactor feature: $500");
            Console.WriteLine("Would you like an trash Compactor? 1 = yes; 2 = no");
            int trashCompactorInt = Int32.Parse(Console.ReadLine());
            if (trashCompactorInt == 1)
                trashCompactor = true;

            // prompt the user for vacuum feature
            Console.WriteLine(Environment.NewLine + "vacuum feature: $300");
            Console.WriteLine("Would you like an trash Compactor? 1 = yes; 2 = no");
            int vacuumInt = Int32.Parse(Console.ReadLine());
            if (vacuumInt == 1)
                vacuum = true;

            // call the addDroid method in the droid collection class
            // pass parameters for janitor droid
            droidCollection.addDroid(model, material, color, toolbox, computerConnection, arm, trashCompactor, vacuum);
        }

        // this method does the propper functions / calls to add an astromech droid
        public static void addAstromech(string model, string material, string color, DroidCollection droidCollection)
        {
            // initialize the required bools
            bool toolbox = false;
            bool computerConnection = false;
            bool arm = true;
            bool fireExtinguisher = false;

            // prompt the user for toolbox feature
            Console.Clear();
            Console.WriteLine("toolbox feature: $100");
            Console.WriteLine("Would you like a toolbox? 1 = yes; 2 = no");
            int toolboxInt = Int32.Parse(Console.ReadLine());
            if (toolboxInt == 1)
                toolbox = true;

            // prompt the user for computer connection feature
            Console.WriteLine(Environment.NewLine + "Computer connection feature: $850");
            Console.WriteLine("Would you like a Computer Connection? 1 = yes; 2 = no");
            int computerConnectionInt = Int32.Parse(Console.ReadLine());
            if (computerConnectionInt == 1)
                computerConnection = true;

            // prompt the user for arm feature
            Console.WriteLine(Environment.NewLine + "Arm feature: $600");
            Console.WriteLine("Would you like an arm? 1 = yes; 2 = no");
            int armInt = Int32.Parse(Console.ReadLine());
            if (armInt == 1)
                arm = true;

            // prompt the user for fire extinguisher feature
            Console.WriteLine(Environment.NewLine + "fire extinguisher feature: $200");
            Console.WriteLine("Would you like a fire extinguisher? 1 = yes; 2 = no");
            int fireExtinguisherInt = Int32.Parse(Console.ReadLine());
            if (fireExtinguisherInt == 1)
                fireExtinguisher = true;

            // prompt the user for ships feature
            Console.WriteLine(Environment.NewLine + "Ships feature: $300 per ship");
            Console.WriteLine("How many ships would you like? ");
            int numberOfShips = Int32.Parse(Console.ReadLine());

            // call the addDroid method in the droid collection class
            // pass parameters for astromech droid
            droidCollection.addDroid(model, material, color, toolbox, computerConnection, arm, fireExtinguisher, numberOfShips);
        }

        // outputs all of the droid data
        public void outputDroidArray()
        {
            Console.WriteLine();
            Console.Clear();
            // Get the output string from the droidCollection class's method:
            Console.WriteLine(droidCollection.outputDroidArray());
            Console.WriteLine();
        }
    }
}
