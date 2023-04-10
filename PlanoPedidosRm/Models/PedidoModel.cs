using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PlanoPedidosRm.Models
{
    public class PedidoModel
    {
        public int Id { get; set; }
        public ObservableCollection<ArticuloModel> Movimientos { get; set; }
    }
}
