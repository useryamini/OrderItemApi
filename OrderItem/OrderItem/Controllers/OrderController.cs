using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderItem.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace OrderItem.Controllers
{
    public class OrderController : Controller
    {
        public List<Cart> cart;

        [Route("api/[controller]/[action]")]
        [HttpPost]
        public IActionResult GetCart([FromBody] int MId)
        {
            using var client = new HttpClient();

            string uri = $"http://localhost:52101/id?id={MId}";

            var response = client.GetAsync(uri).Result;
            if (response != null)
            {

                var details = response.Content.ReadAsStringAsync().Result;
                Cart storing = JsonConvert.DeserializeObject<Cart>(details);


                cart = new List<Cart>()
                {
                    new Cart()
                    {
                       CartId = 1,
                       UserId = 1,
                       Id = storing.Id,
                       Name = storing.Name

                    }

                };

            }
            return Ok(cart);

        }
    }
}
