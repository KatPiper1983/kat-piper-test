// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //determine starting balance
        bool isFee = shouldGetAFee(200.00);
        System.Console.WriteLine(isFee);
        
        
        //GetAFeeMethod:
        //  check balance
        //  if balance is less than $100, there will be a fee
        //  if balance is more than $100, there is no fee

        int[] digits = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        int sum = 0;

        foreach(int digit in array)
        {
            
        }

    }

    public static bool shouldGetAFee(double balance)
    {
         if (balance < 100.00)
        {
           return true;
           
        }
        else
        {
            return false;
            
        }
        
    }
}
