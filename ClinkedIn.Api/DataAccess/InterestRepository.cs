﻿using ClinkedIn.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Api.DataAccess
{
    public class InterestRepository
    {

        static List<Interest>_interests = new List<Interest>
        {
            new Interest

        {
                Id = new Guid("10000000 - 0000 - 0000 - 0000 - 000000000001"),
                Name = "Arson"
            },

            new Interest
            {
                Id = new Guid("10000000 - 0000 - 0000 - 0000 - 000000000002"),
                Name = "Pyromania"

            },

            new Interest
            {
                Id = new Guid("10000000 - 0000 - 0000 - 0000 - 000000000003"),
                Name = "Burglary"
                
            }
        };

     
       
    }

}
