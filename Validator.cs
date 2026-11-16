public class Validator
{
    public bool IsPositive(int number)
    {
        if (number > 0) {return true;} else {return false;}
    }

    public bool IsNotZero(int number)
    {
        if (number == 0) {return true;} else {return false;}
    }

    public bool IsValidName(string name)
    {
        if (name.Trim() == string.Empty) {return false;} else {return true;}
    }
}