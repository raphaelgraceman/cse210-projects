using System.IO;
namespace Eternal_Quest
{
    public class Goal
    {
        private string _name;
        private string _description;
    
        private bool _status = false;
        private int _points;

        public Goal(string name, string description, int points,bool status)
        {
            _name = name;
            _description = description;
            _points = points;
            _status = status;
        }

        public virtual int RecordEvent()
        {
            int recordPoints = 0;
            return recordPoints;
        }
        public virtual string Complete()
        {   

            string sign = "";
            return sign;
        }
        public virtual bool IsComplete()
        {   
            bool status = GetStatus();
            return status;
        }

        public bool GetStatus()
        {
            return _status;

        }

        public void SetStatus(bool status)
        {
            _status = status;
        }
    
        
        
        public int GetPoints()
        {
            return _points;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }
        

        public virtual string TempString()
        {
            return "";
        }

        public virtual string GetStringPresentation()
        {
            return "";
        }
    
    }
}