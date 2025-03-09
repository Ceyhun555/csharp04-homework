using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Tasks.Notifications
{
    public abstract class NotificationSender
    {
        public int Priority { get; set; }
        public bool DeliveryStatus { get; protected set; }
        public int RetryCount { get; protected set; }

        public abstract void Send(string recipient, string message);
        protected abstract bool ValidateContent(string message);
        public abstract bool GetDeliveryStatus();

        protected void LogNotification(string recipient, string message)
        {
            Console.WriteLine($"Logging: Sent to {recipient} - Message: {message}");
        }
    }

    // Email Notification
    public class EmailNotification : NotificationSender
    {
        public override void Send(string recipient, string message)
        {
            if (!ValidateContent(message))
            {
                Console.WriteLine("Invalid email content.");
                return;
            }

            Console.WriteLine($"Sending Email to {recipient}: {message}");
            DeliveryStatus = true;
            LogNotification(recipient, message);
        }

        protected override bool ValidateContent(string message)
        {
            return true;
        }

        public override bool GetDeliveryStatus()
        {
            return DeliveryStatus;
        }
    }

    // SMS Notification
    public class SMSNotification : NotificationSender
    {
        public override void Send(string recipient, string message)
        {
            if (!ValidateContent(message))
            {
                Console.WriteLine("SMS message exceeds character limit.");
                return;
            }

            Console.WriteLine($"Sending SMS to {recipient}: {message}");
            DeliveryStatus = true;
            LogNotification(recipient, message);
        }

        protected override bool ValidateContent(string message)
        {
            return message.Length <= 160;
        }

        public override bool GetDeliveryStatus()
        {
            return DeliveryStatus;
        }
    }

    // Push Notification
    public class PushNotification : NotificationSender
    {


        public void QueueNotification(string recipient, string message)
        {

        }

        public override void Send(string recipient, string message)
        {
            if (!ValidateContent(message))
            {
                Console.WriteLine("Invalid push notification content.");
                return;
            }

            Console.WriteLine($"Sending Push Notification to {recipient}: {message}");
            DeliveryStatus = true;
            LogNotification(recipient, message);
        }

        protected override bool ValidateContent(string message)
        {
            return message.Length <= 1024;
        }

        public override bool GetDeliveryStatus()
        {
            return DeliveryStatus;
        }
    }

}
