using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoekenBeheerApp.ViewModel;

namespace BoekenBeheerApp.Stores
{
    public class NavigationStore
    {
        private vmBase _currentViewModel;
        //property die het huidige viewModel voorstelt
        public vmBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                //action uitvoeren zodat vmMain weet dat currentviewModel
                //aangepast is
                OnCurrentViewModelChanged();
            }
        }

        //action event maken -> action wordt uitgevoerd zodat ons vmMain
        //dan zal weten dat de OnPropertyChanged moet uigevoerd worden
        public event Action CurrentViewModelChanged;

        private void OnCurrentViewModelChanged()
        {
            //invoke -> methode aangeroepen en uitgevoerd -> 
            //deze methode moet aangepast worden
            CurrentViewModelChanged?.Invoke();
        }
    }
}
