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
        public ObservableCollection<ArticuloModel> Articulos { get; set; }
        public AsyncCommand<ArticuloModel> IrAGestionarPedidoscommand { get; }

        public ArticulosViewModel() 
        {
            Articulos = new ObservableCollection<ArticuloModel>();
            IrAGestionarPedidoscommand = new AsyncCommand<ArticuloModel>(IrAGestionarPedido);
            _ = obtenerArticulos();
            
        }

        public async Task obtenerArticulos()
        {
            Articulos = await ServicesArticulo.GetArticulos();
        }

        public async Task IrAGestionarPedido(ArticuloModel articulo)
        {
            string route = $"/GestionPedidosPage?IdArticulo={articulo.Id}";
            await Shell.Current.GoToAsync(route);
        }
    }
}
