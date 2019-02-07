using LiteDB;
using Microsoft.Extensions.Logging;
using Remember.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace Remember.Wpf
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        private RelayCommand addCommand;
        public RelayCommand AddCommand
            => addCommand ?? (addCommand = new RelayCommand(obj =>
                {
                    Console.Write("command test");
                }));

        private readonly ILogger _logger;
        private readonly LiteRepository<CardModel> _cardRepository;

        public MainWindow(ILogger<MainWindow> logger, LiteRepository<CardModel> cardRepository)
        {
            this.DataContext = this;
            InitializeComponent();
            _logger = logger;
            _cardRepository = cardRepository;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        private void ButtonTest_Click(object sender, RoutedEventArgs e)
        {
            _logger.LogInformation("test");

            var card = new CardModel
            {
                //Id = ObjectId.NewObjectId().,
                Origin = "Cat3",
                Transcription = "Cat2",
                Translation = "Кошка2",
                BDoc = new BsonDocument(new Dictionary<string, BsonValue>
                {
                    ["1"] = new BsonValue(123),
                    ["2"] = new BsonValue("321"),
                })
            };


            var catcard = _cardRepository.CreateItem(card);


            var result = _cardRepository.ReadAllItems();

            foreach (var item in result)
            {
                _logger.LogInformation(item.Translation);
                _logger.LogInformation(item.BDoc["2"].AsString);
            }


            DbHelper db = new DbHelper();
            db.Create();

            //var res = db.Find();
        }


        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => canExecute == null || canExecute(parameter);

        public void Execute(object parameter) => execute(parameter);
    }


}
