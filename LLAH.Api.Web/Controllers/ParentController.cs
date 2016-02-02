using LLAH.DataLayer;
using LLAH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace LLAH.Api.Web.Controllers
{
    [RoutePrefix("api/Parent")]
    public class ParentController : ApiController
    {
        public async Task<IHttpActionResult> GetParent()
        {
            return Ok(new ParentDataLayer().GetAll());
        }
    }
}
