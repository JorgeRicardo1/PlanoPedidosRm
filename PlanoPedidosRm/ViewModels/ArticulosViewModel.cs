using MvvmHelpers;
using MvvmHelpers.Commands;
using PlanoPedidosRm.Models;
using PlanoPedidosRm.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlanoPedidosRm.ViewModels
{
    public class ArticulosViewModel :BaseViewModel
    {
        public ObservableCollection<Articulo> Articulos { get; set; }
        public AsyncCommand<Articulo> IrAGestionarPedidoscommand { get; }

        public ArticulosViewModel() 
        {
            Articulos = new ObservableCollection<Articulo>();
            IrAGestionarPedidoscommand = new AsyncCommand<Articulo>(IrAGestionarPedido);
            _ = obtenerArticulos();
            
        }

        public async Task obtenerArticulos()
        {
            Articulos = await ServicesArticulo.GetArticulos();
        }

        public async Task IrAGestionarPedido(Articulo articulo)
        {
            string route = $"/GestionPedidosPage?IdArticulo={articulo}";
            await Shell.Current.GoToAsync(route);
        }
    }
}
