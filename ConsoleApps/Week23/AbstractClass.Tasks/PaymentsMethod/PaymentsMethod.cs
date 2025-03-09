using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Tasks.PaymentsMethod
{
    abstract class PaymentMethod
    {
        public string PaymentType { get; protected set; }
        public decimal ProcessingFee { get; protected set; }
        public string TransactionId { get; protected set; }

        public PaymentMethod()
        {

        }

        public abstract bool ProcessPayment(decimal amount);
        public abstract bool ValidatePaymentDetails();
        public abstract string GenerateReceipt();

        protected decimal CalculateTotal(decimal amount)
        {
            return amount + ProcessingFee;
        }
    }

    // Credit Card Payment Class
    class CreditCardPayment : PaymentMethod
    {
        private string CardNumber;
        private string ExpiryDate;
        private string CVV;

        public CreditCardPayment(string cardNumber, string expiryDate, string cvv)
        {
            PaymentType = "Credit Card";
            ProcessingFee = 2.5m;
            CardNumber = cardNumber;
            ExpiryDate = expiryDate;
            CVV = cvv;
            TransactionId = Guid.NewGuid().ToString();
        }

        public override bool ProcessPayment(decimal amount)
        {
            if (!ValidatePaymentDetails())
            {
                return false;
            }
            Console.WriteLine($"Processing Credit Card payment of {CalculateTotal(amount)}...");
            return true;

        }

        public override bool ValidatePaymentDetails()
        {
            if (CardNumber.Length != 16 || CVV.Length != 3)
            {
                Console.WriteLine("Invalid Card Details.");
                return false;
            }
            return true;
        }

        public override string GenerateReceipt()
        {
            return $"Transaction ID: {TransactionId}\nPayment Type: {PaymentType}\nMasked Card: **** **** **** {CardNumber.Substring(12)}\nAmount: {ProcessingFee}";
        }

        public bool ProcessRefund(decimal amount)
        {
            Console.WriteLine($"Processing refund of {amount} to credit card...");
            return true;
        }
    }

    // PayPal Payment Class
    class PayPalPayment : PaymentMethod
    {
        private string Email;
        private string AuthToken;

        public PayPalPayment(string email, string authToken)
        {
            PaymentType = "PayPal";
            ProcessingFee = 3.0m;
            Email = email;
            AuthToken = authToken;
            TransactionId = Guid.NewGuid().ToString();
        }

        public override bool ProcessPayment(decimal amount)
        {
            if (!ValidatePaymentDetails())
            {
                return false;
            }
            Console.WriteLine($"Processing PayPal payment of {CalculateTotal(amount)}...");
            return true;
        }

        public override bool ValidatePaymentDetails()
        {
            if (!Email.Contains("@"))
            {
                Console.WriteLine("Invalid PayPal email.");
                return false;
            }
            return true;
        }

        public override string GenerateReceipt()
        {
            return $"Transaction ID: {TransactionId}\nPayment Type: {PaymentType}\nEmail: {Email}\nAmount: {ProcessingFee}";
        }

        public bool HandleDispute()
        {
            Console.WriteLine("Handling PayPal dispute...");
            return true;
        }
    }

    // Cryptocurrency Payment Class
    class CryptoCurrencyPayment : PaymentMethod
    {
        private string WalletAddress;
        private decimal ExchangeRate;

        public CryptoCurrencyPayment(string walletAddress, decimal exchangeRate)
        {
            PaymentType = "Cryptocurrency";
            ProcessingFee = 1.5m;
            WalletAddress = walletAddress;
            ExchangeRate = exchangeRate;
            TransactionId = Guid.NewGuid().ToString();
        }

        public override bool ProcessPayment(decimal amount)
        {
            if (!ValidatePaymentDetails())
            {
                return false;
            }
            decimal cryptoAmount = amount / ExchangeRate;
            Console.WriteLine($"Processing Crypto payment of {cryptoAmount} coins (equivalent to {CalculateTotal(amount)})...");
            return true;
        }

        public override bool ValidatePaymentDetails()
        {
            if (WalletAddress.Length < 26 || WalletAddress.Length > 35)
            {
                Console.WriteLine("Invalid Wallet Address.");
                return false;
            }
            return true;
        }

        public override string GenerateReceipt()
        {
            return $"Transaction ID: {TransactionId}\nPayment Type: {PaymentType}\nWallet: {WalletAddress}\nAmount: {ProcessingFee}";
        }
    }


}
