using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection;
//{
//       public class SavingAccount
//    {
//        public void SavingDelails()
//        {
//            Console.WriteLine("Saving Account ");
//        }
//    }

//    public class CurrentAccount
//    {
//        public void SavingDelails()
//        {
//            Console.WriteLine("Current Account ");
//        }
//    }

//     public class Account
//    {                                                       // here my Account class depend on the Saving account and Current account  so there is  tight coupling 
//        SavingAccount sv = new SavingAccount();
//        CurrentAccount cv = new CurrentAccount();
//          public void PrintAccounts()
//        {
//            sv.SavingDelails();
//            cv.SavingDelails();
//        }
//    } 

//////////////////////////////////////// Now Dependency Injection 


public interface IAccount
{
    public void SavingDelails();
}


public class SavingAccount : IAccount
{
    public void SavingDelails()
    {
        Console.WriteLine("Saving Account ");
    }
}

public class CurrentAccount : IAccount
{
    public void SavingDelails()
    {
        Console.WriteLine("Current Account ");
    }
}

public class Account
{
    private IAccount accountabc;    // reference variabel 
    public Account(IAccount obj)   // contructor ke throu ham inject kre ge  referance variable ko;
    {
        accountabc = obj;
    }

    public void PrintAC_Details()
    {
        accountabc.SavingDelails();

    }
}