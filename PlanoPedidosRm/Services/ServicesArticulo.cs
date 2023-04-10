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
        public static async Task<ObservableRangeCollection<ArticuloModel>> GetArticulos()
        {
            ObservableRangeCollection<ArticuloModel> articulos = new ObservableRangeCollection<ArticuloModel>
            {
                new ArticuloModel() { Id = 1, Nombre = "Papa" },
                new ArticuloModel() { Id = 2, Nombre = "Casa" },
                new ArticuloModel() { Id = 3, Nombre = "Pera" }
            };

            return articulos;
        }

        public static async Task<ArticuloModel> GetArticulo(string id)
        {
            ObservableRangeCollection<ArticuloModel> articulos = new ObservableRangeCollection<ArticuloModel>
            {
                new ArticuloModel() { Id = 1, Nombre = "Papa" },
                new ArticuloModel() { Id = 2, Nombre = "Casa" },
                new ArticuloModel() { Id = 3, Nombre = "Pera" }
            };

            foreach (var articulo in articulos)
            {
                if (articulo.Id == Int32.Parse(id))
                {
                    return articulo;
                }
            }
            return null;
        }
    }
}
