using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace WpfPlayground.ViewModel
{
    public sealed class MainWindowViewModel : ObservableObject
    {
        public string Title { get; } = "Wpf Playground";
    }
}