using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Api.Models
{
    public class Inmate
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime ReleaseDate { get; set; }        
        public decimal Budget { get; set; }
        public List<Guid> Friends { get; set; }
        public List<Guid> Enemies { get; set; }
        public List<Guid> Services { get; set; }
        public List<Guid> Interests { get; set; }
    }
}
