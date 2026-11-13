static void changedNumber(ref int n)
{
    n = 0;
    Console.WriteLine(n);
}

int MyNumber = 99;

changedNumber( ref MyNumber);
Console.WriteLine(MyNumber);

