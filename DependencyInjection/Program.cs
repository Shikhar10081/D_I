
using DependencyInjection;

IAccount iac = new SavingAccount();
Account ac = new Account(iac);
 ac.PrintAC_Details();
///////////////////////////////////////////////////////////////////
///
//IAccount iac2= new CurrentAccount();
//Account ac1 = new Account(iac2);
//ac1.PrintAC_Details();
Console.ReadLine();