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
        public ActionResult<Friends> GetByFriendsId(Guid Friendsid)
            return repo.Get(Friendsid)
    }
    [HttpGet("{Friends Id}")]
public ActionResult<Friends> GetByFriendsId(Guid Friendsid)
    {
        throw new NotImplementedException();
    }
}