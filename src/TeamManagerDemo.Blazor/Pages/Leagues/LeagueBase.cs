using System;
using System.Linq;
using Microsoft.AspNetCore.Components;
using TeamManagerDemo.Core.Entities;
using TeamManagerDemo.Infrastructure.Data;

namespace TeamManagerDemo.Blazor.Pages.Leagues
{
    public class LeagueBase : ComponentBase
    {
        [Inject]
        public AppDbContext appDbContext { get; set; }
        
        protected League[] leagues;

        protected bool ShowModal { get; set; } = false;

        protected override void OnInitialized()
        {
            leagues = appDbContext.Set<League>()
                .Where(s => !s.Deleted)
                .OrderBy(x => x.Name).ToArray();
        }

        protected void DeleteLeague(int id)
        {
            var state = appDbContext.Set<League>().FirstOrDefault(x => x.Id == id);

            if (state == null) return;
            state.Deleted = true;
            state.ModifyDate = DateTime.Now;
            appDbContext.SaveChanges();
            leagues = appDbContext.Set<League>().Where(s => !s.Deleted).OrderBy(x => x.Name).ToArray();
        }

        protected void ToggleAddModal()
        {
            ShowModal = !ShowModal;
        }
    }
}