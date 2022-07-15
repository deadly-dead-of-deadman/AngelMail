using System.Collections.ObjectModel;
using Avalonia.Interactivity;
using Core.Data.Models;
using GUI.Views;
using Core.Data.Services;
using ReactiveUI;

namespace GUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        
        ViewModelBase content;
        private Database DB;

        public MainWindowViewModel(Database db)
        {
            this.DB = db;
            Content = List = new MailListViewModel(db.GetMessages());
        }

        public ViewModelBase Content
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public MailListViewModel List { get; }

        public void SignOut()
        {
            var vm = new AuthorizationViewModel();
            Content = vm;
        }

        public void SignIn()
        {
            Content = new MailListViewModel(DB.GetMessages());
        }

        public ObservableCollection<Message> Messages { get; set; }
    }
}