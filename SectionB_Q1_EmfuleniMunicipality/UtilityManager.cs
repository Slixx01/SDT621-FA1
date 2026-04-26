

namespace SectionB_Q1_EmfuleniMunicipality
{
    public class UtilityManager
    {
        List<ServiceRequest> PendingRequest = new List<ServiceRequest>();
        List<ServiceRequest> ResolvedRequests = new List<ServiceRequest>();

        public int GetPendingCount()
        {
            return PendingRequest.Count;
        }

        public void AddRequest(ServiceRequest request)
        {
            CalculateUrgency(request);
            PendingRequest.Add(request);
        }

        public void CalculateUrgency(ServiceRequest request)
        {
            request.UrgencyScore = (request.PriorityLevel * request.SeverityLevel) / request.ResolutionTime * 10;
        }

        public void DisplayQueue()
        {
            Console.WriteLine("==== Pending Service Request ====");
            int count = 1;
            foreach (var serviceRequest in PendingRequest)
            {
                Console.WriteLine($"{count}. {serviceRequest.RequestType} - {serviceRequest.Resident.Name} - Uregency Score: {Math.Round(serviceRequest.UrgencyScore, 2)}");
                count++;
            }
        }

        public void ProcessRequest(int index)
        {
            ServiceRequest request = PendingRequest[index - 1];
            GenerateReport(request);
            ResolvedRequests.Add(request);
            PendingRequest.Remove(request);
            request.isResolved = true;
        }

        public void GenerateReport(ServiceRequest request)
        {
            Console.WriteLine("==== Service Report ====");
            Console.WriteLine($"Resident: {request.Resident.Name}");
            Console.WriteLine($"Service Type: {request.RequestType}");
            Console.WriteLine($"Urgency Score: {Math.Round(request.UrgencyScore, 2)}");
            Console.WriteLine($"Adjusted Resolution: {request.ResolutionTime} hours");
            Console.WriteLine($"Household impact score: {Math.Round(request.UrgencyScore, 2)}");
        }


        public void DisplaySummary()
        {
            Console.WriteLine("==== FINAL MUNICIPAL SUMMARY ====");

            foreach (var serviceRequest in ResolvedRequests)
            {
                Console.WriteLine($"Resident: {serviceRequest.Resident.Name}");
                Console.WriteLine($"Service Type: {serviceRequest.RequestType}");
                Console.WriteLine($"Urgency Score: {Math.Round(serviceRequest.UrgencyScore, 2)}");
            }

            ServiceRequest highest = ResolvedRequests[0];
            foreach (var serviceRequest in ResolvedRequests)
            {
                if (serviceRequest.UrgencyScore > highest.UrgencyScore)
                {
                    highest = serviceRequest;
                }
            }
            Console.WriteLine("Highest priority issue: ");
            Console.WriteLine($"Resident: {highest.Resident.Name}");
            Console.WriteLine($"Service Type: {highest.RequestType}");
            Console.WriteLine($"Urgency Score: {Math.Round(highest.UrgencyScore, 2)}");
            Console.WriteLine($"Adjusted Resolution: {highest.ResolutionTime} hours");
            Console.WriteLine($"Household impact score:  {Math.Round(highest.UrgencyScore, 2)}");

        }
    }
}
