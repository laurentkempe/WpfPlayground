using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace WpfPlayground.ViewModel
{
    internal sealed class FooterViewModel : ObservableRecipient, IRecipient<UpdateFooterMessage>
    {
        private string _title = "Original text";

        public FooterViewModel(IMessenger messenger)
            : base(messenger)
        {
            IsActive = true;
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public void Receive(UpdateFooterMessage message)
        {
            Title = message.Title;
        }
    }
}