using Calendar.Infrastructure.Contracts;
using Calendar.Infrastructure.Entities;
using Microsoft.AspNetCore.Components;

namespace Calendar.Components.Pages
{
    public class NewTabBase : ComponentBase
    {
        [Inject]
        public IDateClient DateClient { get; set; }
        [Parameter]
        public int Year { get; set; }
        public List<NagerModel> holidays = new List<NagerModel>();
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                holidays = await DateClient.GetHolidays(Year, "RU");
                await InvokeAsync(() => StateHasChanged());
            }
        }
        protected override async Task OnInitializedAsync()
        {
            Year = (Year == 0) ? 2024 : Year;
            holidays = await DateClient.GetHolidays(Year, "RU");
            await InvokeAsync(() => StateHasChanged());
        }
    }
}
