namespace Practice.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employe employe = new Employe();
            employe.Name = "name";
            employe.Surname = "surname";
            employe.Age = 23;
            employe.Position = "Operator";
            employe.Salary = 700;

            employe.GetDetails();

            Employe employe2 = new Employe("Ceyhun", "Ismayilov", 23, "Developer", 1000);
            employe2.GetDetails();






            //Inheritance with access modifiers.

            Car car = new Car();
            car.Model = "Audi";
            car.Start();


            //Private access modifiers.

            SavingAccount savingAccount = new SavingAccount();
            savingAccount.AddInterest(1000);



            //Protected acces modifiers.

            Dog dog = new Dog();
            dog.Feed();

        }


       


    }

}


