using System;

namespace _02.Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int treatedPatients = 0; int untreatedPatients = 0; int doctors = 7;
            for (int i = 1; i <= period; i++)
            {
                if (i % 3 == 0)
                {
                    if (untreatedPatients > treatedPatients)
                    {
                        doctors++;
                    }
                }
                int patients = int.Parse(Console.ReadLine());
                if (patients <= doctors)
                {
                    treatedPatients += patients;
                }
                else
                {
                    untreatedPatients += patients - doctors;
                    treatedPatients += doctors;
                }
                
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
