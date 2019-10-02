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
        public Guid FacilityId { get; set; }
        public decimal Budget { get; set; }
        public List<Inmate> Friends { get; set; }
        public List<Inmate> Enemies { get; set; }
        public List<Service> Services { get; set; }
        public List<Interest> Interests { get; set; }
    }
}
