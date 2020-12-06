using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Prototype_WPF.ViewModels.Commands
{
    class SetPageContentCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        MainWindowViewModel vm;
        public SetPageContentCommand(MainWindowViewModel mvvm)
        {
            vm = mvvm;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            vm.SwapPageContent(parameter.ToString());
            //Debug.WriteLine("Der er hul igennem");

            //Skifter siden ud med noget andet
        }
    }
}
