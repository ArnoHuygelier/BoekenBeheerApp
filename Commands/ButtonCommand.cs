using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BoekenBeheerApp.Commands
{
    class ButtonCommand : ICommand
    {
        #region ButtomCommand ctor prop
        private Action<object> Actions { get; set; }

        public ButtonCommand(Action<object> action)
        {
            Actions = action;
        }
        #endregion


        #region icommand
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter != null)
            {
                Actions(parameter);
            }
            else
            {
                Actions("Leeg");
            }
        }
        #endregion
    }
}
