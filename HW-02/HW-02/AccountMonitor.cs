namespace HW_02
{
    public class AccountMonitor
    {
        // викликається при зміні балансу
        public void OnBalanceChanged(decimal newBalance)
        {
            Console.WriteLine($"Новий баланс: {newBalance}");
        }
    }
}
