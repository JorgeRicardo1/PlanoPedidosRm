using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using MvvmHelpers.Commands;
using PlanoPedidosRm.Models;
using Xamarin.Forms;


namespace PlanoPedidosRm.ViewModels
{
    [QueryProperty(nameof(Articulo), nameof(Articulo))]
    public class GestionPedidosViewModel : BaseViewModel
    {
        public AsyncCommand IrArticulosCommand { get; set; }

        Articulo _articulo;
        string _nombreArticulo;
        public string _idArticulo;

        public GestionPedidosViewModel() 
        {
            IrArticulosCommand = new AsyncCommand(irArticulos);
            if (Articulo != null)
            {
                NombreArticulo = Articulo.Nombre;
            }
            
        }

        

        public Articulo Articulo
        {
            get => _articulo;
            set 
            {
                
                OnPropertyChanged();
            }
        }

        public string NombreArticulo
        {
            get => _nombreArticulo;
            set => SetProperty(ref _nombreArticulo, value);
        }

        public string IdArticulo
        {
            get => _idArticulo;
            set 
            { 
                _idArticulo = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
            }
        }

        async Task irArticulos()
        {
            await Shell.Current.GoToAsync("/ArticulosPage");
        }
    }
}
