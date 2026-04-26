using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionB_Q1_EmfuleniMunicipality
{
    public class ServiceRequest
    {
        public Resident Resident { get; set; }
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }
        public int SeverityLevel { get; set; }
        public double ResolutionTime { get; set; }
        public double UrgencyScore { get; set; }
        public bool isResolved { get; set; }

        public ServiceRequest(Resident resident, string requestType, int priorityLevel, int severityLevel, double resolutionTime)
        {
            Resident = resident;
            RequestType = requestType;
            PriorityLevel = priorityLevel;
            SeverityLevel = severityLevel;
            ResolutionTime = resolutionTime;
            UrgencyScore = 0;
            isResolved = false;
            
        }
    }

    
}
