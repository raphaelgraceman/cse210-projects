using System;

namespace FinalProject
{
    public class FeedingCare : RSHCare
    {
        public FeedingCare(string name, string description, int counts, bool status) : base(name, description, counts.ToString())
        {
        }

        public override string DischargeCase()
        {
            int points = GetPoints();
            Console.WriteLine($"Congratulations! You have earned {points} points!\n");
            return $"Case discharged for FeedingCare: {GetName()}";
        }

        public override bool IsDischarged()
        {
            return true;
        }

        public override int LevelCompleted()
        {
            return 1;
        }

        public override string TempString()
        {
            return $"{GetName()} ({GetDescription()})";
        }

        public override string GetStringRepresentation()
        {
            return $"FeedingCare||{GetName()}||{GetDescription()}||{GetPoints()}||{GetStatus()}";
        }
    }
}
