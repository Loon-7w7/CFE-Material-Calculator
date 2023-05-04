using AutoMapper;
using Domain.Entities;
using Services.Peticiones.MaterialRequest;
using Services.Respuestas.MaterialResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperService.Mappers
{
    /// <summary>
    /// Mapeo de Materiales
    /// </summary>
    public class MaterialMapper : Profile
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public MaterialMapper() 
        {
            /// <summary>
            /// mapea de material a GetMaterialByIdResponse
            /// </summary>
            CreateMap<Material, GetMaterialByIdResponse>()
                .ForMember(entidad => entidad.Id, opt => opt.MapFrom(respose => respose.Id))
                .ForMember(entidad => entidad.Name, opt => opt.MapFrom(respose => respose.Name))
                .ForMember(entidad => entidad.Unit, opt => opt.MapFrom(respose => respose.Unit))
                .ForMember(entidad => entidad.Total, opt => opt.MapFrom(respose => respose.Total));
            /// <summary>
            /// Mapea de  GetMaterialByIdResponse a material
            /// </summary>
            CreateMap< GetMaterialByIdResponse, Material>()
                .ForMember(entidad => entidad.Id, opt => opt.MapFrom(respose => respose.Id))
                .ForMember(entidad => entidad.Name, opt => opt.MapFrom(respose => respose.Name))
                .ForMember(entidad => entidad.Unit, opt => opt.MapFrom(respose => respose.Unit))
                .ForMember(entidad => entidad.Total, opt => opt.MapFrom(respose => respose.Total));
            /// <summary>
            /// Mapea de  UpdateMaterialRequest a material
            /// </summary>
            CreateMap<UpdateMaterialRequest, Material>()
                .ForMember(entidad => entidad.Id, opt => opt.MapFrom(respose => respose.Id))
                .ForMember(entidad => entidad.Name, opt => opt.MapFrom(respose => respose.Name))
                .ForMember(entidad => entidad.Unit, opt => opt.MapFrom(respose => respose.Unit))
                .ForMember(entidad => entidad.Total, opt => opt.MapFrom(respose => respose.Total));
            /// <summary>
            /// Mapea de material a UpdateMaterialRequest
            /// </summary>
            CreateMap<Material, UpdateMaterialRequest>()
                .ForMember(entidad => entidad.Id, opt => opt.MapFrom(respose => respose.Id))
                .ForMember(entidad => entidad.Name, opt => opt.MapFrom(respose => respose.Name))
                .ForMember(entidad => entidad.Unit, opt => opt.MapFrom(respose => respose.Unit))
                .ForMember(entidad => entidad.Total, opt => opt.MapFrom(respose => respose.Total));
            /// <summary>
            /// mapea de material a CreateMaterialRequest
            /// </summary>
            CreateMap<Material, CreateMaterialRequest>()
                .ForMember(entidad => entidad.Id, opt => opt.MapFrom(respose => respose.Id))
                .ForMember(entidad => entidad.Name, opt => opt.MapFrom(respose => respose.Name))
                .ForMember(entidad => entidad.Unit, opt => opt.MapFrom(respose => respose.Unit))
                .ForMember(entidad => entidad.Total, opt => opt.MapFrom(respose => respose.Total));
            /// <summary>
            /// Mapea de  CreateMaterialRequest a material
            /// </summary>
            CreateMap<CreateMaterialRequest, Material>()
                .ForMember(entidad => entidad.Id, opt => opt.MapFrom(respose => respose.Id))
                .ForMember(entidad => entidad.Name, opt => opt.MapFrom(respose => respose.Name))
                .ForMember(entidad => entidad.Unit, opt => opt.MapFrom(respose => respose.Unit))
                .ForMember(entidad => entidad.Total, opt => opt.MapFrom(respose => respose.Total));
        }
    }
}
