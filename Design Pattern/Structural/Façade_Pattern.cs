using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural
{
    internal class Façade_Pattern
    {

        public interface IAccount
        {
            public void deposit(double amount);
            public void withdraw(double amount);
            public void transfer(IAccount toAccount, double amount);
            public int getAccountNumber();
        }

        public class BankService
        {
            private Dictionary<int, IAccount> bankAccounts;
            public BankService()
            {
                bankAccounts = new Dictionary<int, IAccount>();
            }
            public int createNewAccount(string type, double
            initAmount)
            {
                IAccount newAccount = null;
                switch (type)
                {
                    case "chequing":
                        newAccount = new Chequing(initAmount);
                        break;
                    case "saving":
                        newAccount = new Saving(initAmount);

                        break;
                    case "investment":
                        newAccount = new Investment(initAmount);
                        break;
                    default:
                        Console.WriteLine("Invalid account type");
                        break;
                }
                if (newAccount != null)
                {
                    bankAccounts.Add(newAccount.getAccountNumber(),
                    newAccount);
                    return newAccount.getAccountNumber();
                }
                return -1;
            }


            public void transferMoney(int to, int from, double
            amount)
            {
                IAccount toAccount = bankAccounts[to];
                IAccount fromAccount = bankAccounts[from];
                fromAccount.transfer(toAccount, amount);
            }
        }









        public class Chequing : IAccount
        {
            private double initAmount;



            public Chequing(double initAmount)
            {
                this.initAmount = initAmount;
            }

            public void deposit(double amount)
            {
                throw new NotImplementedException();
            }

            public int getAccountNumber()
            {
                throw new NotImplementedException();
            }

            public void transfer(double amount)
            {
                throw new NotImplementedException();
            }

            public void withdraw(double amount)
            {
                throw new NotImplementedException();
            }

            void IAccount.deposit(double amount)
            {
                throw new NotImplementedException();
            }

            int IAccount.getAccountNumber()
            {
                throw new NotImplementedException();
            }

            void IAccount.transfer(IAccount toAccount, double amount)
            {
                throw new NotImplementedException();
            }

            void IAccount.withdraw(double amount)
            {
                throw new NotImplementedException();
            }
        }
        public class Saving : IAccount
        {
            public Saving(double initAmount)
            {
                InitAmount = initAmount;
            }

            public double InitAmount { get; }

            public void deposit(double amount)
            {
                throw new NotImplementedException();
            }

            public int getAccountNumber()
            {
                throw new NotImplementedException();
            }

            public void transfer(double amount)
            {
                throw new NotImplementedException();
            }

            public void withdraw(double amount)
            {
                throw new NotImplementedException();
            }

            void IAccount.transfer(IAccount toAccount, double amount)
            {
                throw new NotImplementedException();
            }
        }
        public class Investment : IAccount
        {
            public Investment(double initAmount)
            {
                InitAmount = initAmount;
            }

            public double InitAmount { get; }

            public void deposit(double amount)
            {
                throw new NotImplementedException();
            }

            public int getAccountNumber()
            {
                throw new NotImplementedException();
            }

            public void transfer(double amount)
            {
                throw new NotImplementedException();
            }

            public void withdraw(double amount)
            {
                throw new NotImplementedException();
            }

            void IAccount.transfer(IAccount toAccount, double amount)
            {
                throw new NotImplementedException();
            }
        }



    }
}
