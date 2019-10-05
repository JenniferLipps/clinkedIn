using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Api.Models
{
    public class Facility
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid WardenId { get; set; }
        public List<Guid> InmateId { get; set; }
    }
}