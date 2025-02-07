namespace Practice.Inheritance
{
    /// <summary>
    /// Public Access Modifiers.
    /// </summary>
    class Vehicle
    {
        public int Id { get; set; }

        public string Model { get; set; }



        public void Start()
        {
            Console.WriteLine("Engine Start: " + Model);

        }


    }

}


