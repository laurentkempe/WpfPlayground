using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace WpfPlayground.ViewModel
{
    public sealed class MainWindowViewModel : ObservableObject
    {
        private string _title = "Wpf Playground";

        public MainWindowViewModel()
        {
            UpdateTitleCommand = new RelayCommand<string>(UpdateTitle);
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ICommand UpdateTitleCommand { get; }

        private void UpdateTitle(string updatedTitle)
        {
            Title = updatedTitle;
        }
    }
}