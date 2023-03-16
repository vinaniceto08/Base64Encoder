using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Base64Encoder.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("[controller]")]
    public class Base64EncoderController : ControllerBase
    {
        private static bool _isEncodingInProgress = false;
        [HttpPost]     
        //public async Task<IActionResult> Encode(string text)
         public  ActionResult<string> Encode(string text)
        {
            var encodedString = Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
            return Ok(encodedString);

            //if (_isEncodingInProgress)
            //{
            //    return Conflict("Encoding is already in progress.");
            //}

            //_isEncodingInProgress = true;

            //string encodedText = Convert.ToBase64String(Encoding.UTF8.GetBytes(text));

            //foreach (char c in encodedText)
            //{
            //    Response.WriteAsync(c.ToString());

            //    int delay = new Random().Next(1000, 5000);

            //    Task.Delay(delay);
            //}

            //_isEncodingInProgress = false;

            //return Ok();
        }

        [HttpGet("cancel")]
        public IActionResult Cancel()
        {
            if (!_isEncodingInProgress)
            {
                return BadRequest("There is no encoding process to cancel.");
            }

            _isEncodingInProgress = false;
       

            return Ok("Encoding process cancelled.");
        }

    }
}
