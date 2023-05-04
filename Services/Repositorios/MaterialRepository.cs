using Services.Peticiones.MaterialRequest;
using Services.Respuestas.MaterialResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositorios
{
    /// <summary>
    /// Interfaz de materiales
    /// </summary>
    public interface MaterialRepository
    {
        /// <summary>
        /// Metodo para obtener los Materiales por su id
        /// </summary>
        /// <param name="request">Id del diospositivo</param>
        /// <returns></returns>
        Task<GetMaterialByIdResponse> GetMaterialById(GetMaterialByIdRequest request);
        /// <summary>
        /// Metodo para obtener todos los Materiales
        /// </summary>
        /// <returns></returns>
        Task<GetMaterialsResponse> GetMaterials();
        /// <summary>
        /// Metodo para crear Materiales
        /// </summary>
        /// <param name="request">Datos del nuevo Material</param>
        /// <returns></returns>
        Task<bool> CreateMaterial(CreateMaterialRequest request);
        /// <summary>
        /// Metodo para eliminacion de Materiales
        /// </summary>
        /// <param name="request">Id del Material</param>
        /// <returns></returns>
        Task<bool> DeleteMaterial(DeleteMaterialRequest request);
        /// <summary>
        /// actualizacion de Materiales
        /// </summary>
        /// <param name="request">Nuevos datos de los Materiales</param>
        /// <returns></returns>
        Task<bool> UpdateMaterial(UpdateMaterialRequest request);
    }
}
