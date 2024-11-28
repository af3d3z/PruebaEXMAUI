using PruebaEXMAUI.Models;
using PruebaEXMAUI.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEXMAUI.ViewModels
{
    public class DetallesVM: CandidatoConEdad
    {
        private DelegateCommand _btnVolver;

        public DelegateCommand BtnVolver { get { return _btnVolver; } }

        public DetallesVM(CandidatoConEdad cand): base(cand)
        {
            this._btnVolver = new DelegateCommand(BtnVolver_Execute);
        }

        /// <summary>
        /// Navega hasta la MainPage
        /// </summary>
        private async void BtnVolver_Execute() {
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
