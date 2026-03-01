using Microsoft.Extensions.DependencyInjection;
using Sentry;

namespace aol.Forms;
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
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);
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
        // register forms that use services
        services.AddTransient<MainForm>();
        services.AddTransient<SignOnForm>();
        services.AddTransient<SignupForm>();
        services.AddTransient<DialUpForm>();
        services.AddTransient<BuddyAddForm>();
        services.AddTransient<BuddyListForm>();
        services.AddTransient<FavoritePlacesForm>();
        services.AddTransient<ChatroomListForm>();
        services.AddTransient<ChatroomForm>();
        services.AddTransient<HomeMenuForm>();
        services.AddTransient<SettingsForm>();
        services.AddTransient<PreferencesForm>();
        services.AddTransient<MailboxForm>();
        services.AddTransient<MailReadForm>();
        services.AddTransient<MailWriteForm>();
        services.AddTransient<ChannelsListForm>();
        services.AddTransient<FavoritesAddForm>();

        // register services
        services.AddSingleton<AccountService>();
        services.AddSingleton<SqliteService>();
        services.AddSingleton<RestAPIService>();
        services.AddSingleton<ChatService>();
        services.AddSingleton<MailService>();
    }
}
