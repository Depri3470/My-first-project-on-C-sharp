using System.Collections.Generic;

public class HistoryManager
{
    ConsoleHelper ch = new ConsoleHelper();

    private List<string> records = new List<string>();
    public void AddRecord(string record)
    {
        records.Add($"{record}");
    }

    public void ShowHistory()
    {
        ch.WriteLine("\nИстория операций:");

        foreach (string record in records)
        {
            ch.WriteLine(record);
        }

    }
}