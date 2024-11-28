using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ManejadoraCandidatos
    {
        /// <summary>
        /// Obtiene un candidato a partir de su id de la capa DAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Candidato</returns>
        public static Candidato? GetCandidatoBL(int id) {
            Candidato? candidato = null;
            if (id > 0)
            {
                candidato = ManejadoraCandidatos.GetCandidatoBL(id);
            }
            return candidato;
        }
    }
}
