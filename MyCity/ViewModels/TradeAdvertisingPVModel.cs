using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using MyCity.Messages;
using MyCity.Models;
using MyCity.Services;
using System.Collections.ObjectModel;

namespace MyCity.ViewModels
{
    class TradeAdvertisingPVModel : ViewModelBase
    {
        private ObservableCollection<Trade_Advertising> trade_Advertising;
        public ObservableCollection<Trade_Advertising> Trade_Advertising { get => trade_Advertising; set => Set(ref trade_Advertising, value); }

        private readonly INavigationService navigationService;
        private readonly IMessageService messageService;
        private readonly AppDbContext db;

        public TradeAdvertisingPVModel(
            INavigationService navigationService,
            IMessageService messageService,
            AppDbContext db)
        {
            this.navigationService = navigationService;
            this.messageService = messageService;
            this.db = db;

            Trade_Advertising = new ObservableCollection<Trade_Advertising>(db.Trade_Advertisings);
        }

        private RelayCommand backCommand;
        public RelayCommand BackCommand
        {
            get => backCommand ?? (backCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<TradeAdvertisingViewModel>();
              }
              ));
        }

        private RelayCommand refreshCommand;
        public RelayCommand RefreshCommand
        {
            get => refreshCommand ?? (refreshCommand = new RelayCommand(
              () =>
              {
                  Trade_Advertising = new ObservableCollection<Trade_Advertising>(db.Trade_Advertisings);
              }
              ));
        }
    }
}
