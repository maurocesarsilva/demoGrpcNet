using ClientGrpc.Protos;
using Grpc.Core.Interceptors;

namespace ClientGrpc
{
	public class ClientGrpcService : Interceptor
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
