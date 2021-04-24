using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Root.DTO;
using Root.Services;

namespace Root.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _service;

        public SendMessageController(ISendMessageService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage([FromBody] MessageModel model)
        {
            var response = await _service.SendTheMessage(model);
            return Ok(response);
        }
    }
}