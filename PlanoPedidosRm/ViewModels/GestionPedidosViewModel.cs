using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using MvvmHelpers.Commands;
using PlanoPedidosRm.Models;
using PlanoPedidosRm.Services;
using Xamarin.Forms;


namespace PlanoPedidosRm.ViewModels
{
    [QueryProperty(nameof(IdArticulo), nameof(IdArticulo))]
    public class GestionPedidosViewModel : BaseViewModel
    {
        //---------------COMANDOS-------------------------
        public AsyncCommand IrArticulosCommand { get; set; }
        public AsyncCommand AddArtiToTempCommand { get; set; }

        //----------------------VARIABLES-------------------
        ArticuloModel _articuloSeleccionado;
        string _nombreArticulo;
        string _idArticulo;
        bool _isVisibleBtnAdd;
        bool _isVisibleBtnIr;
        ObservableRangeCollection<ArticuloModel> _articulos;

        //-----------------CONSTRUCTOR----------------------------
        public GestionPedidosViewModel() 
        {
            IrArticulosCommand = new AsyncCommand(irArticulos);
            IsVisibleBtnIr = true;
            IsVisibleBtnAdd = false;
        }


        //-------------------OBJETOS---------------------
        public ArticuloModel ArticuloSeleccionado
        {
            get => _articuloSeleccionado;
            set => SetProperty(ref _articuloSeleccionado, value);
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
                if (value != null)
                {
                    IsVisibleBtnIr = false;
                    IsVisibleBtnAdd = true;
                    _ = identificarArticulo(value);
                }
                SetProperty(ref _idArticulo, value);
            }
        }

        public bool IsVisibleBtnAdd
        {
            get => _isVisibleBtnAdd;
            set => SetProperty(ref _isVisibleBtnAdd, value);
        }
        public bool IsVisibleBtnIr
        {
            get => _isVisibleBtnIr;
            set => SetProperty(ref _isVisibleBtnIr, value);
        }

        public ObservableRangeCollection<ArticuloModel> Articulos
        {
            get => _articulos;
            set => SetProperty(ref _articulos, value);
        }

        //---------------METODOS------------------
        async Task irArticulos()
        {
            await Shell.Current.GoToAsync("/ArticulosPage");
        }

        async Task identificarArticulo(string id)
        {
            ArticuloSeleccionado = await ServicesArticulo.GetArticulo(id);
        }

        async Task AddArtiToTemp()
        {

        }

    }
}
