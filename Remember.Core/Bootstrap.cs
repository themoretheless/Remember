using LiteDB;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;


namespace Remember.Core
{
    public static class Bootstrap
    {
        public static IServiceCollection Configure()
        {
            var services = new ServiceCollection();

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


        public static void AddLiteDb(this IServiceCollection services)
        {
            services.AddTransient(o => new LiteRepository("MyData.db"));
            //services.AddTransient(o => new LiteDatabase("MyData.db"));
            services.AddTransient(typeof(LiteRepository<>));

            //services.Configure<LiteDatabase>(o => o = "MyData.db");
            //return services;
        }
    }
}
