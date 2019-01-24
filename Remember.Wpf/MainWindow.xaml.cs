using Microsoft.Extensions.Logging;
using System.Windows;

namespace Remember.Wpf
{
    public partial class MainWindow : Window
    {
        private readonly ILogger _logger;

        public MainWindow(ILogger<MainWindow> logger)
        {
            InitializeComponent();
            _logger = logger;
        }

        private void ButtonTest_Click(object sender, RoutedEventArgs e)
        {
            _logger.LogInformation("test");
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
