using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using MyCity.Messages;
using MyCity.Models;
using MyCity.Services;
using System.Collections.ObjectModel;

namespace MyCity.ViewModels
{
    class ImportantListViewModel : ViewModelBase
    {
        private ObservableCollection<Important> important;
        public ObservableCollection<Important> Important { get => important; set => Set(ref important, value); }

        private readonly INavigationService navigationService;
        private readonly IMessageService messageService;
        private readonly AppDbContext db;

        public ImportantListViewModel(
            INavigationService navigationService,
            IMessageService messageService,
            AppDbContext db)
        {
            this.navigationService = navigationService;
            this.messageService = messageService;
            this.db = db;

            Important = new ObservableCollection<Important>(db.Importants);
        }

        private RelayCommand<Important> openInfoCommand;
        public RelayCommand<Important> OpenInfoCommand
        {
            get => openInfoCommand ?? (openInfoCommand = new RelayCommand<Important>(
              param =>
              {
                  Messenger.Default.Send(new SendImportant { Data = param });
                  navigationService.Navigate<ImportantInfofViewModel>();
              }
              ));
        }

        private RelayCommand<Important> deleteCommand;
        public RelayCommand<Important> DeleteCommand
        {
            get => deleteCommand ?? (deleteCommand = new RelayCommand<Important>(
              param =>
              {
                  if (messageService.ShowYesNo("Are you sure?"))
                  {
                      db.Importants.Remove(param);
                      db.SaveChanges();
                      Important.Remove(param);
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
                  Important = new ObservableCollection<Important>(db.Importants);
              }
              ));
        }
    }
}
