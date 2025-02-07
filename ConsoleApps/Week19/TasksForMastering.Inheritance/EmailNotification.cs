namespace TasksForMastering.Inheritance
{
    public class EmailNotification : Notification
    {
        
        public override void Send()
        {
            Console.WriteLine("Sending email notification...");
        }
    }





}