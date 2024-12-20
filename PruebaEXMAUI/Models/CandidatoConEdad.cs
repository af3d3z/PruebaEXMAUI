﻿using System;
using ENT;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEXMAUI.Models
{
    public class CandidatoConEdad: Candidato
    {
        #region propiedades autoimplementadas
        public int Edad { get; set; }
        #endregion

        #region constructores
        /// <summary>
        /// constructor vacío
        /// </summary>
        public CandidatoConEdad() { }

        public CandidatoConEdad(Candidato candidato) : base(candidato) {
            this.Edad = DateTime.Now.Year - candidato.FechaNac.Year;
        }
        #endregion

    }
}
