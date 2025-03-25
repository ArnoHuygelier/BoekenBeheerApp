using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoekenBeheerApp.Stores;
using BoekenBeheerApp.ViewModel;

namespace BoekenBeheerApp.Commands
{
    public class NavigateCommand<TViewModel> : CommandBase
       where TViewModel : vmBase
    {
        private readonly NavigationStore _navigationStore;

        //parameter die van het type Func is en als returnwaarde een zelf gekozen parameternaam TViewModel
        private Func<TViewModel> _createViewModel;

        public NavigateCommand(NavigationStore navigationStore, Func<TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }
        public override void Execute(object? parameter)
        {
            //_navigationStore.CurrentViewModel = new vmData(_navigationStore);
            //_navigationStore.CurrentViewModel = new vmHome(_navigationStore);

            //_createViewModel -> is een Func -> daarmee () na de func plaatsen
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
