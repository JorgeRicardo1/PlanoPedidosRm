using MvvmHelpers;
using PlanoPedidosRm.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlanoPedidosRm.Services
{
    public class ServicesArticulo
    {
        public static async Task<ObservableRangeCollection<Articulo>> GetArticulos()
        {
            ObservableRangeCollection<Articulo> articulos= new ObservableRangeCollection<Articulo>();

            articulos.Add(new Articulo() { Id= 1, Nombre="Papa"});
            articulos.Add(new Articulo() { Id = 2, Nombre = "Casa" });
            articulos.Add(new Articulo() { Id = 3, Nombre = "Pera" });

            return articulos;
        }
    }
}
