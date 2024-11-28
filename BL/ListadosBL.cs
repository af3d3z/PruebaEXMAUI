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

        public static List<Candidato> ListarCandidatosPorFiltro(int dificultad) { 
            List<Candidato> candidatos = new List<Candidato>();
            switch (dificultad) {
                case 1 or 2:
                    candidatos = ListadosDAL.ListarCandidatosPorFiltro("USA");
                    break;
                case 3:
                    candidatos = ListadosDAL.ListarCandidatosPorFiltro("USA", 40, 100);
                    break;
                case 4:
                    candidatos = ListadosDAL.ListarCandidatosPorFiltro("Italia", 0, 45);
                    break;
                case 5:
                    candidatos = ListadosDAL.ListarCandidatosPorFiltro("Italia", 45, 55);
                    break;
            }
            return candidatos;
        }
    }
}
