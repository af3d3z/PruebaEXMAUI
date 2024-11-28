using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Candidato
    {
        #region atributos
        private int _id;
        private string _nombre;
        private string _apellidos;
        private string _direccion;
        private string _pais;
        private string _telefono;
        private DateTime _fechaNac;
        private int _precioMedio;
        #endregion

        #region propiedades
        public int ID { get { return _id; } }
        public string Nombre { get { return _nombre; }  set { _nombre = value; } }
        public string Apellidos { get { return _apellidos; } set { _apellidos = value; } }
        public string Direccion { get { return _direccion;} set { _direccion = value; } }
        public string Pais { get { return _pais; } set { _pais = value; } }
        public string Telefono { get { return _telefono; } set { _telefono = value; } }
        public DateTime FechaNac { get { return this._fechaNac; } set{ value = this._fechaNac; } }
        public int PrecioMedio { get { return _precioMedio; } set { _precioMedio = value;} }
        #endregion

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Candidato() { }

        /// <summary>
        /// Constructor con todos los parámetros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="direccion"></param>
        /// <param name="pais"></param>
        /// <param name="telefono"></param>
        /// <param name="fechaNac"></param>
        /// <param name="precioMedio"></param>
        public Candidato(int id, string nombre, string apellidos, string direccion, string pais, string telefono, DateTime fechaNac, int precioMedio) {
            this._id = id;
            this._nombre = nombre;
            this._apellidos = apellidos;
            this._direccion = direccion;
            this._pais = pais;
            this._telefono = telefono;
            this._fechaNac = fechaNac;
            this._precioMedio = precioMedio;
        }

        /// <summary>
        /// Constructor a partir de otro candidato
        /// </summary>
        /// <param name="candidato"></param>
        public Candidato(Candidato candidato) { 
            this._id = candidato._id;
            this._nombre = candidato._nombre;
            this._apellidos = candidato._apellidos;
            this._direccion = candidato._direccion;
            this._pais = candidato._pais;
            this._telefono = candidato._telefono;
            this._fechaNac = candidato._fechaNac;   
            this._precioMedio = candidato._precioMedio; 
        }
    }
}
