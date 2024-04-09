using System;
namespace Eternal_Quest
{
    public class CheckListGoal : Goal
    {

        private int _repeat;
        private int _bonus;
        private int _index;


        public CheckListGoal(string name, string description, int points, int repeat, int bonus, int index, bool status) : base(name, description, points, status)
        {

            _repeat = repeat;
            _bonus = bonus;
            _index = index;

        }

        public override int RecordEvent()
        {
            int points = 0;

            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!\n");
            points = GetPoints();
            IncreaseIndex();

            if (_index == _repeat)
            {
                Console.WriteLine("\nCongratulations! You have reached the milestone!");
                Console.WriteLine($"You have earned {_bonus} bonus points!\n");
                points += _bonus;
                SetStatus(IsComplete());



            }
            return points;

        }

        public void IncreaseIndex()
        {
            _index += 1;
        }


        public override string Complete()
        {

            string sign = "X";
            return sign;
        }
        public override bool IsComplete()
        {
            bool isComplete = GetStatus();
            isComplete = true;
            return isComplete;
        }
        

        public override string TempString()
        {
            string represent = $"{GetName()} ({GetDescription()}) -- Currently Completed: {_index}/{_repeat}";
            return represent;
        }

        public override string GetStringPresentation()
        {
            return $"Checklist Goal||{GetName()}||{GetDescription()}||{GetPoints()}||{_repeat}||{_bonus}||{_index}||{GetStatus()}";
        }
    }
}