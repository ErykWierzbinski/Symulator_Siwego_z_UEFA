using Symulator_Siwego_z_UEFA.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Symulator_Siwego_z_UEFA.Commands
{
    public class UpdateViewCommand : ICommand
    {
        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        private MainViewModel viewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine("test");

            if (parameter.ToString() == "QuickMatch")
            {
                viewModel.SelectedViewModel = new QuickMatchViewModel();
                Console.WriteLine("quickmatch");
            }
            else if(parameter.ToString() == "Main")
            {
                viewModel.SelectedViewModel = new MainViewModel();
                Console.WriteLine("main");
            }
        }
    }
}
