using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn.Api.Models;

namespace ClinkedIn.Api.DataAccess
{
    public class InmateRepository
    {
        static List<Inmate> _inmates = new List<Inmate>
        {
            new Inmate
            {
                Id = new Guid ("00000000-0000-0000-0000-000000000001"),
                FirstName = "Joe",
                LastName = "Jailbird",
                ReleaseDate = new DateTime (2020, 4, 20),                
                Budget = 25.00M,
                Friends = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000002"),
                    new Guid ("00000000-0000-0000-0000-000000000004"),
                    new Guid ("00000000-0000-0000-0000-000000000005"),
                },
                Enemies = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000003"),
                    new Guid ("00000000-0000-0000-0000-000000000009"),
                    new Guid ("00000000-0000-0000-0000-000000000012"),
                },
                Services = new List<Guid>()
                {
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000009"),
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000013"),
                },
                Interests = new List<Guid>()
                {
                    new Guid ("10000000 - 0000 - 0000 - 000003")
                }
            },
            new Inmate
            {
                Id = new Guid ("00000000-0000-0000-0000-000000000002"),
                FirstName = "DB",
                LastName = "Cooper",
                ReleaseDate = new DateTime (2071, 11, 24),                
                Budget = 25.00M,
                Friends = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000003"),
                    new Guid ("00000000-0000-0000-0000-000000000009"),
                    new Guid ("00000000-0000-0000-0000-000000000012"),
                },
                Enemies = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000005"),
                    new Guid ("00000000-0000-0000-0000-000000000006"),
                    new Guid ("00000000-0000-0000-0000-000000000011"),
                },
                Services = new List<Guid>()
                {
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000010"),
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000017"),
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000028"),
                },
                Interests = new List<Guid>()
                {
                    new Guid ("10000000 - 0000 - 0000 - 000003")
                }
            },
            new Inmate
            {
                Id = new Guid ("00000000-0000-0000-0000-000000000003"),
                FirstName = "Ted",
                LastName = "Kaczynski",
                ReleaseDate = new DateTime (2099, 1, 31),
                Budget = 25.00M,
                Friends = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000001"),
                    new Guid ("00000000-0000-0000-0000-000000000002"),
                    new Guid ("00000000-0000-0000-0000-000000000010"),
                },
                Enemies = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000003"),
                    new Guid ("00000000-0000-0000-0000-000000000007"),
                    new Guid ("00000000-0000-0000-0000-000000000011"),
                },
                Services = new List<Guid>()
                {
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000005"),
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000036"),               
                },
                Interests = new List<Guid>()
                {
                    new Guid ("10000000 - 0000 - 0000 - 000003"),
                    new Guid ("10000000 - 0000 - 0000 - 000001")
                }
            },
            new Inmate
            {
                Id = new Guid ("00000000-0000-0000-0000-000000000004"),
                FirstName = "Rod",
                LastName = "Blagojevich",
                ReleaseDate = new DateTime (2026, 3, 15),
                Budget = 25.00M,
                Friends = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000003"),
                    new Guid ("00000000-0000-0000-0000-000000000005"),
                    new Guid ("00000000-0000-0000-0000-000000000014"),
                },
                Enemies = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000002"),
                    new Guid ("00000000-0000-0000-0000-000000000008"),
                    new Guid ("00000000-0000-0000-0000-000000000015"),
                },
                Services = new List<Guid>()
                {
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000013"),
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000031"),
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000038"),
                },
                Interests = new List<Guid>()
                {
                    new Guid ("10000000 - 0000 - 0000 - 000003"),                    
                }
            },
            new Inmate
            {
                Id = new Guid ("00000000-0000-0000-0000-000000000005"),
                FirstName = "Suge",
                LastName = "Knight",
                ReleaseDate = new DateTime (2046, 12, 15),
                Budget = 25.00M,
                Friends = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000005"),
                    new Guid ("00000000-0000-0000-0000-000000000008"),
                    new Guid ("00000000-0000-0000-0000-000000000015"),
                },
                Enemies = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000003"),
                    new Guid ("00000000-0000-0000-0000-000000000004"),
                    new Guid ("00000000-0000-0000-0000-000000000013"),
                },
                Services = new List<Guid>()
                {
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000037"),
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000043"),
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000050"),
                },
                Interests = new List<Guid>()
                {
                    new Guid ("10000000 - 0000 - 0000 - 000003"),
                }
            },
            new Inmate
            {
                Id = new Guid ("00000000-0000-0000-0000-000000000006"),
                FirstName = "Brendan",
                LastName = "Dassey",
                ReleaseDate = new DateTime (2048, 5, 30),
                Budget = 25.00M,
                Friends = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000001"),
                    new Guid ("00000000-0000-0000-0000-000000000003"),
                    new Guid ("00000000-0000-0000-0000-000000000006"),
                },
                Enemies = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000008"),
                    new Guid ("00000000-0000-0000-0000-000000000010"),
                    new Guid ("00000000-0000-0000-0000-000000000014"),
                },
                Services = new List<Guid>()
                {
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000020"),
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000028"),
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000050"),
                },
                Interests = new List<Guid>()
                {
                    new Guid ("10000000 - 0000 - 0000 - 000003"),
                }
            },
            new Inmate
            {
                Id = new Guid ("00000000-0000-0000-0000-000000000007"),
                FirstName = "Richard",
                LastName = "Kuklinski",
                ReleaseDate = new DateTime (2045, 3, 5),
                Budget = 25.00M,
                Friends = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000005"),
                    new Guid ("00000000-0000-0000-0000-000000000008"),
                    new Guid ("00000000-0000-0000-0000-000000000012"),
                },
                Enemies = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000001"),
                    new Guid ("00000000-0000-0000-0000-000000000006"),
                    new Guid ("00000000-0000-0000-0000-000000000012"),
                },
                Services = new List<Guid>()
                {
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000033"),
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000036"),
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000050"),
                },
                Interests = new List<Guid>()
                {
                    new Guid ("10000000 - 0000 - 0000 - 000003"),
                }
            },
            new Inmate
            {
                Id = new Guid ("00000000-0000-0000-0000-000000000008"),
                FirstName = "Dominick",
                LastName = "Pizzonia",
                ReleaseDate = new DateTime (2020, 2, 28),
                Budget = 25.00M,
                Friends = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000002"),
                    new Guid ("00000000-0000-0000-0000-000000000008"),
                    new Guid ("00000000-0000-0000-0000-000000000011"),
                },
                Enemies = new List<Guid>()
                {
                    new Guid ("00000000-0000-0000-0000-000000000003"),
                    new Guid ("00000000-0000-0000-0000-000000000004"),
                    new Guid ("00000000-0000-0000-0000-000000000005"),
                },
                Services = new List<Guid>()
                {
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000015"),
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000016"),
                    new Guid ("20000000 - 0000 - 0000 - 0000 - 000000000050"),
                },
                Interests = new List<Guid>()
                {
                    new Guid ("10000000 - 0000 - 0000 - 000003"),
                }
        };
    }
}
