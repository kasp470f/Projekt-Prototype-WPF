using Prototype_WPF.ViewModels.Commands;
using Prototype_WPF.Views.Partials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Prototype_WPF.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {

        public Page PageContent { get; set; }

        private ICommand setPageContentCommand { get; set; }

        public ICommand SetPageContentCommand { get { return setPageContentCommand; } }
        public MainWindowViewModel()
        {
            Page home = new Forside();
            PageContent = home;

            // sætte SetPageContentCommand
            setPageContentCommand = new SetPageContentCommand(this);
        }



        public void SwapPageContent(string name)
        {
            switch (name)
            {
                case "Home":
                    PageContent = new Forside();
                    break;
                case "Profil":
                    PageContent = new UserProfile();
                    break;
                case "OpretBruger":
                    PageContent = new UserSignup();
                    break;
                case "Search":
                    PageContent = new VoulenteerSearch();
                    break;
                default:
                    PageContent = new Forside();
                    break;
            }
            OnPropertyChanged("PageContent");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string x)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(x));
        }

    }
}
