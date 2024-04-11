using System;
using System.Collections.Generic;
using System.IO;

public class Caregivers
{
    private List<RSHCare> _rSHCare = new List<RSHCare>();
    private int _careCount = 0;

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
        AddRSHCare(rshCare);
        Console.WriteLine($"New case admitted: {rshCare.GetName()}");
    }

    public void DischargeCase()
    {
        Console.WriteLine("Discharging a case...");
        // Discharge logic here
    }

    public void SaveCase()
    {
        string fileName = "caregivers.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (RSHCare rshCare in _rSHCare)
            {
                writer.WriteLine(rshCare.GetStringRepresentation());
            }
        }
        Console.WriteLine("Cases saved to file.");
    }

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            _rSHCareList.Clear();
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                // Parse the line and create the appropriate caregiver object
                // Add the caregiver to the list
            }
            Console.WriteLine("File Loaded");
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Recording Event for Caregivers:");
        // Logic to record events for caregivers
    }
}