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
            navHome = new NavigationCommand
        }

        public ICommand navHome { get; set; }
        public ICommand navBoekenLijst { get; set; }
        public ICommand navBoekenBewerken { get; set; }
        public ICommand navBoekDetail { get; set; }
    }
}
