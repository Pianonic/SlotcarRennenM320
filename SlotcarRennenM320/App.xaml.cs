using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SlotcarRennenM320.ViewModels;
using SlotcarRennenM320.ViewModels.SlotcarRennenM320.ViewMoldes;
using SlotcarRennenM320.Views;
using System.IO;

namespace SlotcarRennenM320
{
    public partial class App : System.Windows.Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        public static IConfiguration Configuration { get; private set; }

        public App()
        {
            var configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddUserSecrets<App>()
               .Build();

            Configuration = configuration;

            var serviceCollection = new ServiceCollection();

            // Register Window and Views
            serviceCollection.AddSingleton<MainWindow>();
            serviceCollection.AddSingleton<GameView>();
            serviceCollection.AddSingleton<MainMenuView>();
            serviceCollection.AddSingleton<SplashScreen>();


            // Register ViewModels
            serviceCollection.AddSingleton<MainWindowViewModel>();
            serviceCollection.AddSingleton<GameViewModel>();
            serviceCollection.AddSingleton<SplashScreenViewModel>();
            serviceCollection.AddTransient<MainMenuViewModel>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        protected override async void OnStartup(System.Windows.StartupEventArgs e)
        {
            base.OnStartup(e);

            var splashScreen = ServiceProvider.GetRequiredService<SplashScreen>();
            splashScreen.Show();

            await Task.Delay(3000);

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();

            splashScreen.Close();
        }
    }
}
