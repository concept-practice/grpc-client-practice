using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NAA.Client.Data;
using NAA.Client.Pages.Fleet.Common;
using NAA.Client.Pages.Fleet.ViewModels;

namespace NAA.Client.Pages.Fleet
{
    public class IndexModel : PageModel
    {
        private readonly IDataClient _dataClient;
        private readonly IAirplaneMapper _mapper;

        public IndexModel(IDataClient dataClient, IAirplaneMapper mapper)
        {
            _dataClient = dataClient;
            _mapper = mapper;
        }

        public async Task OnGetAsync()
        {
            var entities = await _dataClient.GetAllAirplanesAsync();

            AirplaneIndexViewModel = _mapper.Entity(entities);
        }

        [BindProperty] 
        public AirplaneIndexViewModel AirplaneIndexViewModel { get; set; }
    }
}
