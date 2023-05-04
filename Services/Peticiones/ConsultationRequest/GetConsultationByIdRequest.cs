using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Peticiones.ConsultationRequest
{
    /// <summary>
    /// Peticion para obtener consultas por id
    /// </summary>
    public class GetConsultationByIdRequest
    {
        /// <summary>
        /// id de la consulta
        /// </summary>
        public Guid Id { get; set; }
    }
}
