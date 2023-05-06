using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Services.Peticiones.MaterialRequest;
using Services.Repositorios;
using Services.Respuestas.MaterialResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementacion
{
    /// <summary>
    /// servicios de materiales
    /// </summary>
    public class MaterialService : MaterialRepository
    {
        /// <summary>
        /// Contexto de la base de datos
        /// </summary>
        public readonly DataBaseContext _context;
        /// <summary>
        /// Auto Mapper
        /// </summary>
        public readonly IMapper _mapper;
        /// <summary>
        /// contructor del servicio de materiales
        /// </summary>
        /// <param name="context">Contexto de la base de datos</param>
        /// <param name="mapper">Auto Mappper</param>
        public MaterialService(DataBaseContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        /// <summary>
        /// Metodo para crear Materiales
        /// </summary>
        /// <param name="request">Datos del nuevo Material</param>
        /// <returns></returns>
        public async Task<bool> CreateMaterial(CreateMaterialRequest request)
        {
            try { 
                request.Id = Guid.NewGuid();
                Material material = _mapper.Map<Material>(request);
                _context.materials.Add(material);
                await _context.SaveChangesAsync();
                return true;
            } catch { return false; }
        }
        /// <summary>
        /// Metodo para eliminacion de Materiales
        /// </summary>
        /// <param name="request">Id del Material</param>
        /// <returns></returns>
        public async Task<bool> DeleteMaterial(DeleteMaterialRequest request)
        {
            try { 
            Material? material;
            material = await _context.materials.FindAsync(request.Id);
            if (material != null) 
            {
                _context.materials.Remove(material);
                await _context.SaveChangesAsync();
            }
                return true;
            } catch { return false; }

        }
        /// <summary>
        /// Metodo para obtener los Materiales por su id
        /// </summary>
        /// <param name="request">Id del diospositivo</param>
        /// <returns></returns>
        public async Task<GetMaterialByIdResponse> GetMaterialById(GetMaterialByIdRequest request)
        {
            Material? material;
            GetMaterialByIdResponse response = new GetMaterialByIdResponse();
            material = await _context.materials.FirstOrDefaultAsync(x => x.Id == request.Id);
            if(material != null) 
            {
                response = _mapper.Map<GetMaterialByIdResponse>(material);
            }
            return response;
        }
        /// <summary>
        /// Metodo para obtener todos los Materiales
        /// </summary>
        /// <returns></returns>
        public async Task<GetMaterialsResponse> GetMaterials()
        {
            GetMaterialsResponse response = new GetMaterialsResponse();
            response.Materials = await _context.materials.ToListAsync();
            return response;
        }
        /// <summary>
        /// actualizacion de Materiales
        /// </summary>
        /// <param name="request">Nuevos datos de los Materiales</param>
        /// <returns></returns>
        public async Task<bool> UpdateMaterial(UpdateMaterialRequest request)
        {
            try { 
            Material? material = await _context.materials.FindAsync(request.Id);
            if( material != null ) 
            {
                material.Id = request.Id;
                material.Name = request.Name;
                material.Unit = request.Unit;

            }
            else 
            {
                Material newMaterial = _mapper.Map<Material>(request);
                await _context.materials.AddAsync(newMaterial);

            }
            await _context.SaveChangesAsync();
                return true;
            } catch { return false; }
        }
    }
}
