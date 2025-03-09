namespace Homework.Array.Tasks.HospitalMonitoringSystem
{
    class HospitalRecords
    {
        private Patient[] patients;
        private int count;

        public HospitalRecords(int size)
        {
            patients = new Patient[size];
            count = 0;
        }

        public void AddPatient(string name, int age, double temperature)
        {
            if (count < patients.Length)
            {
                patients[count++] = new Patient(name, age, temperature);
            }
        }

        public void IdentifyFeverCases()
        {
            Console.WriteLine("Patients with fever:");
            for (int i = 0; i < count; i++)
            {
                if (patients[i].Temperature > 37.5)
                {
                    Console.WriteLine($"{patients[i].Name}, Age: {patients[i].Age}, Temperature: {patients[i].Temperature}");
                }
            }
        }

        public void SortPatientsByTemperature()
        {
            for (int i = 0; i < patients.Length - 1; i++)
            {
                for (int j = i + 1; j < patients.Length; j++)
                {
                    if (patients[i].Temperature > patients[j].Temperature)
                    {
                        Patient temp = patients[i];
                        patients[i] = patients[j];
                        patients[j] = temp;
                    }
                }
            }
        }

        public Patient FindPatientByName(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (patients[i].Name == name)
                {
                    return patients[i];
                }
            }
            return null;
        }

        public void DisplayPatients()
        {
            Console.WriteLine("Patient Records:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{patients[i].Name}, Age: {patients[i].Age}, Temperature: {patients[i].Temperature}");
            }
        }
    }
}
