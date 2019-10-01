using ClinkedIn.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Api.DataAccess
{
    public class ServiceRepository
    {
        static List<Service> _services = new List<Service>
        {
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000001"),
                Name = "Unauthorized physical contact",
                Price = 1.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000002"),
                Name = "Using abusive or obscene language",
                Price = 2.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000003"),
                Name = "Malingering, feigning illness",
                Price = 3.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000004"),
                Name = "Use the telephone for abuses other than criminal activity which do not circumvent mail monitoring",
                Price = 4.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000005"),
                Name = "Use the mail to commit a prohibited act",
                Price = 5.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000006"),
                Name = "Circulate a petition",
                Price = 6.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000007"),
                Name = "Participate in gang-related activities",
                Price = 7.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000008"),
                Name = "Circulating a petition",
                Price = 8.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000009"),
                Name = "Conduct a business/investment transaction",
                Price = 9.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000010"),
                Name = "Fraudulent or deceptive completion of a skills test (e.g., cheating on a GED)",
                Price = 10.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000011"),
                Name = "Possession, manufacture, introduction, or loss of a non-hazardous tool, equipment, supplies, or other non-hazardous contraband",
                Price = 11.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000012"),
                Name = "Destroying, altering, or damaging government property, or the property of another person, having a value of $100.00 or less",
                Price = 12.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000013"),
                Name = "Unauthorized contacts with the public",
                Price = 13.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000014"),
                Name = "Possession of gambling paraphernalia",
                Price = 14.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000015"),
                Name = "Preparing or conducting a gambling pool",
                Price = 15.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000016"),
                Name = "Gambling",
                Price = 16.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000016"),
                Name = "Using any equipment or machinery contrary to instructions or posted safety standards",
                Price = 16.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000017"),
                Name = "Using any equipment or machinery without staff authorization",
                Price = 17.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000018"),
                Name = "Being in an unauthorized area without staff authorization",
                Price = 18.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000019"),
                Name = "Counterfeiting, forging, or unauthorized reproduction of any document, article of identification, money, security, or official paper",
                Price = 19.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000020"),
                Name = "Lying or providing a false statement to a staff member",
                Price = 20.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000021"),
                Name = "Misuse of authorized medication",
                Price = 21.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000022"),
                Name = "Indecent exposure",
                Price = 22.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000015"),
                Name = "",
                Price = 15.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000015"),
                Name = "",
                Price = 15.00m,
            },
        };
    }
}
