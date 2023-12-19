using Grpc.Core;
using ServidorGrpc.Protos;

namespace ServidorGrpc.Services
{
	public class ServidorGrpcService : ServidorService.ServidorServiceBase
	{
		public override async Task<Protos.HelloReply> HelloWord(Protos.HelloRequest request, ServerCallContext context)
		{
			return new Protos.HelloReply() { Message = request.Name };
		}
	}
}
