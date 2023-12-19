using ClientGrpc.Protos;

namespace ClientGrpc
{
	public class ClientGrpcService
	{
		private readonly ServidorService.ServidorServiceClient _client;

		public ClientGrpcService(ServidorService.ServidorServiceClient client)
		{
			_client = client;
		}

		public async Task HelloWord(string name)
		{
			var result = _client.HelloWord(new HelloRequest { Name = name ?? "Hello word" });

		}
	}
}
