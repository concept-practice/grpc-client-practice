using System.Collections.Generic;

namespace NAA.Client.Pages.Fleet.ViewModels
{
    public class AirplaneIndexViewModel
    {
        public IEnumerable<AirplaneViewModel> Entities { get; }

        public AirplaneIndexViewModel(IEnumerable<AirplaneViewModel> entities)
        {
            Entities = entities;
        }
    }
}
