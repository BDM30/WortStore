using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using WortStore.Models;
using WortStore.Models.Entities;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WortStore.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
      private DataContext data;

      public ValuesController(DataContext d)
      {
        data = d;
      }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Word> Get()
        {
          return data.Words;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Word Get(int id)
        {
          return data.Words.First(x => x.WordID == id);
        }

        // POST api/values
        [HttpPost]
        public void Post(Word value)
        {
          data.Words.Add(value);
          data.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
