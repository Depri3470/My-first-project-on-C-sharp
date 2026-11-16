// See https://aka.ms/new-console-template for more information
Calculator calc = new Calculator();
ConsoleHelper ch = new ConsoleHelper();
Validator vd = new Validator();

string name = ch.ReadString("Введите ваше имя: ");

if (vd.IsValidName(name))
{
    ch.WriteLine($"Привет, {name}!");
} else
{
    ch.WriteLine("Имя не может быть пустым!");
}

int firstNumber = ch.ReadInt("Введите первое число: ");
int secondNumber = ch.ReadInt("Введите второе число: ");

int resultAdd = calc.Add(firstNumber, secondNumber);
int resultSub = calc.Subtract(firstNumber, secondNumber);
int resultMul = calc.Multiply(firstNumber, secondNumber);
float resultDiv = calc.Divide(firstNumber, secondNumber);

ch.WriteLine($"{firstNumber} + {secondNumber} = {resultAdd}");
ch.WriteLine($"{firstNumber} - {secondNumber} = {resultSub}");
ch.WriteLine($"{firstNumber} * {secondNumber} = {resultMul}");
if (vd.IsNotZero(secondNumber))
{
    ch.WriteLine("На ноль делить нельзя!");
} else
{
    ch.WriteLine($"{firstNumber} / {secondNumber} = {resultDiv}");
}