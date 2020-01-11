using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TripTracker.BackService.Models;
using TripTracker.UI.Data;
using TripTracker.UI.Services;

namespace TripTracker.UI
{
    public class IndexModel : PageModel
    {
        private readonly IApiClient _Client;
        public IndexModel(IApiClient client)
        {
            _Client = client; ;
        }

        public IList<Trip> Trip { get;set; }

        public async Task OnGetAsync()
        {
            Trip = await _Client.GetTripsAsync();
        }
    }
}
