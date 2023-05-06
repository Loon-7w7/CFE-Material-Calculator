using Services.Peticiones.ConsultationRequest;
using Services.Respuestas.ConsultationResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositorios
{
    /// <summary>
    /// Interfaz de consultas
    /// </summary>
    public interface ConsultationRepository
    {
        /// <summary>
        /// Metodo para obtener los Consultas por su id
        /// </summary>
        /// <param name="request">Id del diospositivo</param>
        /// <returns></returns>
        Task<GetConsultationByIdResponse> GetConsultationById(GetConsultationByIdRequest request);
        /// <summary>
        /// Metodo para obtener todos los Consultas
        /// </summary>
        /// <returns></returns>
        Task<GetConsultationsResponse> GetConsultations();
        /// <summary>
        /// Metodo para crear Consultas
        /// </summary>
        /// <param name="request">Datos del nueva Consulta</param>
        /// <returns></returns>
        Task<bool> CreateConsultation(CreateConsultationRequest request);
        /// <summary>
        /// Metodo para eliminacion de Consultas
        /// </summary>
        /// <param name="request">Id del Consulta</param>
        /// <returns></returns>
        Task<bool> DeleteConsultation(DeleteConsultationRequest request);
        /// <summary>
        /// actualizacion de Consultas
        /// </summary>
        /// <param name="request">Nuevos datos de las Consultas</param>
        /// <returns></returns>
        Task<bool> UpdateConsultation(UpdateConsultationRequest request);
    }
}
