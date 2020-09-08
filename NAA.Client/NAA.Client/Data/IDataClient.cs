using System;
using System.Threading.Tasks;
using NAA.FleetService.Protos;

namespace NAA.Client.Data
{
    public interface IDataClient
    {
        Task<AllAirplanesResponse> GetAllAirplanesAsync();

        Task<AirplaneResponse> GetAirplaneByIdAsync(Guid id);

        Task<AirplaneResponse> AddAirplaneAsync(AddAirplaneRequest request);

        Task DeleteAirplaneAsync(DeleteAirplaneRequest request);
    }
}
