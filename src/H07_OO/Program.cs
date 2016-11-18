using System;
using OO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //we create object with new keyword
            BankAccount b1 = new BankAccount();
            b1.Deposit(100);
            try{
                b1.Withdraw(200);
            }catch(Exception ex){
                System.Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
        }
    }
}
