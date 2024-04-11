using System;
using System.IO;

namespace FinalProject
{
    public class RSHCare
    {
        private string _name;
        private string _description;
        private string _count;

        public RSHCare(string name, string description, string count)
        {
            _name = name;
            _description = description;
            _count = count;
        }

        public virtual void RecordEvent()
        {
            // Logic to record events for the RSHCare
            Console.WriteLine("Event recorded for the RSHCare: " + _name);
        }

        public virtual string DischargeCase()
        {
            return "Case discharged for RSHCare: " + _name;
        }

        public virtual bool IsDischarged()
        {
            // Logic to check if the case is discharged
            return true;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }

        public string GetCount()
        {
            return _count;
        }

        public virtual string GetStringRepresentation()
        {
            return $"Name: {_name}, Description: {_description}, Count: {_count}";
        }

        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(GetStringRepresentation());
            }
            Console.WriteLine("RSHCare saved to file: " + fileName);
        }

        public static RSHCare LoadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                if (lines.Length > 0)
                {
                    string[] parts = lines[0].Split(',');
                    if (parts.Length == 3)
                    {
                        string name = parts[0].Trim();
                        string description = parts[1].Trim();
                        string count = parts[2].Trim();

                        return new RSHCare(name, description, count);
                    }
                }
            }
            Console.WriteLine("Failed to load RSHCare from file: " + fileName);
            return null;
        }
    }
}
