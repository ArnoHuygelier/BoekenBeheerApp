using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoekenBeheerApp.Stores;

namespace BoekenBeheerApp.ViewModel
{
    public class vmMain : vmBase
    {
        private readonly NavigationStore _navigationStore;

        public vmBase CurrentViewModel => _navigationStore.CurrentViewModel;

        public vmMain(NavigationStore navigationStore)
        {
            //CurrentViewModel = new vmData();
            _navigationStore = navigationStore;
            //deze methode OnCurrentViewModelChanged in store
            _navigationStore.CurrentViewModelChanged += _navigationStore_CurrentViewModelChanged;
        }

        private void _navigationStore_CurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
