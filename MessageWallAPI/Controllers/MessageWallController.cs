using MessageWallAPI.MyModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageWallAPI.Controllers
{
    [Route("api/[controller]")] //the *api* name can be changed to anything e.g myapi[controller]
    [ApiController]
    public class MessageWallController : ControllerBase
    {
        private ILogger<MessageWallController> _logger;

        public MessageWallController(ILogger<MessageWallController> logger)
        {
            _logger = logger;
        }

        // GET: api/<MessageWallController>
        //GET: api/MesssageWall?message=Text&id=4 // to pass in below parameters
        [HttpGet]
        public IEnumerable<string> Get(string message = "")
        {
           
            List<string> output = new List<string>
            {
                "Hello world",
                "How are you",
            };
            //string.IsNullOrWhiteSpace(message) == false
            if (message!="")
            {
                output.Add(message);
            }

            return output;
           // return new string[] { "value1", "value2" };
        }

        // GET api/<MessageWallController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MessageWallController>
        [HttpPost]
        public void Post([FromBody] MessageModel message)
        {
            _logger.LogInformation("Our message was {Message}", message.Message);
        }

        // PUT api/<MessageWallController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MessageWallController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
