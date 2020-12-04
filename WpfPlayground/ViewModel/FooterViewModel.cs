using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Microsoft.Toolkit.Mvvm.Messaging.Messages;

namespace WpfPlayground.ViewModel
{
    internal interface IWithTitleViewModel
    {
        string Title { get; set; }
    }

    internal sealed class FooterViewModel : ObservableRecipient, IRecipient<UpdateFooterMessage>, IWithTitleViewModel
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

    internal sealed class HeaderViewModel : ObservableRecipient, IRecipient<PropertyChangedMessage<bool>>
    {
        private string _title = "";

        public HeaderViewModel(IMessenger messenger)
            : base(messenger)
        {
            IsActive = true;
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value, true);
        }
        
        public void Receive(PropertyChangedMessage<bool> message)
        {
            if (message.Sender is IWithTitleViewModel withTitle && message.NewValue && message.PropertyName == nameof(IsActive))
            {
                Title = withTitle.Title;
            }
        }
    }
}