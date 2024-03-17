using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
// using System.Text.Json.Serialization;

public class Program
{
    private string _welcome = "Welcome to ETERNAL QUEST!";
    private int _totalPoints = 0;
    private List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }
    
        public void Start()
        {
            Console.Clear();
            Console.WriteLine(_welcome);
            Console.WriteLine($"\n* SCOREBOARD: {_totalPoints} pts *");  
            MainMenu();
        }
        public void Quit()
        {
            Console.Clear();
            Console.WriteLine("Thanks for playing ETERNAL QUEST!");
            Console.WriteLine($"\nSCOREBOARD: {_totalPoints} pts");
            Console.WriteLine("\n\nGoodbye!");
            Environment.Exit(0);   //exit the program
        }

        public void MainMenu()
        {
            Console.WriteLine("\n------ MAIN MENU ------");
            Console.WriteLine("1. Create Goal"); 
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("-------------------------\n");

            int choice = GetUserChoice(1, 6);

            switch (choice)
            {
                case 1:
                    GoalMenu();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Quit();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    MainMenu();
                    break;
            }
        }

        public void GoalMenu()
        {
            Console.Clear();
            Console.WriteLine("--------- GOAL MENU ---------");
            Console.WriteLine("1. Create Simple Goal");
            Console.WriteLine("2. Create Eternal Goal");
            Console.WriteLine("3. Create Checklist Goal");
            Console.WriteLine("4. Return to Main Menu");
            Console.WriteLine("-----------------------------\n");

            int choice = GetUserChoice(1, 4);

            switch (choice)
            {
                case 1:
                    CreateSimpleGoal();
                    break;
                case 2:
                    CreateEternalGoal();
                    break;
                case 3:
                    CreateChecklistGoal();
                    break;
                case 4:
                    Start();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    GoalMenu();
                    break;
            }
        }

        private void CreateSimpleGoal()
        {
            Console.Clear();
            Console.WriteLine("------ CREATE SIMPLE GOAL ------");
            Console.Write("\nEnter goal name: ");
            string input = Console.ReadLine();    
            string _name = char.ToUpper(input[0]) + input.Substring(1);   //capitalizes the first letter in _name
            Console.Write("Enter points for the goal: ");
            int _points = GetUserInputAsInt();
            Console.Write("Enter goal description: ");
            string _description = Console.ReadLine();

            Simple simpleGoal = new Simple(_name, _points, _description);
            goals.Add(simpleGoal);
            
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("\nSimple Goal created successfully.");

            Console.Write("\n\nPress enter to return to Goal Menu ");
            Console.ReadLine();
            GoalMenu();
        }
        private void CreateEternalGoal()
        {
            Console.Clear();
            Console.WriteLine("--- CREATE ETERNAL GOAL ---\n");
            Console.Write("Enter goal name: ");
            string input = Console.ReadLine();    
            string _name = char.ToUpper(input[0]) + input.Substring(1);
            Console.Write("Enter points for the goal: ");
            int _points = GetUserInputAsInt();
            Console.Write("Enter goal description: ");
            string _description = Console.ReadLine();

            Eternal eternalGoal = new Eternal(_name, _points, _description);
            goals.Add(eternalGoal);

            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("\nEternal Goal created successfully.");

            Console.Write("\n\nPress enter to return to Goal Menu ");
            Console.ReadLine();
            GoalMenu();
        }
        private void CreateChecklistGoal()
        {
            Console.Clear();
            Console.WriteLine("--- CREATE CHECKLIST GOAL ---\n");
            Console.Write("Enter goal name: ");
            string input = Console.ReadLine();    
            string _name = char.ToUpper(input[0]) + input.Substring(1);
            Console.Write("Enter points for the goal: ");
            int _points = GetUserInputAsInt();
            Console.Write("Enter goal description: ");
            string _description = Console.ReadLine();

            Console.Write("\nEnter bonus points for checklist completion: ");
            int _bonus = GetUserInputAsInt();
            Console.Write("Enter required frequency for checklist completion: ");
            int _frequency = GetUserInputAsInt();

            Checklist checklistGoal = new Checklist(_name, _points, _description, _bonus, _frequency);
            goals.Add(checklistGoal);

            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("\nChecklist Goal created successfully.");

            Console.Write("\n\nPress enter to return to Goal Menu ");
            Console.ReadLine();
            GoalMenu();
        }
    
        public void ListGoals()
        {
            Console.Clear();
            Console.WriteLine("----- LIST OF GOALS -----\n");

            for (int i = 0; i < goals.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                goals[i].ListGoal();
                Console.WriteLine();
            }

            Console.WriteLine("\n-------------------------");
            Console.Write("\n\nPress enter to return to Main Menu ");
            Console.ReadLine();
            Start();
        }

        public void SaveGoals() 
        {
            Console.Clear();
            Console.WriteLine("----- SAVE GOALS -----\n");

            Console.Write("Enter the filename for the goal file (ex: 'goals.txt'): ");
            string filename = Console.ReadLine();

            try
            {
                List<UserGoalData> userGoalDataList = new List<UserGoalData>();   //list of user goal data

                foreach (Goal goal in goals)
                {
                    if (goal is Simple simpleGoal)
                    {
                        UserGoalData _userGoalData = new UserGoalData
                        {
                            _name = simpleGoal._name,
                            _points = simpleGoal._points,
                            _description = simpleGoal._description
                        };
                        userGoalDataList.Add(_userGoalData);
                    }
                    else if (goal is Eternal eternalGoal)
                    {
                        UserGoalData _userGoalData = new UserGoalData
                        {
                            _name = eternalGoal._name,
                            _points = eternalGoal._points,
                            _description = eternalGoal._description
                        };
                        userGoalDataList.Add(_userGoalData);
                    }
                    else if (goal is Checklist checklistGoal)
                    {
                        UserGoalData _userGoalData = new UserGoalData
                        {
                            _name = checklistGoal._name,
                            _points = checklistGoal._points,
                            _description = checklistGoal._description,
                            _bonus = checklistGoal._bonus,
                            _frequency = checklistGoal._frequency,
                        };
                        userGoalDataList.Add(_userGoalData);
                    }
                }

                string json = JsonSerializer.Serialize(userGoalDataList);   //serialize user data

                Console.WriteLine("\n-----------------------");
                Console.WriteLine("\nGoals saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving goals. Please try again. {ex.Message}");
            }
            
            Console.Write("\n\nPress enter to return to Main Menu ");
            Console.ReadLine();
            Start();
        }

        public void LoadGoals() 
        {
            Console.Clear();
            Console.WriteLine("----- LOAD GOALS -----\n");

            Console.Write("Enter the filename for the goal file: ");
            string filename = Console.ReadLine();
            try 
            {
                if (File.Exists(filename))
                {
                    string json = File.ReadAllText(filename);
                    goals = JsonSerializer.Deserialize<List<Goal>>(json);
                    DisplayEntries();
                    Console.WriteLine("\n-----------------------");
                    Console.WriteLine("\nGoals loaded successfully!"); 
                }
                else
                {
                    Console.WriteLine("\nNo saved goals found.");
                    //loop back to the beginning of the method
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading goals: {ex.Message}");
            }
            
            Console.Write("\n\nPress enter to return to Main Menu ");
            Console.ReadLine();
            Start();
        }
    
        public void RecordEvent()
        {
            Console.Clear();
            Console.WriteLine("------ EVENT RECORDING ------\n");
            ListGoals();
            Console.Write("\nEnter the number of the goal you accomplished: ");   

            int index = GetUserInputAsInt();
            if (index >= 1 && index <= goals.Count)
            {
                Goal selectedGoal = goals[index - 1];
                selectedGoal.RecordEvent(ref _totalPoints);
                Console.WriteLine($"Event recorded successfully! You earned {_totalPoints} pts.");
            }
            else
            {
                Console.WriteLine("Invalid index. Please try again.");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("\n\nPress enter to return to Main Menu. ");
            Console.ReadLine();   
            Start();
        }

        public void DisplayEntries()   //this feels wrong...
        {
            foreach (Goal goal in goals)
            {
                foreach (Entry entry in goal._goals) 
                {
                    entry.DisplayEntry();
                }
            }
        }

        private int GetUserChoice(int min, int max)
        {
            int choice;

            Console.Write($"Enter a number between {min} and {max}: ");

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < min || choice > max)
            {
                Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
            }
            return choice;
        }
        private int GetUserInputAsInt()   //changes user input from string to int
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return input;
        }
}