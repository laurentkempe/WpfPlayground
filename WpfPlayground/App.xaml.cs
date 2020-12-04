using System;
using System.Threading;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Toolkit.Mvvm.Messaging;
using WpfPlayground.ViewModel;

namespace WpfPlayground
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private readonly IHost _host;

        public App()
        {
            _host = new HostBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<IMessenger, StrongReferenceMessenger>();
                    services.AddSingleton<MainWindowViewModel>();
                    services.AddSingleton<HeaderViewModel>();
                    services.AddSingleton<FooterViewModel>();
                    services.AddSingleton<MainWindow>();
                })
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            Thread.CurrentThread.Name = "UI";

            base.OnStartup(e);

            await _host.StartAsync();

            var mainWindow = _host.Services.GetService<MainWindow>();
            mainWindow?.Show();
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            using (_host)
            {
                await _host.StopAsync();
            }

            base.OnExit(e);
        }
    }
}