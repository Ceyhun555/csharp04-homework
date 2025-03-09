using AbstractClass.Tasks.Documents;
using AbstractClass.Tasks.Notifications;

namespace AbstractClass.Tasks
{
    // Main Program to Test the Implementation

    class Program
    {
        static void Main()
        {
            Document pdfDoc = new PDFDocument("Report.pdf", "Alice", DateTime.Now);
            Document wordDoc = new WordDocument("Proposal.docx", "Bob", DateTime.Now);
            Document spreadsheetDoc = new SpreadsheetDocument("Data.xlsx", "Charlie", DateTime.Now);
            Document invalidDoc = new PDFDocument("FakeFile.doc", "Unknown", DateTime.Now);

            DocumentProcessor processor = new DocumentProcessor();

            processor.ProcessDocument(pdfDoc);
            processor.ProcessDocument(wordDoc);
            processor.ProcessDocument(spreadsheetDoc);
            processor.ProcessDocument(invalidDoc); // This should fail validation
            Console.WriteLine();







            PaymentsMethod.PaymentMethod creditCardPayment = new PaymentsMethod.CreditCardPayment("1234567812345678", "12/26", "123");
            creditCardPayment.ProcessPayment(100);
            Console.WriteLine(creditCardPayment.GenerateReceipt());

            PaymentsMethod.PaymentMethod paypalPayment = new PaymentsMethod.PayPalPayment("user@example.com", "securetoken");
            paypalPayment.ProcessPayment(200);
            Console.WriteLine(paypalPayment.GenerateReceipt());

            PaymentsMethod.PaymentMethod cryptoPayment = new PaymentsMethod.CryptoCurrencyPayment("1A2b3C4d5E6F7g8H9i0J", 50000);
            cryptoPayment.ProcessPayment(500);
            Console.WriteLine(cryptoPayment.GenerateReceipt());
            Console.WriteLine();








            Notifications.NotificationSender email = new EmailNotification();
            email.Send("user@example.com", "Hello, this is an email notification!");

            NotificationSender sms = new SMSNotification();
            sms.Send("1234567890", "Hello, this is an SMS!");

            NotificationSender push = new PushNotification();
            push.Send("Device123", "Hello, this is a push notification!");



        }
        
    }
   
}

