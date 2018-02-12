using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string commands = Console.ReadLine();
        var accounts = new Dictionary<int, BankAccount>();
        while (commands != "End")
        {
            string[] command = commands.Split().ToArray();
            switch (command[0])
            {
                case "Create":
                    Create(command,accounts);
                    break;
                case "Deposit":
                    Deposit(int.Parse(command[1]),double.Parse(command[2]),accounts);
                    break;
                case "Withdraw":
                    Withdraw(int.Parse(command[1]), double.Parse(command[2]), accounts);
                    break;
                case "Print":
                    Print(int.Parse(command[1]),accounts);
                    break;

            }



            commands = Console.ReadLine();
        }
    }

    public static void Create(string[] comArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(comArgs[1]);
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var account = new BankAccount();
            account.Id = id;
            accounts.Add(id,account);
        }
    }
    private static void Deposit(int id, double amount, Dictionary<int, BankAccount> accounts)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        accounts[id].Deposit(amount);
    }

    public static void Withdraw(int id, double amount, Dictionary<int,BankAccount> accounts)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        if (accounts[id].Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }

        accounts[id].Withdraw(amount);
    }
    private static void Print(int id, Dictionary<int, BankAccount> accounts)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        Console.WriteLine(accounts[id].ToString());
    }
}