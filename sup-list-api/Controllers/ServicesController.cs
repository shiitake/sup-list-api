using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sup_list_api.Controllers
{
    [Route("api/[controller]")]
    public class ServicesController : Controller
    {
        // GET: api/services
        [HttpGet]
        public string Get()
        {
            var fileName = "Data/services.json";
            var path = System.AppContext.BaseDirectory;
            var filePath = Path.Combine(path, fileName);
            //var sb = new StringBuilder();
            using (var sr = new StreamReader(new FileStream(filePath, FileMode.Open)))
            {
                var serviceData = JToken.ReadFrom(new JsonTextReader(sr));
                return serviceData.ToString();
            }
            
        }

        // GET api/services/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/services
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/services/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/services/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
