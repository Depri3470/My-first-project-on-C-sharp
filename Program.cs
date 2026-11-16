// See https://aka.ms/new-console-template for more information
Calculator calc = new Calculator();
ConsoleHelper con = new ConsoleHelper();

int firstNumber = con.ReadInt("");
int secondNumber = con.ReadInt("");

int resultAdd = calc.Add(firstNumber, secondNumber);
int resultSub = calc.Subtract(firstNumber, secondNumber);
int resultMul = calc.Multiply(firstNumber, secondNumber);
float resultDiv = calc.Divide(firstNumber, secondNumber);

int result = con.WriteLine("");
Console.WriteLine($"{firstNumber} - {secondNumber} = {resultSub}");
Console.WriteLine($"{firstNumber} * {secondNumber} = {resultMul}");
if (resultDiv == 0)
{
    Console.WriteLine("На ноль делить нельзя!");
} else
{
    Console.WriteLine($"{firstNumber} / {secondNumber} = {resultDiv}");
}