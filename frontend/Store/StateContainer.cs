using System.ComponentModel;

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

        private bool _isLoading;

        [Description("画面全体の読み込みを管理するプロパティ")]
        public bool IsLoading
        {
            get { return _isLoading; }
            set
            {
                _isLoading = value;
                NotifyChanged();
            }
        }

        private string? _message;
        [Description("アプリ全体に通知したいメッセージを管理するプロパティ")]
        public string? Message
        {
            get { return _message; }
            set
            {
                _message = value;
                NotifyChanged();
            }
        }

    }
}
