using Microsoft.AspNetCore.Mvc;
using OpenAI.Api.Interfaces;
using OpenAI.Api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OpenAI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ModelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET api/<ModelsController>/5
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var ai = await _unitOfWork.AI.Get();
            
            return Ok(ai.Content[0].Text);
        }
    }
}
