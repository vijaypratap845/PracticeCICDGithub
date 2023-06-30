using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PracticeCICDGithub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// This method is used to get values. 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetValues()
        {
            return Ok();
        }

        /// <summary>
        /// This method is used to post values data.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetData()
        {
            return Ok();
        }
    }
}
