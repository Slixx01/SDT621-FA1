using SectionB_Q1_EmfuleniMunicipality;

class EmfuleniMunicipality
{
    public static void Main(string[] args)
    {
        UtilityManager utilityManager = new UtilityManager();
        List<Resident> residents = new List<Resident>();

        Console.WriteLine("=== Welcom to Emfuleni Municipality Service Desk ===");

        Console.Write("How many residents do you want to register? ");
        int totalResidents = int.Parse(Console.ReadLine());

        for (int i = 0; i < totalResidents; i++)
        {
            Console.WriteLine($"--- Resident {i + 1} ---");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Account Number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Monthly Utility usage (kWh or liters): ");
            double montlyUsage = double.Parse(Console.ReadLine());

            Resident resident = new Resident(name, address, accountNumber, montlyUsage);
            residents.Add(resident);
        }


        Console.Write("How many service request do you want to log? ");
        int numServiceRequests = int.Parse(Console.ReadLine());

        for (int i = 0; i < numServiceRequests; i++)
        {
            Console.Write($"Select resident by number (1 to {residents.Count}): ");
            int indexResident = int.Parse(Console.ReadLine());
            Resident selectedResident = residents[indexResident - 1];

            Console.Write("Request Type (e.g , Water Outage, Burst Pipe): ");
            string requestType = Console.ReadLine();

            Console.Write("Priority Level (1-5): ");
            int priorityLevel = int.Parse(Console.ReadLine());

            Console.Write("Severity Level (1-10): ");
            int severityLevel = int.Parse(Console.ReadLine());

            Console.Write("Estimated Resolution Hours: ");
            double resolutionTime = double.Parse(Console.ReadLine());

            ServiceRequest request = new ServiceRequest(selectedResident, requestType, priorityLevel, severityLevel, resolutionTime);
            utilityManager.AddRequest(request);
        }


        utilityManager.DisplayQueue();
       

        while (utilityManager.GetPendingCount() > 0)
        {
            Console.WriteLine("Select a number: ");
            int selectedNum = int.Parse(Console.ReadLine());
            utilityManager.ProcessRequest(selectedNum);
            utilityManager.DisplayQueue(); 
        }

        utilityManager.DisplaySummary(); 


    }
}