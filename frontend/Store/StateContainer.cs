namespace frontend.Store
{
    public class StateContainer
    {
        public Action? OnChange { get; set; }

        private void NotifyChanged()
        {
            OnChange?.Invoke();
        }

        //state management property
    }
}
