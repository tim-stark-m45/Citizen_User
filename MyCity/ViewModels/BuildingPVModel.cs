using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using MyCity.Messages;
using MyCity.Models;
using MyCity.Services;
using System.Collections.ObjectModel;

namespace MyCity.ViewModels
{
    class BuildingPVModel : ViewModelBase
    {
        private ObservableCollection<Building> building;
        public ObservableCollection<Building> Building { get => building; set => Set(ref building, value); }

        private readonly INavigationService navigationService;
        private readonly IMessageService messageService;
        private readonly AppDbContext db;

        public BuildingPVModel(
            INavigationService navigationService,
            IMessageService messageService,
            AppDbContext db)
        {
            this.navigationService = navigationService;
            this.messageService = messageService;
            this.db = db;

            Building = new ObservableCollection<Building>(db.Buildings);
        }

        private RelayCommand backCommand;
        public RelayCommand BackCommand
        {
            get => backCommand ?? (backCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<BuildingViewModel>();
              }
              ));
        }

        private RelayCommand refreshCommand;
        public RelayCommand RefreshCommand
        {
            get => refreshCommand ?? (refreshCommand = new RelayCommand(
              () =>
              {
                  Building = new ObservableCollection<Building>(db.Buildings);
              }
              ));
        }
    }
}
