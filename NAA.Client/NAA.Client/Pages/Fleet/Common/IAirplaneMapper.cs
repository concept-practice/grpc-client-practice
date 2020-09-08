using NAA.Client.Pages.Fleet.ViewModels;
using NAA.FleetService.Protos;

namespace NAA.Client.Pages.Fleet.Common
{
    public interface IAirplaneMapper
    {
        AirplaneIndexViewModel Entity(AllAirplanesResponse response);

        AirplaneViewModel Entity(AirplaneResponse response);
    }
}
