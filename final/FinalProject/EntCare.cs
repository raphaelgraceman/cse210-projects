using System;

namespace FinalProject
{
    public class EntCare : RSHCare
    {
        public EntCare(string namecaseTitle, string descriptionCase, int counts, bool status) : base(namecaseTitle, descriptionCase, counts, status)
        {
        }

        public override int DischargeCase()
        {
            int points = GetPoints();
            Console.WriteLine($"Congratulations! You have earned {points} points!\n");
            SetStatus(IsComplete());
            return points;
        }

        public override string Complete()
        {
            return "X";
        }

        public override bool IsDischarged()
        {
            return true;
        }
        public override int LevelCompleted()
        {
            return true;
        }

        public override string TempString()
        {
            return $"{GetName()} ({GetDescription()})";
        }

        public override string GetStringPresentation()
        {
            return $"EntCare||{GetName()}||{GetDescription()}||{GetPoints()}||{GetStatus()}";
        }
    }
}
