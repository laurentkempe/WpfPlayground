using WpfPlayground.ViewModel;

namespace WpfPlayground
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    internal sealed partial class MainWindow
    {
        public MainWindowViewModel MainWindowViewModel { get; }
        public FooterViewModel FooterViewModel { get; }

        public MainWindow(MainWindowViewModel mainWindowViewModel, FooterViewModel footerViewModel)
        {
            MainWindowViewModel = mainWindowViewModel;
            FooterViewModel = footerViewModel;

            InitializeComponent();
        }
    }
}