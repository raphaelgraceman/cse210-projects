using System;
using System.IO;

namespace FinalProject
{
    public class Caregivers
    {
        private List<RSHCare> _rSHCare = new List<RSHCare>();
        private int _careCount = 0;
        private bool = false;

        public void AddRSHCare(RSHCare rshCare)
        {
            _rSHCare.Add(rshCare);
            _careCount++;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Displaying Caregivers Information:");
            foreach (RSHCare rshCare in _rSHCare)
            {
                Console.WriteLine($"Name: {rshCare.GetName()}, Description: {rshCare.GetDescription()}, Count: {rshCare.GetCount()}");
            }
        }

        public void CasesTitle()
        {
            Console.WriteLine("Cases Title:");
            foreach (RSHCare rshCare in _rSHCare)
            {
                Console.WriteLine($"Name: {rshCare.GetName()}");
            }
        }

        public void CaseDetails()
        {
            Console.WriteLine("Case Details:");
            foreach (RSHCare rshCare in _rSHCare)
            {
                Console.WriteLine($"Name: {rshCare.GetName()}, Description: {rshCare.GetDescription()}, Count: {rshCare.GetCount()}");
            }
        }

        public void AdmitNewCase(RSHCare rshCare)
        {
           if (prompt == 1 || prompt == 2)
            {
                Console.Write("What is the name of the Case? ");
                string namecaseTitle = Console.ReadLine();

                Console.Write("Description of the case? ");
                string descriptionGoal = Console.ReadLine();

                Console.Write("Percentage care vulnerability: ");
                string stringPoint = Console.ReadLine();
                int pointGoal = int.Parse(stringPoint);
                GetStat();
                Console.Write("\n");

                if (prompt == 1)
                {
                    EntCare entertainment = new(namecaseTitle, descriptionCase, GetStat());
                    AddRSHCare(entertainment);



                }
                if (prompt == 2)
                {
                    FeedingCare feeding = new(namecaseTitle, descriptionCase, GetStat());
                    AddRSHCare(feeding);
                }


            }
            if (prompt == 3)
            {
                Console.Write("What is the name of the Case? ");
                string namecaseTitle = Console.ReadLine();

                Console.Write("Description of the case? ");
                string descriptionGoal = Console.ReadLine();

                Console.Write("Percentage care vulnerability: ");
                string stringPoint = Console.ReadLine();
                int pointRSHCare = int.Parse(stringPoint);

                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string repeatString = Console.ReadLine();
                int repeat = int.Parse(repeatString);

                Console.Write("\n");

                EduCare = new(namecaseTitle, descriptionCase, repeat, GetIndex(), GetStat());
                AddRSHCare(education);
            }
        }

        public void SaveCase()
        {
            string fileName = "";
            Console.Write("What is the filename? ");
            fileName = Console.ReadLine();
            if (File.Exists(fileName))
            {
                using StreamWriter update = File.AppendText(fileName);
                update.WriteLine($"{GetLevel()}");
               
                foreach (RSHCare rshCare in _rSHCare)
                {
                    update.WriteLine(care.GetStringPresentation());
                }

            }

            using StreamWriter output = new StreamWriter(fileName);
            output.WriteLine($"{GetLevel()}");
            foreach (RSHCare rshCare in _rSHCare)
            {
                output.WriteLine(rshCare.GetStringPresentation());
            }
            Console.WriteLine("Cases saved to file.");
        }

        public void LoadCase(string fileName)
        {
            Console.Write("What is the filename? ");
            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                _rSHCareList.Clear();
                string[] lines = File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    if (parts[0] == "Entertainment Care")
                    {
                         {
                            EntCare newEntertainment = new(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                            _rSHCareList.Add(newEntertainment);
                        }

                        else if (parts[0] == "Health Care")
                        {
                            HealthCare newHealthCare = new(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                            _rSHCareList.Add(newHealthCare);
                        }

                        else if (parts[0] == "Feeding Care")
                        {
                            FeedingCare newFeedingCare = new(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                            _rSHCareList.Add(newFeedingCare);
                        }

                        else if (parts[0] == "Educational Care")
                        {
                            EduCare newEducation = new(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]), Convert.ToBoolean(parts[7]));
                            _rSHCareList.Add(newEducation);
                        }
                    }
                   
                }
                Console.WriteLine("File Loaded");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }

        public void DischargeCase()
        {
            Console.WriteLine("Recording Event for Caregivers:");
            
            int count = 1;

            foreach (RSHCare careGiven in _rSHCare)
            {
                Console.WriteLine($"    {count}. {careGiven.GetName()}");
                count++;
            }
            Console.Write("Choose the accomplishment: ");
            string recordPrompt = Console.ReadLine();
            int prompt = int.Parse(recordPrompt) - 1;

            if (prompt > _rSHCare.Count())
            {
                Console.WriteLine("\nIncorrect Prompt");

            }
            else
            {
                if (_rSHCare[prompt].GetStatus() == false)
                {
                    int points = _rSHCare[prompt].DischargeCase();
                    CalculateTotalPoints(points);

                }
                else
                {
                    Console.WriteLine("\nYou have already accomplished this goal.");
                }
            }
        } 

        public void DisplayMenu()
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Admit New Case");
            Console.WriteLine(" 2. Admitted Cases");
            Console.WriteLine(" 3. Save Case");
            Console.WriteLine(" 4. Load Cases");
            Console.WriteLine(" 5. Discharge Case");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
        }

        public void  GoalType()
        {
            Console.WriteLine("The types of Goals are: ");
            Console.WriteLine("   1. Entertainment");
            Console.WriteLine("   2. Health Care");
            Console.WriteLine("   3. Education");
            Console.WriteLine("   4. Feeding");
            Console.Write("Choose what type of Goal: ");
        }

        public void DisplayLevel()
        {
            while (_levelCompleted >= _levelcap)
            {
                Console.WriteLine("You have gained a level!");
                _level++;
                _levelCompleted -= _levelcap;
                _levelcap += 100%;
            }
            Console.WriteLine($"Level {_level}");

            Console.WriteLine($"({_levelCompleted}/{_levelcap})\n");
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