using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ListadosDAL
    {
        /// <summary>
        /// Devuelve una lista de misiones
        /// </summary>
        /// <returns></returns>
        public static List<Mision> ListarMisiones() { 
            List<Mision> misiones = new List<Mision>();
            misiones.Add(new Mision(1, "Recoger impuestos en el restaurante.", 1));
            misiones.Add(new Mision(2, "Hacer una oferta que no puedan rechazar el sindicato de basura.", 2));
            misiones.Add(new Mision(3, "Supervisar obras en New Jersey.", 3));
            misiones.Add(new Mision(4, "Convencer al concejal de urbanismo para conseguir favores.", 4));
            misiones.Add(new Mision(5, "Encargarse del concejal de urbanismo que no se dejó convencer.", 5));
            misiones.Add(new Mision(6, "Llevar la contabilidad del Bada Bing", 1));
            return misiones;
        }

        /// <summary>
        /// Devuelve una lista de candidatos
        /// </summary>
        /// <returns></returns>
        public static List<Candidato> ListarCandidatos()
        {
            List<Candidato> candidatos = new List<Candidato>();
            candidatos.Add(new Candidato(1, "Vito", "Gordon", "Pizza Street 1232", "USA", "5456768", new DateTime(1961, 11, 10), 2500));
            candidatos.Add(new Candidato(2, "Christopher", "Moltisanti", "St Monti Av", "USA", "58566547", new DateTime(2000, 03, 22), 1500));
            candidatos.Add(new Candidato(3, "Braulia", "Galliani", "Brooklyn Av", "USA", "58263547", new DateTime(1998, 12, 09), 1500));
            candidatos.Add(new Candidato(4, "Paulie", "Galliani", "Soprano St, 5", "USA", "85326547", new DateTime(1968, 07, 24), 2000));
            candidatos.Add(new Candidato(5, "Estás", "Caputo", "Vía Bonna Sera, 14", "Italia", "53576549", new DateTime(1973, 06, 02), 20000));
            candidatos.Add(new Candidato(6, "Toco", "L' Acordeone", "Via Música, 20", "Italia", "18576547", new DateTime(1984, 03, 12), 14000));
            candidatos.Add(new Candidato(7, "Luigi", "Pepperoni", "Piaza Roma, 3", "Italia", "78516547", new DateTime(1999, 04, 05), 16000));
            candidatos.Add(new Candidato(8, "Silvio", "Dante", "Town Street, 56", "USA", "87563547", new DateTime(1996, 01, 30), 2000));
            return candidatos;
        }
    }
}
