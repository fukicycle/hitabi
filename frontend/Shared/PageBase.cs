using frontend.Store;
using Microsoft.AspNetCore.Components;

namespace frontend.Shared
{
    public abstract class PageBase : ComponentBase, IDisposable
    {
        private StateContainer _stateContainer = null!;
        [Inject]
        public StateContainer StateContainer
        {
            get { return _stateContainer; }
            set
            {
                _stateContainer = value;
                if (_stateContainer is not null)
                {
                    StateContainer.OnChange += StateHasChanged;
                }
            }
        }

        protected async Task RunWithErrorHandling(Func<Task> function, bool hasLoading = false)
        {
            try
            {
                if (hasLoading)
                {
                    StateContainer.IsLoading = true;
                }
                await function();
            }
            catch (Exception ex)
            {
                StateContainer.Message = ex.Message;
            }
            StateContainer.IsLoading = false;
        }


        public void Dispose()
        {
            StateContainer.OnChange -= StateHasChanged;
        }
    }
}
