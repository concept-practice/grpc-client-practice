using System;

namespace NAA.Client.Pages.Fleet.ViewModels
{
    public class AirplaneViewModel
    {
        public Guid Id { get; }

        public string Manufacturer { get; }

        public string Model { get; }

        public string Registration { get; }

        public AirplaneViewModel(Guid id, string manufacturer, string model, string registration)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
            Registration = registration;
        }
    }
}
