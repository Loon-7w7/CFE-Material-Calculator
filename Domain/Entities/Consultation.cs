using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Entidad de Consultas
    /// </summary>
    public class Consultation
    {
        /// <summary>
        /// Identificador de consulta
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Numero de consulta
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Fecha de consulta
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Nombre de la consulta
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Descripcion de consultas
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Voltage de dispositivos
        /// </summary>
        public int Voltage { get; set; }
        /// <summary>
        /// Si es semiAislado
        /// </summary>
        public bool IsSemiIsolated { get; set; }
        /// <summary>
        /// Si es pesado
        /// </summary>
        public bool IsHeavy { get; set; }
        /// <summary>
        /// Liga de descarga del archivo
        /// </summary>
        public string UrlArchive { get; set; }
    }
}
