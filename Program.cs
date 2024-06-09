namespace uml_hw_five
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM() { Amount = 500 };
            BankAccount bankAccount = new BankAccount() { PIN = 12345, AccountCard = new BankCard() { IsCardValid = true }, Balance = 100};
            ATMAmountHandler atmAmountHandler = new ATMAmountHandler();
            AcountBalanceHandler acountBalanceHandler = new AcountBalanceHandler();
            PINHandler pinHandler = new PINHandler();
            CardValidHandler cardValidHandler = new CardValidHandler();
            cardValidHandler.SetNext(pinHandler.SetNext(acountBalanceHandler.SetNext(atmAmountHandler)));
            BaseATMHandler atmHandler = cardValidHandler;
            float result = atmHandler.Handle(atm, bankAccount, 12345, 73);
            Console.WriteLine($"The ATM gave you ${result}");
        }
    }
}
