class Calculator
{

public static int Add(int num1, int num2)
{
    return num1 + num2;

}
//Both versions of this method can exist at the same time 
//because C# can always identify which version of the Add method() 
//we'd want to use at any given moment in time
public static int Add(int num1, int num2, int num3)
{
    return num1 + num2+ num3;
}
//just changing name of parameters does not identify a method as unique
//cannot have another overloaded method with the exact same params
//public static int Add(int value1, int value2)
//{
  //  return value1 + value2;
//}

public static double Add(double num1, double num2)
{
    return num1 + num2;
}

public static double Add(string num1, double num2)
{
    return double.Parse(num1) + num2;
}

public static double Add(double num1, string num2)
{
    return num1 + double.Parse(num2);
}

public static int Add(int num1)
{
    return num1;
}

public static int Add()
{
    return 0;
}
public static int Add(int[] array)
{
    int sum = 0;
    foreach (int num in array)
    {
        sum += num;
    }
    return sum;
}
//parms--> parameter array argument: 
//lets you provide a variable number of arguments to satisfy this one parameter, 
//in which it will 'collect' them into one array for us
//can only have 1 parameter array per method
//it MUST be the last parameter in the method
public static double Add(params double[] array)
{
    double sum = 0;
    foreach (double num in array)
    {
        sum += num;
    }
    return sum;
}

}
