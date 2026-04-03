using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Threading;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TwoWheels.Presentation.ViewModels;
using TwoWheels.Presentation.Views;

namespace TwoWheels;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        var host = Host.CreateDefaultBuilder(e.Args)
            .ConfigureServices(services =>
            {
                services.AddSingleton<MainWindow>(p=> new MainWindow(){DataContext = p.GetRequiredService<MainViewModel>()});
                services.AddSingleton<MainViewModel>();
            })
            .Build();
        
        host.Services.GetRequiredService<MainWindow>().Show();
    }
    
    
    
}