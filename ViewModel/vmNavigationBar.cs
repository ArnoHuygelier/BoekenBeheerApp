using BoekenBeheerApp.Commands;
using BoekenBeheerApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BoekenBeheerApp.ViewModel
{
    public class vmNavigationBar
    {
        private readonly NavigationStore _navigationStore;
        public vmNavigationBar(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            navHome = new NavigateCommand<vmHome>(_navigationStore, () => new vmHome(_navigationStore));
            navBoekenLijst = new NavigateCommand<vmBoekLijst>(_navigationStore, () => new vmBoekLijst(_navigationStore));
            navBoekenBewerken = new NavigateCommand<vmBoekBewerken>(_navigationStore, () => new vmBoekBewerken(_navigationStore));
            navBoekDetail = new NavigateCommand<vmBoekDetail>(_navigationStore, () => new vmBoekDetail(_navigationStore));
        }

        public ICommand navHome { get; set; }
        public ICommand navBoekenLijst { get; set; }
        public ICommand navBoekenBewerken { get; set; }
        public ICommand navBoekDetail { get; set; }
    }
}
