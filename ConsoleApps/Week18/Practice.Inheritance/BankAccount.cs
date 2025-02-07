namespace Practice.Inheritance
{
    /// <summary>
    /// Private Access Modifiers.
    /// </summary>
    class BankAccount
    {
        private decimal _balance; //Only accessibily bank account

        private void UpdateBalance(decimal amount) 
        {
            _balance = _balance + amount;

        }

        public void Deposit (decimal amount)
        {
            this.UpdateBalance(amount);
        }
    }

}


