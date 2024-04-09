using System;
namespace Eternal_Quest
{
    public class GoalManager
    {

        private List<Goal> _goals = new();
        private int _totalPoints = 0;
        private bool _status = false;
        private int _index = 0;
        private int _levelcap = 1000;

        private int _level = 1;


        public int GetIndex()
        {
            return _index;
        }
        public bool GetStat()
        {
            return _status;
        }
        public void CalculateTotalPoints(int points)
        {
            _totalPoints += points;
        }
        public int GetTotalPoints()
        {
            return _totalPoints;
        }

        public void SaveToFile()
        {

            string fileName = "";
            Console.Write("What is the filename? ");
            fileName = Console.ReadLine();
            if (File.Exists(fileName))
            {

                using StreamWriter update = File.AppendText(fileName);
                update.WriteLine($"{GetTotalPoints()}");
                update.WriteLine($"{GetLevel()}");
                update.WriteLine($"{GetLevelCap()}");
                foreach (Goal goal in _goals)
                {
                    update.WriteLine(goal.GetStringPresentation());
                }

            }

            using StreamWriter output = new StreamWriter(fileName);
            output.WriteLine($"{GetTotalPoints()}");
            output.WriteLine($"{GetLevel()}");
            output.WriteLine($"{GetLevelCap()}");
            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringPresentation());
            }
        }

        public void LoadFile()
        {

            Console.Write("What is the filename? ");
            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                _goals.Clear();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                _totalPoints = Convert.ToInt32(lines[0]);
                _level = Convert.ToInt32(lines[1]);
                _levelcap = Convert.ToInt32(lines[2]);

                for (int index = 1; index < lines.Length; index++)
                {
                    string[] parts = lines[index].Split("||");

                    if (parts[0] == "Simple Goal")
                    {
                        SimpleGoal newSimple = new(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                        _goals.Add(newSimple);
                    }

                    else if (parts[0] == "Eternal Goal")
                    {
                        EternalGoal newEternal = new(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                        _goals.Add(newEternal);
                    }

                    else if (parts[0] == "Checklist Goal")
                    {
                        CheckListGoal newChecklist = new(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]), Convert.ToBoolean(parts[7]));
                        _goals.Add(newChecklist);
                    }



                }
                Console.WriteLine("\nFile Loaded");

            }

            else
            {
                Console.WriteLine("\nFile not found");
            }

        }

        public void AddGoals(Goal goal)
        {
            _goals.Add(goal);
        }

        public void DisplayGoals()
        {
            Console.WriteLine("\nThese are the goals: ");
            int count = 1;
            foreach (Goal goalDisplay in _goals)
            {
                if (goalDisplay.GetStatus() == true)
                {

                    Console.WriteLine($"   {count}. [{goalDisplay.Complete()}] {goalDisplay.TempString()}");
                    count++;
                }
                else
                {
                    Console.WriteLine($"   {count}. [ ] {goalDisplay.TempString()}");
                    count++;
                }

            }
            Console.WriteLine();
        }

        public void RecordEvents()
        {
            Console.WriteLine("These are the goals: ");
            int count = 1;

            foreach (Goal goalDisplay in _goals)
            {
                Console.WriteLine($"    {count}. {goalDisplay.GetName()}");
                count++;
            }
            Console.Write("Choose the accomplishment: ");
            string recordPrompt = Console.ReadLine();
            int prompt = int.Parse(recordPrompt) - 1;

            if (prompt > _goals.Count())
            {
                Console.WriteLine("\nIncorrect Prompt");

            }
            else
            {
                if (_goals[prompt].GetStatus() == false)
                {
                    int points = _goals[prompt].RecordEvent();
                    CalculateTotalPoints(points);

                }
                else
                {
                    Console.WriteLine("\nYou have already accomplished this goal.");
                }

            }




        }

        public void CreateGoal(int prompt)
        {
            if (prompt == 1 || prompt == 2)
            {
                Console.Write("What is the name of the goal? ");
                string nameGoal = Console.ReadLine();

                Console.Write("What is a short description for the goal? ");
                string descriptionGoal = Console.ReadLine();

                Console.Write("How much points is the goal associated with? ");
                string stringPoint = Console.ReadLine();
                int pointGoal = int.Parse(stringPoint);
                GetStat();
                Console.Write("\n");

                if (prompt == 1)
                {
                    SimpleGoal simple = new(nameGoal, descriptionGoal, pointGoal, GetStat());
                    AddGoals(simple);



                }
                if (prompt == 2)
                {
                    EternalGoal eternal = new(nameGoal, descriptionGoal, pointGoal, GetStat());
                    AddGoals(eternal);
                }


            }
            if (prompt == 3)
            {
                Console.Write("What is the name of the goal? ");
                string nameGoal = Console.ReadLine();

                Console.Write("What is a short description for the goal? ");
                string descriptionGoal = Console.ReadLine();

                Console.Write("How much points is the goal associated with? ");
                string stringPoint = Console.ReadLine();
                int pointGoal = int.Parse(stringPoint);

                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string repeatString = Console.ReadLine();
                int repeat = int.Parse(repeatString);

                Console.Write("How much is the bonus points? ");
                string bonusString = Console.ReadLine();
                int bonusPoint = int.Parse(bonusString);
                GetStat();
                GetIndex();

                Console.Write("\n");

                CheckListGoal checkList = new(nameGoal, descriptionGoal, pointGoal, repeat, bonusPoint, GetIndex(), GetStat());
                AddGoals(checkList);
            }
        }
        public void DisplayMenu()
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goals");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
        }

        public void  GoalType()
        {
            Console.WriteLine("The types of Goals are: ");
            Console.WriteLine("   1. Simple Goal");
            Console.WriteLine("   2. Eternal Goal");
            Console.WriteLine("   3. Checklist Goal");
            Console.Write("Choose what type of Goal: ");
        }

        public void DisplayLevel()
        {
            while (_totalPoints >= _levelcap)
            {
                Console.WriteLine("You have gained a level!");
                _level++;
                _totalPoints -= _levelcap;
                _levelcap += 250;
            }
            Console.WriteLine($"Level {_level}");

            Console.WriteLine($"({_totalPoints}/{_levelcap})\n");
        }

        public int GetLevel()
        {
            return _level;
        }


        public int GetLevelCap()
        {
            return _levelcap;
        }


    }

}