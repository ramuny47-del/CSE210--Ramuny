using System;
using System.Data.Common;
using System.IO.Enumeration;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        List<Goal> goals = new List<Goal>();
        List<Skill> skills = new List<Skill>();
        List<DailyHabit> Habits = new List<DailyHabit>();
        int totalPoints = 0;
        int level = 1;
        int PointNeeded = 0;
        string title = "Unkown";


    
       
        
       
        

        while (true)
        {    Level Levelup = new Level(level);
        title = Levelup.GetTitle();
            Console.WriteLine($"Level: {level} Title: {title} Points: {totalPoints}/{PointNeeded}");
            Console.WriteLine();
            Console.WriteLine("What Do you want to do?");
            Console.WriteLine();
            Console.WriteLine("0. Clear the Terminal & Update Level");
            Console.WriteLine();
            Console.WriteLine("1. Make a new goal");
            Console.WriteLine();
            Console.WriteLine("2. Display");
            Console.WriteLine();
            Console.WriteLine("3. Record an event");
            Console.WriteLine();
            Console.WriteLine("4. Save Goals to file");
            Console.WriteLine();
            Console.WriteLine("5. Load goals from file");
            Console.WriteLine();
            Console.WriteLine("6. Display total Point");
            Console.WriteLine();
            Console.WriteLine("7. Add Skill");
            Console.WriteLine();
            Console.WriteLine("8. Add Daily Habit");
            Console.WriteLine();
            Console.WriteLine("9. Quit");

            string choice = Console.ReadLine();

            PointNeeded = Levelup.PointNeededtoLevelUp();
            double TotalPointsDouble = totalPoints;
            double levelCalculation = TotalPointsDouble / 783;

            if (levelCalculation > level)
            {
            level++;
            }

            if (choice == "0")
            {
                Console.Clear();
            }
            if (choice == "1")
            {  Console.Clear();
               Console.WriteLine("Select goal type: ");
               Console.WriteLine("1. Simple Goal (One-Time)");
               Console.WriteLine("2. Checklist Goal");
               Console.WriteLine("3. Eternal Goal");

               string type = Console.ReadLine();

                Console.Clear();
               Console.Write("Goal Description: ");
               string description = Console.ReadLine();
               Console.Write("Points: ");
               int point = int.Parse(Console.ReadLine());
               Console.WriteLine();
               Console.WriteLine();
               if (type == "1")
                {
                    goals.Add(new SimpleGoal(description, point));
                }

               else if (type == "2")
                {   Console.Write("How many times to complete this Goal? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Bonus Points when all completed: ");
                    int bonus = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();

                    goals.Add(new CheckListGoal(description, point, bonus, target));
                }
                else if (type == "3")
                {
                    goals.Add(new EternalGoal(description, point));
                }
                else 
                {
                Console.WriteLine("Invalid type!");
                }

            }

            else if (choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("1. Display Goals");
                    Console.WriteLine("2. Display Skills");
                    Console.WriteLine("3. Display Daily Habits");

                    string input = Console.ReadLine();

                    if (input == "1"){
                    Console.Clear();
                    foreach(Goal goal in goals)
                    {   Console.WriteLine();
                        Console.WriteLine("---------- Goals ----------");
                        goal.Display();
                    }
                    Console.WriteLine();
                    Console.WriteLine();}

                    else if (input == "2")
                {
                    Console.Clear();
                    Console.WriteLine("------------- Skills --------------");
                    Console.WriteLine();
                    foreach(Skill skill in skills)
                    {
                        Console.WriteLine();
                        skill.Display();
                    }

                    Console.WriteLine();
                }
                    else if(input == "3")
                {
                    Console.Clear();
                    Console.WriteLine("-------------- Daily Habits ---------------");
                    foreach(DailyHabit habit in Habits)
                    {
                        Console.WriteLine();
                        habit.Display();
                    }
                    Console.WriteLine();
                }
                }
            
            else if (choice == "3")
                {   Console.Clear();
                    Console.WriteLine("1. Gaols");
                    Console.WriteLine("2. Daily Habits");
                    string input = Console.ReadLine();

                    if(input == "1")
                {
                     int i = 1;
                    foreach(Goal goal in goals)
                    {
                        Console.WriteLine("---------- Goals ----------");
                        Console.WriteLine($"Goal Index: {i}");
                        goal.Display();
                        i++;
                   }
                    Console.WriteLine();
                    Console.WriteLine("Select goal number to record: ");
                     int index = int.Parse(Console.ReadLine()) -1;

                    if (index >= 0 && index < goals.Count)
                        {
                            int earned = goals[index].recordEvent();
                            Console.WriteLine($"Points earned: {earned}");
                            totalPoints += earned;
                            Console.WriteLine();
                            Console.WriteLine();

                        }
                        else
                        {
                            Console.WriteLine("Invalid selection");
                        }
                }
                    if(input == "2")
                {
                    int i = 1;
                    foreach(DailyHabit habit in Habits)
                    {
                        Console.WriteLine("------------Daily Habits ---------------");
                        Console.WriteLine();
                        Console.WriteLine($"Habit Index: {i}");
                        i++;
                        habit.Display();
    
                    }
                    Console.WriteLine();
                    Console.WriteLine("Select Habit Number to record: ");
                    int index = int.Parse(Console.ReadLine()) -1;
                    if (index >= 0 && index < Habits.Count)
                    {
                        Habits[index].Complete();
                        Habits[index].Penalty();

                    }
                    else
                    {
                        Console.WriteLine("Invalid Selection");
                    }
                    

                }

                   
                    }
                    
                
            if (choice == "4")
                {   Console.Clear();
                    Console.Write("Enter File Name: ");
                    string filename = Console.ReadLine();
                    List<string> ListGoal = new List<string>();
                    foreach (Goal goal in goals)
                    {
                        ListGoal.Add(goal.DisplayInString());
                    }
                    File.WriteAllLines(filename, ListGoal);
                    string levelString = $"Level|{level}|{totalPoints}";
                    File.AppendAllText(filename, levelString);
                    Console.WriteLine($"All entries saved to {filename}!");
                    Console.WriteLine();
                    Console.WriteLine();

                }
            if (choice == "5")
                {   Console.Clear();
                    Console.WriteLine("Enter filename to load: ");
                    string filename = Console.ReadLine();
                    Load LoadFile = new Load(filename);
                    var Data = LoadFile.LoadGoal();
                    goals = Data.goals;
                    level = Data.level;
                    totalPoints = Data.totalPoints;
                    Console.WriteLine();
                    Console.WriteLine();             
                }
            if (choice == "6")
            {   Console.Clear();
                Console.WriteLine($"Your Total point is {totalPoints}");
                Console.WriteLine();
                Console.WriteLine();
            }
            if (choice == "7")
            {
                Console.Clear();
                Console.Write("Skill Name:  ");
                string skill = Console.ReadLine();
                Skill NewSkill = new Skill(skill, 0, 1);
                skills.Add(NewSkill);
            }

            if (choice == "8")
            {
                Console.Clear();
                Console.Write("Habit Name: ");
                string habitName = Console.ReadLine();
                Console.Write("XP per completion: ");
                int habitXP =int.Parse(Console.ReadLine());

                 int i = 1;
                    foreach(Skill skill in skills)
                    {
                        Console.WriteLine("---------- Skills ----------");
                        Console.WriteLine($"Skill Index: {i}");
                        skill.Display();
                        i++;
                   }
                Console.WriteLine("Skill, the habit tied to: ");
                     int index = int.Parse(Console.ReadLine()) -1;
                     if (index >= 0 && index < skills.Count)
                        {
                            Skill LinkedSkill = skills[index];
                            DailyHabit habit = new DailyHabit(habitName,LinkedSkill, habitXP );
                            Habits.Add(habit);
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection");
                        }


                
            }
            if (choice == "9")
            {
                break;
            }}}}

             
        
        

        

    
