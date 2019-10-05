using ClinkedIn.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Api.DataAccess
{
    public class InmatesRepository
    {
        static List<Inmate> _inmates = new List<Inmate>();

        public List<Inmate> GetEnemiesByInmateId(Guid inmateId)
        {
            List<Inmate> _inmateEnemies = new List<Inmate>();

            var selectedInmate = _inmates.First(inmate => inmate.Id == inmateId);

            foreach (var enemy in selectedInmate.Enemies)
            {
             // find enemy from _inmates and add to _inmateEnemies if we correct the Inmate class to use Guid
             // if inmate keeps the 
            }
        }
    }
}
