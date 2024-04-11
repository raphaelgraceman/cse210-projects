using System;

namespace FinalProject
{
    public class EduCare : RSHCare
    {
        private int _levelCompleted;

        public EduCare(string name, string description, int points, int levelCompleted, bool status) : base(name, description, points, status)
        {
            _levelCompleted = levelCompleted;
        }

        public override int RecordEvent()
        {
            int points = GetPoints();

            Console.WriteLine($"Congratulations! You have earned {points} points!\n");

            if (_levelCompleted >= _points)
            {
                Console.WriteLine("\nCongratulations! You have completed the education level!");
                points += _bonus;
                SetStatus(IsComplete());
            }

            return points;
        }

        public override string Complete()
        {
            return "X";
        }

        public override bool IsComplete()
        {
            return _levelCompleted >= _points;
        }

        public override string TempString()
        {
            return $"{GetName()} ({GetDescription()}) -- Level Completed: {_levelCompleted}/{_points}";
        }

        public override string GetStringPresentation()
        {
            return $"EduCare||{GetName()}||{GetDescription()}||{GetPoints()}||{_levelCompleted}||{GetStatus()}";
        }
    }
}
