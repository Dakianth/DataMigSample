using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataMigSample.EF6;
using DataMigSample.EF6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace DataMigSample.Controllers
{
    [Produces("application/json")]
    [Route("api/Clients")]
    public class ClientsController : Controller
    {
        private readonly MigDataContext context;

        public ClientsController(MigDataContext context)
        {
            this.context = context;
        }

        //// GET: api/Clients
        //[HttpGet]
        //public IEnumerable<Client> Get()
        //{
        //    return context.Clients.ToList();
        //}

        // GET: api/Clients
        [HttpGet]
        public IActionResult GetJson()
        {
            string jsonResult = context.Database.SqlQuery<string>("select id, name, code from Client for json path").FirstOrDefault();
            return Content(jsonResult, "application/json", Encoding.UTF8);
        }

        // GET: api/Clients/5
        [HttpGet("{id}", Name = "Get")]
        public Client Get(Guid id)
        {
            return context.Clients.Find(id);
        }

        // POST: api/Clients
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Clients/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}