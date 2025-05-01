using BankEventDemo;

namespace HW_02
{
    public class BankAccount
    {
        private decimal balance;

        // Події
        public event BalanceChangedHandler BalanceChangedDeposit;
        public event BalanceChangedHandler BalanceChangedWithdraw;

        // внесення коштів
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                BalanceChangedDeposit?.Invoke(balance);
            }
        }

        // зняття коштів
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                BalanceChangedWithdraw?.Invoke(balance);
            }
            else
            {
                Console.WriteLine("Недостатньо коштів або некоректна сума.");
            }
        }
    }
}
