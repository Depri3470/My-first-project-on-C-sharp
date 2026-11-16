public class ConsoleHelper
{
    public int ReadInt(string message)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    public string ReadString(string message)
    {
        string messageOut = Console.ReadLine() ?? string.Empty;
        return messageOut;
    }

    public string WriteLine(string message)
    {
        Console.WriteLine(message);
        return message;
    }
}