Console.WriteLine("num1");
double num1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("num2");
double num2 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("+,-,*,/,%");
string sing = Console.ReadLine();
double result = 0;
if  (sing == "+")
{
    result = num1 + num2;
}
if (sing == "-")
{
    result = num1 - num2;
}
if (sing == "*")
{
    result = num1 + num2;
}
if (sing == "/")
    result = num1 / num2;
Console.WriteLine(result);
