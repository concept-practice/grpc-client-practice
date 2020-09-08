using System;
using System.Linq;
using NAA.Client.Pages.Fleet.ViewModels;
using NAA.FleetService.Protos;

namespace NAA.Client.Pages.Fleet.Common
{
    public class AirplaneMapper : IAirplaneMapper
    {
        public AirplaneIndexViewModel Entity(AllAirplanesResponse response)
        {
            return new AirplaneIndexViewModel(response.Entities.Select(Entity));
        }

        public AirplaneViewModel Entity(AirplaneResponse response)
        {
            return new AirplaneViewModel(Guid.Parse(response.Id), response.Manufacturer, response.Model, response.Registration);
        }
    }
}
