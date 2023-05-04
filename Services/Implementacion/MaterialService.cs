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
        public async Task CreateMaterial(CreateMaterialRequest request)
        {
            _context.materials.Add(request);
            await _context.SaveChangesAsync();
        }
        /// <summary>
        /// Metodo para eliminacion de Materiales
        /// </summary>
        /// <param name="request">Id del Material</param>
        /// <returns></returns>
        public async Task DeleteMaterial(DeleteMaterialRequest request)
        {
            Material material;
            material = await _context.materials.FindAsync(request.Id);
            if (material != null) 
            {
                _context.materials.Remove(material);
                await _context.SaveChangesAsync();
            }

        }
        /// <summary>
        /// Metodo para obtener los Materiales por su id
        /// </summary>
        /// <param name="request">Id del diospositivo</param>
        /// <returns></returns>
        public async Task<GetMaterialByIdResponse> GetMaterialById(GetMaterialByIdRequest request)
        {
            Material material;
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
        public async Task UpdateMaterial(UpdateMaterialRequest request)
        {
            Material material = await _context.materials.FindAsync(request.Id);
            if( material != null ) 
            {
                _context.materials.Update(material);
                await _context.SaveChangesAsync(true);
            }
            else 
            {
                Material newMaterial = _mapper.Map<Material>(request);
                await _context.materials.AddAsync(newMaterial);
                await _context.SaveChangesAsync();
            }
        }
    }
}
