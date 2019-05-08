using Microsoft.Extensions.DependencyInjection;
using Remember.Comsole;
using Remember.Core;
using Remember.Wpf;
using System;
using System.Linq;
using System.Windows;

namespace Remember
{
    public partial class App : Application
    {
        public static IServiceProvider Provider { get; set; }

        private void Application_Startup(object sender, StartupEventArgs e)
        {

            if (e.Args.Contains("-debug"))
            {
                ConsoleHelpers.ShowWindow();
            }

            IServiceCollection serviceCollection = Bootstrap.Configure();
            serviceCollection.AddLiteDb();




            serviceCollection.AddTransient<MainWindow>();
            Provider = serviceCollection.BuildServiceProvider();

            var mw = Provider.GetService<MainWindow>();
            mw.Show();
        }
    }
}
