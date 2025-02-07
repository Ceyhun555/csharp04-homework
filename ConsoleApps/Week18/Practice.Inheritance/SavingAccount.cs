namespace Practice.Inheritance
{
    class SavingAccount :BankAccount
    {
        public void AddInterest(decimal amount)
        {
            base.Deposit(amount);
        }
    }

}


