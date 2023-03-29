using System;
using System.Collections.Generic;
using System.Text;
using MvvmHelpers;
using Xamarin.Forms;

namespace PlanoPedidosRm.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public Command LogearseCommand { get; set; }

        public LoginPageViewModel() 
        {
            LogearseCommand = new Command(logearse);
        }
        public void logearse()
        {
            Shell.Current.GoToAsync("//IngresarCliente");
        }
    }
}
