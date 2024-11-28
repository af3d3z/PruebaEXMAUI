using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Mision
    {
        #region atributos
        private int _id;
        private string _nombre;
        private int _dificultad;
        #endregion

        #region propiedades
        public int ID {
            get { return _id; }
        }

        public string Nombre {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Dificultad
        {
            get { return _dificultad; }
            set { _dificultad = value; }
        }
        #endregion

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Mision() { }

        /// <summary>
        /// Constructor con todos los parámetros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="dificultad"></param>
        public Mision(int id, string nombre, int dificultad) { 
            this._id = id;
            this._nombre = nombre;
            this._dificultad = dificultad;   
        }
    }
}
