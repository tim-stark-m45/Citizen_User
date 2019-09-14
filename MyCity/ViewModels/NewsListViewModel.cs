using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using MyCity.Messages;
using MyCity.Models;
using MyCity.Services;
using System.Collections.ObjectModel;

namespace MyCity.ViewModels
{
    class NewsListViewModel : ViewModelBase
    {
        private ObservableCollection<News> news;
        public ObservableCollection<News> News { get => news; set => Set(ref news, value); }

        private readonly INavigationService navigationService;
        private readonly IMessageService messageService;
        private readonly AppDbContext db;

        public NewsListViewModel(
            INavigationService navigationService,
            IMessageService messageService,
            AppDbContext db)
        {
            this.navigationService = navigationService;
            this.messageService = messageService;
            this.db = db;

            News = new ObservableCollection<News>(db.News);
        }

        private RelayCommand<News> openInfoCommand;
        public RelayCommand<News> OpenInfoCommand
        {
            get => openInfoCommand ?? (openInfoCommand = new RelayCommand<News>(
              param =>
              {
                  Messenger.Default.Send(new SendNews { Data = param });
                  navigationService.Navigate<NewsInfoViewModel>();
              }
              ));
        }

        private RelayCommand<News> deleteCommand;
        public RelayCommand<News> DeleteCommand
        {
            get => deleteCommand ?? (deleteCommand = new RelayCommand<News>(
              param =>
              {
                  if (messageService.ShowYesNo("Are you sure?"))
                  {
                      db.News.Remove(param);
                      db.SaveChanges();
                      News.Remove(param);
                  }
              }
              ));
        }

        private RelayCommand backCommand;
        public RelayCommand BackCommand
        {
            get => backCommand ?? (backCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<HelloViewModel>();
              }
              ));
        }

        private RelayCommand refreshCommand;
        public RelayCommand RefreshCommand
        {
            get => refreshCommand ?? (refreshCommand = new RelayCommand(
              () =>
              {
                  News = new ObservableCollection<News>(db.News);
              }
              ));
        }
    }
}
