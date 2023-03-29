using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using MvvmHelpers.Commands;
using Xamarin.Forms;


namespace PlanoPedidosRm.ViewModels
{
    public class GestionPedidosViewModel : BaseViewModel
    {
        public AsyncCommand IrArticulosCommand { get; set; }

        public GestionPedidosViewModel() 
        {
            IrArticulosCommand = new AsyncCommand(irArticulos); 
        }

       async Task irArticulos()
        {
            await Shell.Current.GoToAsync("/ArticulosPage");
        }
    }
}
