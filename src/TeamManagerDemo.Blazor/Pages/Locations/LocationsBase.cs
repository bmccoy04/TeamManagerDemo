using Microsoft.AspNetCore.Components;
using TeamManagerDemo.Core.Entities;
using TeamManagerDemo.Infrastructure.Data;
using System.Linq;
using System.Collections.Generic;

namespace TeamManagerDemo.Blazor.Pages.Locations
{
    public class LocationsBase : ComponentBase
    {

        protected Location[] locations;

        protected Location Location { get; set; } = new Location();

        protected List<State> States { get; set; } = new List<State>();

        [Inject]
        public AppDbContext appDbContext { get; set; }
        public bool ShowModal { get; set; }

        protected override void OnInitialized()
        {
            locations = appDbContext.Set<Location>()
                .Where(s => !s.Deleted)
                .OrderBy(x => x.City).ToArray();

            States = appDbContext.Set<State>()
                 .Where(s => !s.Deleted)
                 .OrderBy(x => x.Name).ToList();
        }
        protected void HandleValidSubmit()
        {
            ToggleAddModal();
            // State.CreateDate = DateTime.Now;

            // appDbContext.Add(this.State);
            // await appDbContext.SaveChangesAsync();
            // navigationManager.NavigateTo("states");
        }

        protected void DeleteLocation(int id)
        {

        }

        protected void ToggleAddModal()
        {
            ShowModal = !ShowModal;
        }

    }
}