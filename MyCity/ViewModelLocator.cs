using Autofac;
using Autofac.Configuration;
using GalaSoft.MvvmLight;
using Microsoft.Extensions.Configuration;
using System;
using System.Windows;
using MyCity.Services;
using MyCity.ViewModels;

namespace MyCity
{
    class ViewModelLocator
    {
        private MainWindowViewModel mainWindowViewModel;
        private ProblemsViewModel problemsViewModel;
        private InfrastructureViewModel infrastructureViewModel;
        private BuildingViewModel buildingViewModel;
        private GovernmentViewModel governmentViewModel;
        private HospitalViewModel hospitalViewModel;
        private IdeaViewModel ideaViewModel;
        private PublicTransportViewModel publicTransportViewModel;
        private RoadViewModel roadViewModel;
        private SecurityViewModel securityViewModel;
        private TradeAdvertisingViewModel tradeAdvertisingViewModel;
        private YardViewModel yardViewModel;
        private HelloViewModel helloViewModel;
        private ImportantListViewModel importantListViewModel;
        private ImportantInfofViewModel importantInfofViewModel;
        private NewsListViewModel newsListViewModel;
        private NewsInfoViewModel newsInfoViewModel;
        private BuildingPVModel buildingPVModel;
        private GovernmentPVModel governmentPVModel;
        private HospitalPVModel hospitalPVModel;
        private IdeaPVModel ideaPVModel;
        private InfrastructurePVModel infrastructurePVModel;
        private PublicTransportPVModel publicTransportPVModel;
        private RoadPVModel roadPVModel;
        private SecurityPVModel securityPVModel;
        private TradeAdvertisingPVModel tradeAdvertisingPVModel;
        private YardPVModel yardPVModel;


        private INavigationService navigationService;
        public static IContainer Container;

        public ViewModelLocator()
        {
            try
            {
                var config = new ConfigurationBuilder();
                config.AddJsonFile("autofac.json");
                var module = new ConfigurationModule(config.Build());
                var builder = new ContainerBuilder();
                builder.RegisterModule(module);
                Container = builder.Build();

                navigationService = Container.Resolve<INavigationService>();
                mainWindowViewModel = Container.Resolve<MainWindowViewModel>();
                problemsViewModel = Container.Resolve<ProblemsViewModel>();
                infrastructureViewModel = Container.Resolve<InfrastructureViewModel>();
                buildingViewModel = Container.Resolve<BuildingViewModel>();
                governmentViewModel = Container.Resolve<GovernmentViewModel>();
                hospitalViewModel = Container.Resolve<HospitalViewModel>();
                ideaViewModel = Container.Resolve<IdeaViewModel>();
                publicTransportViewModel = Container.Resolve<PublicTransportViewModel>();
                roadViewModel = Container.Resolve<RoadViewModel>();
                securityViewModel = Container.Resolve<SecurityViewModel>();
                tradeAdvertisingViewModel = Container.Resolve<TradeAdvertisingViewModel>();
                yardViewModel = Container.Resolve<YardViewModel>();
                helloViewModel = Container.Resolve<HelloViewModel>();
                importantListViewModel = Container.Resolve<ImportantListViewModel>();
                importantInfofViewModel = Container.Resolve<ImportantInfofViewModel>();
                newsListViewModel = Container.Resolve<NewsListViewModel>();
                newsInfoViewModel = Container.Resolve<NewsInfoViewModel>();
                buildingPVModel = Container.Resolve<BuildingPVModel>();
                governmentPVModel = Container.Resolve<GovernmentPVModel>();
                hospitalPVModel = Container.Resolve<HospitalPVModel>();
                ideaPVModel = Container.Resolve<IdeaPVModel>();
                infrastructurePVModel = Container.Resolve<InfrastructurePVModel>();
                publicTransportPVModel = Container.Resolve<PublicTransportPVModel>();
                roadPVModel = Container.Resolve<RoadPVModel>();
                securityPVModel = Container.Resolve<SecurityPVModel>();
                tradeAdvertisingPVModel = Container.Resolve<TradeAdvertisingPVModel>();
                yardPVModel = Container.Resolve<YardPVModel>();

                navigationService.Register<ProblemsViewModel>(problemsViewModel);
                navigationService.Register<InfrastructureViewModel>(infrastructureViewModel);
                navigationService.Register<BuildingViewModel>(buildingViewModel);
                navigationService.Register<GovernmentViewModel>(governmentViewModel);
                navigationService.Register<HospitalViewModel>(hospitalViewModel);
                navigationService.Register<IdeaViewModel>(ideaViewModel);
                navigationService.Register<PublicTransportViewModel>(publicTransportViewModel);
                navigationService.Register<RoadViewModel>(roadViewModel);
                navigationService.Register<SecurityViewModel>(securityViewModel);
                navigationService.Register<TradeAdvertisingViewModel>(tradeAdvertisingViewModel);
                navigationService.Register<YardViewModel>(yardViewModel);
                navigationService.Register<HelloViewModel>(helloViewModel);
                navigationService.Register<ImportantListViewModel>(importantListViewModel);
                navigationService.Register<ImportantInfofViewModel>(importantInfofViewModel);
                navigationService.Register<NewsListViewModel>(newsListViewModel);
                navigationService.Register<NewsInfoViewModel>(newsInfoViewModel);
                navigationService.Register<BuildingPVModel>(buildingPVModel);
                navigationService.Register<GovernmentPVModel>(governmentPVModel);
                navigationService.Register<HospitalPVModel>(hospitalPVModel);
                navigationService.Register<IdeaPVModel>(ideaPVModel);
                navigationService.Register<InfrastructurePVModel>(infrastructurePVModel);
                navigationService.Register<PublicTransportPVModel>(publicTransportPVModel);
                navigationService.Register<RoadPVModel>(roadPVModel);
                navigationService.Register<SecurityPVModel>(securityPVModel);
                navigationService.Register<TradeAdvertisingPVModel>(tradeAdvertisingPVModel);
                navigationService.Register<YardPVModel>(yardPVModel);

                navigationService.Navigate<HelloViewModel>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ViewModelBase GetMainWindowViewModel()
        {
            return mainWindowViewModel;
        }
    }
}
