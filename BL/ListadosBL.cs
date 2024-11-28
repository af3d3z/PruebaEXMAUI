using ENT;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace BL
{
    public class ListadosBL
    {
        /// <summary>
        /// Devuelve el listado de misiones de la capa DAL
        /// </summary>
        /// <returns></returns>
        public static List<Mision> ListarMisionesBL() {
            return ListadosDAL.ListarMisiones();
        }

        /// <summary>
        /// Devuelve el listado de candidatos de la capa DAL
        /// </summary>
        /// <returns></returns>
        public static List<Candidato> ListarCandidatosBL() {
            return ListadosDAL.ListarCandidatos();
        }
    }
}
