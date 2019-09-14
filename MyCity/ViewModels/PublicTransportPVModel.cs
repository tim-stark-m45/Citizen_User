using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using MyCity.Messages;
using MyCity.Models;
using MyCity.Services;
using System.Collections.ObjectModel;

namespace MyCity.ViewModels
{
    class PublicTransportPVModel : ViewModelBase
    {
        private ObservableCollection<PublicTransport> publicTransport;
        public ObservableCollection<PublicTransport> PublicTransport { get => publicTransport; set => Set(ref publicTransport, value); }

        private readonly INavigationService navigationService;
        private readonly IMessageService messageService;
        private readonly AppDbContext db;

        public PublicTransportPVModel(
            INavigationService navigationService,
            IMessageService messageService,
            AppDbContext db)
        {
            this.navigationService = navigationService;
            this.messageService = messageService;
            this.db = db;

            PublicTransport = new ObservableCollection<PublicTransport>(db.PublicTransports);
        }

        private RelayCommand backCommand;
        public RelayCommand BackCommand
        {
            get => backCommand ?? (backCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<PublicTransportViewModel>();
              }
              ));
        }

        private RelayCommand refreshCommand;
        public RelayCommand RefreshCommand
        {
            get => refreshCommand ?? (refreshCommand = new RelayCommand(
              () =>
              {
                  PublicTransport = new ObservableCollection<PublicTransport>(db.PublicTransports);
              }
              ));
        }
    }
}
