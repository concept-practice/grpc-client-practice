using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using NAA.FleetService.Protos;

namespace NAA.Client.Data
{
    public class DataClient : IDataClient
    {
        private readonly AirplaneService.AirplaneServiceClient _client;

        public DataClient(GrpcChannel channel)
        {
            _client = new AirplaneService.AirplaneServiceClient(channel);
        }

        public async Task<AllAirplanesResponse> GetAllAirplanesAsync()
        {
            return await _client.AllAirplanesAsync(new AllAirplanesRequest());
        }

        public async Task<AirplaneResponse> GetAirplaneByIdAsync(Guid id)
        {
            return await _client.GetAirplaneByIdAsync(new GetAirplaneByIdRequest { Id = id.ToString() });
        }

        public async Task<AirplaneResponse> AddAirplaneAsync(AddAirplaneRequest request)
        {
            return await _client.AddAirplaneAsync(request);
        }

        public async Task DeleteAirplaneAsync(DeleteAirplaneRequest request)
        {
            await _client.DeleteAirplaneAsync(request);
        }
    }
}
