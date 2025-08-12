using Connect4.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Connect4.Components.Pages
{
    public partial class Home : ComponentBase
    {
        [Inject]
        private AuthUserStateService AuthUserStateService { get; set; } = null!;
        [Inject]
        private NavigationManager Navigation { get; set; } = null!;
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                var styleName = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "particleStyle");
                if (string.IsNullOrWhiteSpace(styleName))
                {
                    styleName = "PallaxParticles";
                }
                await JSRuntime.InvokeVoidAsync(styleName);
            }
        }
    }
}
