using PequenosEncantos.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PequenosEncantos.Core.Entities
{
    public class JobCriation
    {
        public JobCriation(string jobTitle, string jobDescription, decimal paymentExpectation)
        {
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            PaymentExpectation = paymentExpectation;
        }

        public string JobTitle { get; private set; }
        public string JobDescription { get; private set; }
        public decimal? PaymentExpectation { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public ProjectStatusEnum Status { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }

    }
}
