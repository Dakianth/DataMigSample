using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataMigSample.EF6;
using DataMigSample.EF6.Models;
using Microsoft.AspNetCore.Mvc;

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
            var s = new List<string>
            {
                "Margaretta Greeno",
                "Arletha Helgren",
                "Darren Hirsh",
                "Joleen Lambrecht",
                "Elba Dansie",
                "Chelsey Mielke",
                "Erick Horne",
                "Perla Pillsbury",
                "Obdulia Maillet",
                "Christie Wurst",
                "Lashon Mcdaniel",
                "Lavera Mckay",
                "Kathern Blind",
                "Lidia Severson",
                "Bethany Mcnabb",
                "Lamont Hildebrant",
                "Raphael Elgin",
                "Tyesha Tiano",
                "Maryjane Torsiello",
                "Racquel Doles",
                "Columbus Cadet",
                "Crysta Knopf",
                "Evette Rath",
                "Ricki Onken",
                "Grisel Beers",
                "Wyatt Giorgio",
                "Vivian Mcmurtrie",
                "Aleisha Valliere",
                "Regina Koepp",
                "Teodora Rattler",
                "Yuette Miser",
                "Clement Sweitzer",
                "Carolina Mook",
                "Ramona Human",
                "Christen Lamberton",
                "Melynda Hallberg",
                "Ervin Ching",
                "Stacee Bandy",
                "Evelin Haddox",
                "Lurline Belair",
                "Chanel Farrington",
                "Desmond Bella",
                "Corene Chavis",
                "Alesia Cullum",
                "Kesha Lunday",
                "Shin Dyer",
                "Alyson Henshaw",
                "Emma Chichester",
                "Yolonda Purves",
                "Kellee Bugarin",
                "Lisa Romero",
                "Nettie Qualey",
                "Valrie Casella",
                "Jeanetta Ebling",
                "Ferne Borman",
                "Nick Prevatte",
                "Madlyn Flaugher",
                "Jill Goodloe",
                "Jacqueline Lyon",
                "Dominque Hamdan",
                "Vernita Amico",
                "Marry Vanpelt",
                "Dale Hedge",
                "Zelma Carwell",
                "Alvina Fluitt",
                "Shaniqua Rivas",
                "Kanesha Desiderio",
                "Enriqueta Ziegler",
                "Rey Tadeo",
                "Shoshana Spell",
                "Wendie Neighbors",
                "Skye Claude",
                "Johnny Platz",
                "Agustina Axtell",
                "Indira Isenberg",
                "David Lipsky",
                "Norberto Gilles",
                "Wilda Hungate",
                "Winfred Craner",
                "Sherise Feeney",
                "Rosetta Warnock",
                "Leeann Lastrapes",
                "Cristy Shake",
                "Ebonie Panzer",
                "Johanna Mccree",
                "Buena Oland",
                "Violet Rowen",
                "Nam Zepp",
                "Blondell Deborde",
                "Luise Bontrager",
                "Darrel Carnevale",
                "Ivey Mccowan",
                "Rhiannon Matta",
                "Audrey Parrales",
                "Gerald Cruze",
                "Dionna Singley",
                "Temeka Regalado",
                "Estelle Desrosier",
                "Lizette Clevenger",
                "Alene Gonsalves"
            };

            context.Clients.AddRange(s.Select((name, code) => new Client(name, code)));
            context.SaveChanges();
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