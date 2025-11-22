using CodeChalengeForTest.Application.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CodeChalengeForTest.Peresentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
      
        private readonly IMediator _mediator;
        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("login")]
       
        public async Task<IActionResult> Login([FromBody] LoginUserCommand request)
        {
            var result = await _mediator.Send(request);

            if (!result.Success)
                return Unauthorized(new { result.Message });

            return Ok(result);
        }
    }
}
