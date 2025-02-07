using System.Xml.Schema;

namespace TasksForMastering.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Book book = new Book();
            book.DisplayAccessibleMembers();

            Magazine magazine = new Magazine();
            magazine.AccessLibraryItem(book);


            Console.WriteLine();


            //Task2
            Mobile mobile = new Mobile
            {
                Manufacturer = "Apple",
                Model = "Iphone 14"
            };
            Console.WriteLine("Mobile Details");
            mobile.Displaydetails();

            Tablet tablet = new Tablet
            {
                Manufacturer = "Samnsung",
                HasStylus = true
            };
            Console.WriteLine("\nTablet Details");
            tablet.DisplayTabletDetails();

            Console.WriteLine();



            //Task3
            //Notification notification = new Notification();
            //notification.Send();

            
            //EmailNotification emailNotification = new EmailNotification();
            //emailNotification.Send();

            //SMSNotification smsNotification = new SMSNotification();
            //smsNotification.Send();

            Notification[] notifications = new Notification[] {
                new Notification(),
                new EmailNotification(),
                new SMSNotification()
                };

            foreach (Notification item in notifications)
            {
                item.Send();
            }
            




            // Task4
            Console.WriteLine("Apartment 1:");
            Apartment apt1 = new Apartment("Residential", 5);

            Console.WriteLine("\nApartment 2:");
            Apartment apt2 = new Apartment("Commercial", 10);

            Console.WriteLine();




            // Task5
            Parrot parrot = new Parrot();

            parrot.Move(); 
            parrot.Fly();  
            parrot.Talk(); 

            Console.WriteLine();


            //Task6
            Doctor doctor = new Doctor
            {
                Name = "Dr. Alice",
                Age = 40,
                Specialty = "Cardiology"
            };
            Console.WriteLine("Doctor Details:");
            doctor.GetDoctorDetails();

            Console.WriteLine();

            
            Engineer engineer = new Engineer
            {
                Name = "Engineer Bob",
                Age = 35,
                Field = "Software Engineering"
            };
            Console.WriteLine("Engineer Details:");
            engineer.GetEngineerDetails();

            Console.WriteLine();


            Person[] people = new Person[]
            {
                new Person("Person", 30),
                new Doctor("Dr Alice", 40, "Cardiology"),
                new Engineer("Bob", 35, "Software Engineering")
            };
            foreach(Person person in people)
            {
                person.GetInfo();
            }



            // Task7
            Laptop laptop = new Laptop();
            laptop.DisplayLaptopResolution();

            // Using the Desktop class with inheritance
            Desktop desktop = new Desktop();
            desktop.DisplayDesktopResolution();
        }
    }





}