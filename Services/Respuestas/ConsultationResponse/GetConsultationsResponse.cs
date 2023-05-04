using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Respuestas.ConsultationResponse
{
    /// <summary>
    /// Respuesta a la consulta en lista
    /// </summary>
    public class GetConsultationsResponse
    {
        /// <summary>
        /// Lista de consultas
        /// </summary>
        public List<Consultation> consultations { get; set; }
    }
}
