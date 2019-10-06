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
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Inmate>> GetEnemiesByInmateId(Guid inmateId)
        {
            var repo = new InmateRepository();
            return repo.GetEnemiesByInmateId(inmateId);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Inmate>> GetAllInmates()
        {
            var repo = new InmateRepository();
            return repo.GetAll();
        }
    }
}