using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Api.Commands
{
    public class CreateInmateCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Budget { get; set; }
    }
}
