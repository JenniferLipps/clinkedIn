using ClinkedIn.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Api.DataAccess
{
    public class FacilityRepository
    {
        static List<Facility> _facilities = new List<Facility>
        {
            new Facility
            {
                Id = new Guid ("40000000-0000-0000-0000-000000000001"),
                Name = "Alcatraz",
                WardenId = new Guid ("30000000-0000-0000-0000-000000000001"),
                InmateId = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000001"),
                    new Guid ("00000000-0000-0000-0000-000000000002"),
                    new Guid ("00000000-0000-0000-0000-000000000003"),
                    new Guid ("00000000-0000-0000-0000-000000000004"),
                    new Guid ("00000000-0000-0000-0000-000000000005"),
                }
            },
            new Facility
            {
                Id = new Guid("40000000-0000-0000-0000-000000000002"),
                Name = "Black Dolphin",
                WardenId = new Guid("30000000-0000-0000-0000-000000000002"),
                InmateId = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000006"),
                    new Guid ("00000000-0000-0000-0000-000000000007"),
                    new Guid ("00000000-0000-0000-0000-000000000008"),
                    new Guid ("00000000-0000-0000-0000-000000000009"),
                    new Guid ("00000000-0000-0000-0000-000000000010"),
                }
            },
            new Facility
            {
                Id = new Guid("40000000-0000-0000-0000-000000000003"),
                Name = "San Pedro",
                WardenId = new Guid("30000000-0000-0000-0000-000000000003"),
                InmateId = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000011"),
                    new Guid ("00000000-0000-0000-0000-000000000012"),
                    new Guid ("00000000-0000-0000-0000-000000000013"),
                    new Guid ("00000000-0000-0000-0000-000000000014"),
                    new Guid ("00000000-0000-0000-0000-000000000015"),
                }
            },
        };
    }
}
