using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCity.Services
{
    class NavigationService : INavigationService
    {
        private Dictionary<Type, ViewModelBase> viewModels = new Dictionary<Type, ViewModelBase>();

        public void Navigate<T>()
        {
            Messenger.Default.Send(viewModels[typeof(T)]);
        }

        public void Register<T>(ViewModelBase viewmodel)
        {
            viewModels.Add(typeof(T), viewmodel);
        }

        public void Navigate(Type type)
        {
            Messenger.Default.Send(viewModels[type]);
        }
    }
}
