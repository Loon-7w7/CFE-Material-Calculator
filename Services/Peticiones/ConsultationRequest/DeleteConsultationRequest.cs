using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Peticiones.ConsultationRequest
{
    /// <summary>
    /// peticion para eliminar una consulta
    /// </summary>
    public class DeleteConsultationRequest
    {
        /// <summary>
        /// Id de la consulta
        /// </summary>
        public Guid Id { get; set; }
    }
}
