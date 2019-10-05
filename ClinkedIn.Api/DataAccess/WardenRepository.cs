using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn.Api.Models;

namespace ClinkedIn.Api.DataAccess
{
    public class WardenRepository
    {
        static List<Warden> _wardens = new List<Warden>
        {
            new Warden
            {
                Id = new Guid ("300000000000-0000-0000-000000000001"),
                FirstName = "Ian",
                LastName = "Campbell"
            },

            new Warden
            {
                Id = new Guid ("300000000000-0000-0000-000000000002"),
                FirstName = "Max",
                LastName = "Meyers"
            },

            new Warden
            {
                Id = new Guid ("300000000000-0000-0000-000000000003"),
                FirstName = "Turner",
                LastName = "Peterson"
            }
        };
    }
}
