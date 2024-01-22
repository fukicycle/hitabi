using frontend.Store;
using Microsoft.AspNetCore.Components;

namespace frontend.View.Components.Dialog
{
    public partial class Dialog
    {
        [Inject]
        public StateContainer StateContainer { get; set; } = null!;
        [Parameter]
        public string Title { get; set; } = null!;
        [Parameter]
        public string BodyMsg { get; set; } = null!;

        private void CloseButtonOnClick()
        {
            StateContainer.Message = null;
        }
    }
}
