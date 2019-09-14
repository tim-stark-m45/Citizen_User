using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using MyCity.Messages;
using MyCity.Models;
using MyCity.Services;
using System.Collections.ObjectModel;

namespace MyCity.ViewModels
{
    class SecurityPVModel : ViewModelBase
    {
        private ObservableCollection<Security> security;
        public ObservableCollection<Security> Security { get => security; set => Set(ref security, value); }

        private readonly INavigationService navigationService;
        private readonly IMessageService messageService;
        private readonly AppDbContext db;

        public SecurityPVModel(
            INavigationService navigationService,
            IMessageService messageService,
            AppDbContext db)
        {
            this.navigationService = navigationService;
            this.messageService = messageService;
            this.db = db;

            Security = new ObservableCollection<Security>(db.Securities);
        }

        private RelayCommand backCommand;
        public RelayCommand BackCommand
        {
            get => backCommand ?? (backCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<SecurityViewModel>();
              }
              ));
        }

        private RelayCommand refreshCommand;
        public RelayCommand RefreshCommand
        {
            get => refreshCommand ?? (refreshCommand = new RelayCommand(
              () =>
              {
                  Security = new ObservableCollection<Security>(db.Securities);
              }
              ));
        }
    }
}
