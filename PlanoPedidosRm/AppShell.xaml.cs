
using PlanoPedidosRm.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PlanoPedidosRm
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ArticulosPage), typeof(ArticulosPage));
            Routing.RegisterRoute(nameof(GestionPedidosPage),typeof(GestionPedidosPage));

        }


    }
}
