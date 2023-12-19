using Microsoft.AspNetCore.Mvc;

namespace ClientGrpc.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ClientGrpcController : ControllerBase
	{
		private readonly ClientGrpcService _clientGrpcService;

		public ClientGrpcController(ClientGrpcService clientGrpcService)
		{
			_clientGrpcService = clientGrpcService;
		}

		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] string? name)
		{
			return Ok(_clientGrpcService.HelloWord(name));
;		}
	}
}
