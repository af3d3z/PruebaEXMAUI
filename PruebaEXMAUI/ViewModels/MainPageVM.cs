using ENT;
using PruebaEXMAUI.Models;
using PruebaEXMAUI.Models.Utils;
using PruebaEXMAUI.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEXMAUI.ViewModels
{
    public class MainPageVM: VMBase
    {
        #region atributos
        private List<Mision> _misiones;
        private ObservableCollection<CandidatoConEdad>? _candidatos;
        private CandidatoConEdad? _candidatoSeleccionado;
        private Mision? _misionSeleccionada;
        private DelegateCommand _btnDetalles;
        #endregion

        #region propiedades
        public List<Mision> Misiones { get { return _misiones; } }
        public ObservableCollection<CandidatoConEdad> Candidatos { get { return _candidatos; } }
        public Mision? MisionSeleccionada { get { return _misionSeleccionada; } set { 
                _misionSeleccionada = value;
                _candidatoSeleccionado = null;
                this._candidatos.Clear();
                List<Candidato> candidatos = BL.ListadosBL.ListarCandidatosPorFiltro(_misionSeleccionada.Dificultad);
                foreach (Candidato cand in candidatos) {
                    this._candidatos.Add(new CandidatoConEdad(cand));
                }
                NotifyPropertyChanged("Candidatos");
            } 
        }
        public CandidatoConEdad CandidatoSeleccionado { get { return _candidatoSeleccionado; } set { _candidatoSeleccionado = value; BtnDetalles.RaiseCanExecuteChanged(); } }
        public DelegateCommand BtnDetalles { get { return _btnDetalles; } set { _btnDetalles = value; } }
        #endregion

        #region constructor 
        public MainPageVM() {
            this._misiones = BL.ListadosBL.ListarMisionesBL();
            this._misionSeleccionada = null;
            this._candidatoSeleccionado = null;
            this._candidatos = new ObservableCollection<CandidatoConEdad>();
            this.BtnDetalles = new DelegateCommand(BtnDetalles_Execute, BtnDetalles_CanExecute);
        }
        #endregion

        #region commands
        /// <summary>
        /// Comprueba si se puede pulsar el botón
        /// </summary>
        /// <returns></returns>
        private bool BtnDetalles_CanExecute() {
            bool canExecute = false;
            if (_candidatoSeleccionado != null) {
                canExecute = true;
            }
            return canExecute;
        }

        private async void BtnDetalles_Execute() {
            Application.Current.MainPage.Navigation.PushAsync(new Detalles(_candidatoSeleccionado));
        }
        #endregion
    }
}
