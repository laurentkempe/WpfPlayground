using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace WpfPlayground.ViewModel
{
    internal sealed class MainWindowViewModel : ObservableObject
    {
        private readonly IMessenger _messenger;
        private string _title = "Wpf Playground";
        private double _progressValue;
        private IAsyncRelayCommand? _updateTitleCommand;
        private string _text = string.Empty;

        public MainWindowViewModel(IMessenger messenger)
        {
            _messenger = messenger;
        }
        
        public IAsyncRelayCommand UpdateTitleCommand => _updateTitleCommand ??= new AsyncRelayCommand(UpdateTitleAsync);
        
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public double ProgressValue
        {
            get => _progressValue;
            set => SetProperty(ref _progressValue, value);
        }

        private async Task UpdateTitleAsync()
        {
            for (var i = 1; i <= 10; i++)
            {
                await Task.Delay(100);
                ProgressValue = i * 10;
            }

            Title = Text;
            Text = "";

            _messenger.Send(new UpdateFooterMessage(Title));

            await Task.Delay(200);
            ProgressValue = 0;
        }
    }
}