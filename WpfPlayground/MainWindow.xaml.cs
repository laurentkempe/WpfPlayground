using WpfPlayground.ViewModel;

namespace WpfPlayground
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    internal sealed partial class MainWindow
    {
        public MainWindowViewModel MainWindowViewModel { get; }
        public HeaderViewModel HeaderViewModel { get; }
        public FooterViewModel FooterViewModel { get; }

        public MainWindow(MainWindowViewModel mainWindowViewModel, HeaderViewModel headerViewModel, FooterViewModel footerViewModel)
        {
            MainWindowViewModel = mainWindowViewModel;
            HeaderViewModel = headerViewModel;
            FooterViewModel = footerViewModel;

            InitializeComponent();
        }
    }
}