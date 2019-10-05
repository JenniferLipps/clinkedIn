using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClinkedIn.Api.DataAccess;
using ClinkedIn.Api.Models;

namespace ClinkedIn.Api.Controllers
{
    [Route("api/inmate")]
    [ApiController]
    public class InmateController : ControllerBase
    {
        [HttpGet"{interestId}"]
        public ActionResult<Inmate> GetByInterest(Guid interestId)
        {
            var repo = new InmateRepository();
            return repo.GetInterest();

        }
    }
}