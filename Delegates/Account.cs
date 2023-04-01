using System;

namespace SimpleDelegatesDemo;

public class Account
{
    public delegate void Operation();
    public int Id{get; set;}
    public double Balance{get; set;}
    public int CustomerId{get; set;}

    public Account()
    {
        this.Balance=0;
    }
    public Account(double amount)
    {
        this.Balance=amount;
    }

    public event Operation underBalance;
    public event Operation overBalance;

    public void Monitor()
    {
        if(this.Balance < 5000)
        {
            underBalance();
        }
        else if(this.Balance > 250000)
        {
            overBalance();
        }
    }

    public static Account Create(double initialAmount)
    {
        Account account = new Account(initialAmount);
        return account;
    }

    public void Deposit(double amount)
    {
        this.Balance=+ amount;
        Monitor();
    }
    public void Withdraw(double amount)
    {
        this.Balance=- amount;
        Monitor();
    }
}