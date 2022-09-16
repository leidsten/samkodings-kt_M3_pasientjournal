namespace PasientRegistration
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // REGISTRERE PASIENT MED NAVN OG SYKDOM

            //STEP 1:
            //********* REGISTRERE EN PAS - U/KLASSE - SE PAS I CONSOLE ETTER REG ******
            var pasientListe = new List<Pasient>();
            var Frank = new Pasient("Frank", "Analkløe");
            pasientListe.Add(Frank);

            while(true)
            {
                Console.WriteLine("Please enter a name for the patient: ");
                var patient = Console.ReadLine();
                Console.WriteLine("Please enter illness: ");
                var illness = Console.ReadLine();
                var newPerson = new Pasient(patient, illness);
                pasientListe.Add(newPerson);

                //newPerson.PrintInfo();
                // Console.WriteLine("Hei, " + patient + " Det var synd å høre at du sliter med: " + illness);

                foreach (var pasient in pasientListe)
                {
                    Console.WriteLine(pasient.PrintInfo());
                }


            }
            
            //Console.ReloaodoooooooKooley

            //STEP 2:
            //********** REG FLER PAS - BRUKE KLASSE  **********








            //STEP 2.1 - SE PAS.LISTE I CONSOLE - PUBLIC INFO I KLASSE





            //STEP 2.2 - SE PAS.LISTE I CONSOLE - PRIVATE NAME I KLASSE
        }
    }
}