using System;

namespace FinalProject
{
    public class HealthCare : RSHCare
    {
        public HealthCare(string name, string description, int points, bool status) : base(name, description, points, status)
        {
        }

        public override int RecordEvent()
        {
            int points = GetPoints();
            Console.WriteLine($"Congratulations! You have earned {points} points!\n");
            return points;
        }

        public override string Complete()
        {
            return "X";
        }

        public override bool IsComplete()
        {
            return true;
        }

        public override string TempString()
        {
            return $"{GetName()} ({GetDescription()})";
        }

        public override string GetStringPresentation()
        {
            return $"HealthCare||{GetName()}||{GetDescription()}||{GetPoints()}||{GetStatus()}";
        }
    }
}
