using Bag_Tracer.Model;
using Bag_Tracer.View;
using Bag_Tracer.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.IO;
using System.Windows;

namespace Bag_Tracer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Constructors

        /// <summary>
        /// Constructor for application
        /// Sets up logging and other services as configured
        /// </summary>
        public App()
        {
            try
            {
                var serviceCollection = new ServiceCollection();
                ConfigureServices(serviceCollection);
                _serviceProvider = serviceCollection.BuildServiceProvider();

                Log.Information("Application starting up");

                if (!Directory.Exists(StaticGlobals.GetAppDirectory()))
                {
                    Directory.CreateDirectory(StaticGlobals.GetAppDirectory());
                    Log.Information("Created app directory");
                }

                // Ensure database exists
                using (DataContext context = new DataContext())
                {
                    context.Database.EnsureCreated();
                }
            }
            catch (Exception Ex)
            {
                Log.Error($"Error setting up application: {Ex.Message}");
                Log.Error($"Stack Trace: {Ex.StackTrace}");
                Log.Error($"Inner Exception: {Ex.InnerException}");
            }
        }

        #endregion

        #region Members

        private readonly ServiceProvider _serviceProvider;

        #endregion

        #region Methods

        /// <summary>
        /// Configures services for Dependency Injection, set logging level here
        /// </summary>
        /// <param name="services">IServiceCollection of Services</param>
        internal void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));
            services.AddDbContext<DataContext>();
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(Path.Combine(StaticGlobals.GetAppDirectory(), "BagTracer-{Date}.log"), fileSizeLimitBytes: 5242880, retainedFileCountLimit: 5)
                .MinimumLevel.Information()
                .CreateLogger();
        }

        /// <summary>
        /// Adds MainWindow to Dependency Injection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var MainWindow = _serviceProvider.GetService<MainWindow>();
            MainWindow.Show();
        }

        #endregion
    }
}
