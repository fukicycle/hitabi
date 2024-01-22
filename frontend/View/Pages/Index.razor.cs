using frontend.Shared;

namespace frontend.View.Pages
{
    public partial class Index : PageBase
    {
        protected override async Task OnInitializedAsync()
        {
            await RunWithErrorHandling(async () =>
            {
                await Task.Delay(4000);
                //exception test
                throw new Exception("この例外はテストの例外です。");
            }, true);
        }
    }
}
