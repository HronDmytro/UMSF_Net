using HW_02;

namespace BankEventDemo
{
    public delegate void BalanceChangedHandler(decimal newBalance);

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            BankAccount account = new BankAccount();
            AccountMonitor monitor = new AccountMonitor();

            // Підписка на події
            account.BalanceChangedDeposit += monitor.OnBalanceChanged;
            account.BalanceChangedWithdraw += monitor.OnBalanceChanged;

            // Тестові операції
            account.Deposit(1000);     // Новий баланс: 1000,00 грн
            account.Withdraw(250);     // Новий баланс: 750,00 грн
            account.Withdraw(600);     // Новий баланс: 150,00 грн
        }
    }
}
