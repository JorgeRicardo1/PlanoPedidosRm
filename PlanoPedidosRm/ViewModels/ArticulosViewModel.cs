using MvvmHelpers;
using PlanoPedidosRm.Models;
using PlanoPedidosRm.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace PlanoPedidosRm.ViewModels
{
    public class ArticulosViewModel :BaseViewModel
    {
        public ObservableCollection<Articulo> Articulos { get; set; }

        public ArticulosViewModel() 
        {
            Articulos = new ObservableCollection<Articulo>();
            obtenerArticulos();
            
        }

        public async Task obtenerArticulos()
        {
            Articulos = await ServicesArticulo.GetArticulos();
        }
    }
}
