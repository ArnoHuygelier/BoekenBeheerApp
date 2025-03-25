using BoekenBeheerApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenBeheerApp.ViewModel
{
    public class vmNavigationBar
    {
        private readonly NavigationStore _navigationStore;
        public vmNavigationBar(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
    }
}
