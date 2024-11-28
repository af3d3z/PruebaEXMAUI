using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManejadoraCandidatos
    {
        /// <summary>
        /// Devuelve un candidato por su id, si no existe se devolverá null
        /// PRE: el id debe ser mayor a 0
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Candidato GetCandidato(int id) { 
            Candidato cand = ListadosDAL.ObtenerCandidatosDAL().Where(candidato => candidato.ID == id).FirstOrDefault();
            return cand;
        }
    }
}
