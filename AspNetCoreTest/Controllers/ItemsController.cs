using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTest.Models;

namespace AspNetCoreTest.Controllers
{
    [Produces("application/json")]
    [Route("api/Items")]
    public class ItemsController : Controller
    {
        // GET api/items
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            var listItem = new List<Item>();
            for (var i = 0; i < 10; i++)
            {
                var objItem = new Item();
                objItem.ID = i + 1;
                objItem.Name = "item_"+ objItem.ID;

                listItem.Add(objItem);
            }
            return listItem;
        }

        // GET api/items/5
        [HttpGet("{id}")]
        public Item Get(int id)
        {
            var objItem = new Item();
            objItem.ID = id;
            objItem.Name = "item_" + objItem.ID;
            return objItem;
        }

        // GET api/items
        [HttpPost]
        public Item Post([FromBody]Item model)
        {
            var objItem = new Item();
            objItem.ID = model.ID;
            objItem.Name = model.Name;
            return objItem;
        }

        // PUT api/items/5
        [HttpPut("{id}")]
        public Item Put(int id, [FromBody]Item model)
        {
            var objItem = new Item();
            objItem.ID = id;
            objItem.Name = model.Name;
            return objItem;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public object Delete(int id)
        {
            object result = null; string message = string.Empty;
            result = new
            {
                message = id + " id Delete successfully."
            };
            return result;
        }

    }
}