using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using MyCity.Models;
using MyCity.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace MyCity.ViewModels
{
    class ProblemsViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;
        private readonly IMessageService messageService;
        private readonly AppDbContext db;

        public ProblemsViewModel(
            INavigationService navigationService,
            IMessageService messageService,
            AppDbContext db)
        {
            this.navigationService = navigationService;
            this.messageService = messageService;
            this.db = db;
        }

        private RelayCommand infrastructureCommand;
        public RelayCommand InfrastructureCommand
        {
            get => infrastructureCommand ?? (infrastructureCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<InfrastructureViewModel>();
              }
              ));
        }

        private RelayCommand buildingCommand;
        public RelayCommand BuildingCommand
        {
            get => buildingCommand ?? (buildingCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<BuildingViewModel>();
              }
              ));
        }

        private RelayCommand governmentCommand;
        public RelayCommand GovernmentCommand
        {
            get => governmentCommand ?? (governmentCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<GovernmentViewModel>();
              }
              ));
        }

        private RelayCommand hospitalCommand;
        public RelayCommand HospitalCommand
        {
            get => hospitalCommand ?? (hospitalCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<HospitalViewModel>();
              }
              ));
        }

        private RelayCommand transportCommand;
        public RelayCommand TransportCommand
        {
            get => transportCommand ?? (transportCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<PublicTransportViewModel>();
              }
              ));
        }

        private RelayCommand roadCommand;
        public RelayCommand RoadCommand
        {
            get => roadCommand ?? (roadCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<RoadViewModel>();
              }
              ));
        }

        private RelayCommand securityCommand;
        public RelayCommand SecurityCommand
        {
            get => securityCommand ?? (securityCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<SecurityViewModel>();
              }
              ));
        }

        private RelayCommand tradeCommand;
        public RelayCommand TradeCommand
        {
            get => tradeCommand ?? (tradeCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<TradeAdvertisingViewModel>();
              }
              ));
        }

        private RelayCommand yardCommand;
        public RelayCommand YardCommand
        {
            get => yardCommand ?? (yardCommand = new RelayCommand(
              () =>
              {
                  navigationService.Navigate<YardViewModel>();
              }
              ));
        }
    }
}
