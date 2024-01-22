using frontend.Store;
using Microsoft.AspNetCore.Components;

namespace frontend.Shared
{
    public partial class MainLayout : IDisposable
    {
        [Inject]
        public StateContainer StateContainer { get; set; } = null!;


        protected override void OnInitialized()
        {
            StateContainer.OnChange += StateHasChanged;
        }
        public void Dispose()
        {
            StateContainer.OnChange -= StateHasChanged;
        }
    }
}
