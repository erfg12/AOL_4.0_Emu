using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Sentry;

namespace aol.Forms
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Init the Sentry SDK
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://252eec992e92928a924efd1ceb106bff@o4508936968732672.ingest.us.sentry.io/4509066562568192";
                o.Debug = false; // Enable for debugging
                o.TracesSampleRate = 1.0;
            }))
            {
                AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
                {
                    SentrySdk.CaptureException(args.ExceptionObject as Exception);
                };

                Application.EnableVisualStyles();
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.SetCompatibleTextRenderingDefault(false);

                // Configure DI
                var services = new ServiceCollection();
                ConfigureServices(services);
                ServiceProvider = services.BuildServiceProvider();

                // Configure WinForms to throw exceptions so Sentry can capture them.
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);

                Application.Run(ServiceProvider.GetRequiredService<MainForm>());
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // register services here
            // Ex: services.AddSingleton<Server>();

            // Register MainForm
            services.AddTransient<MainForm>();
        }
    }
}
