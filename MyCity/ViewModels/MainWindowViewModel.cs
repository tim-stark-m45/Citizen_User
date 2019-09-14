using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using MyCity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCity.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase currentPage;
        public ViewModelBase CurrentPage { get => currentPage; set => Set(ref currentPage, value); }

        private readonly INavigationService navigation;

        public MainWindowViewModel(INavigationService navigation)
        {
            this.navigation = navigation;
            Messenger.Default.Register<ViewModelBase>(this, viewModel => CurrentPage = viewModel);
        }

        private RelayCommand<Type> navigateCommand;
        public RelayCommand<Type> NavigateCommand
        {
            get => navigateCommand ?? (navigateCommand = new RelayCommand<Type>(
              param =>
              {
                  navigation.Navigate(param);
              }
              ));
        }

        private RelayCommand problemsCommand;
        public RelayCommand ProblemsCommand
        {
            get => problemsCommand ?? (problemsCommand = new RelayCommand(
              () =>
              {
                  navigation.Navigate<ProblemsViewModel>();
              }
              ));
        }

        private RelayCommand importantCommand;
        public RelayCommand ImportantCommand
        {
            get => importantCommand ?? (importantCommand = new RelayCommand(
              () =>
              {
                  navigation.Navigate<ImportantListViewModel>();
              }
              ));
        }

        private RelayCommand ideaCommand;
        public RelayCommand IdeaCommand
        {
            get => ideaCommand ?? (ideaCommand = new RelayCommand(
              () =>
              {
                  navigation.Navigate<IdeaViewModel>();
              }
              ));
        }

        private RelayCommand newsCommand;
        public RelayCommand NewsCommand
        {
            get => newsCommand ?? (newsCommand = new RelayCommand(
              () =>
              {
                  navigation.Navigate<NewsListViewModel>();
              }
              ));
        }
    }
}
