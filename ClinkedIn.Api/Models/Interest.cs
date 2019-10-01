using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Api.Models
{
    public class Interest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }



        public Interest(string name)
        {
            Id = new Guid();
            Name = name;
        }
    }
}
