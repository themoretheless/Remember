using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;


namespace Remember.Core
{
    public class Bootstrap
    {

        public static IServiceCollection Configure()
        {

            IServiceCollection services = new ServiceCollection();

            services.AddLogging(configure =>
            {
                configure.SetMinimumLevel(LogLevel.Trace);

                var log = new LoggerConfiguration()
                   .WriteTo.ColoredConsole()
                   .WriteTo.File(@"C:\TMP\2_serilog.txt")
                   .CreateLogger();


                configure.AddSerilog(log);
            });


            return services;
        }
    }
}
