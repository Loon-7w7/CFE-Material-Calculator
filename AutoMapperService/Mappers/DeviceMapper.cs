using AutoMapper;
using Domain.Entities;
using Services.Peticiones.DeviceRequest;
using Services.Respuestas.DeviceResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperService.Mappers
{
    public class DeviceMapper : Profile
    {
        public DeviceMapper() 
        {
            /// <summary>
            /// Mapea de Device a GetDeviceByIdResponse
            /// </summary>
            CreateMap<Device, GetDeviceByIdResponse>()
                .ForMember(entidad => entidad.Id, opt => opt.MapFrom(Response => Response.Id))
                .ForMember(entidad => entidad.Name, opt => opt.MapFrom(Response => Response.Name))
                .ForMember(entidad => entidad.Clasificacion, opt => opt.MapFrom(Response => Response.Clasificacion))
                .ForMember(entidad => entidad.materials, opt => opt.MapFrom(Response => Response.materials));
            /// <summary>
            /// Mapea de GetDeviceByIdResponse a Device
            /// </summary>
            CreateMap< GetDeviceByIdResponse , Device>()
                .ForMember(entidad => entidad.Id, opt => opt.MapFrom(Response => Response.Id))
                .ForMember(entidad => entidad.Name, opt => opt.MapFrom(Response => Response.Name))
                .ForMember(entidad => entidad.Clasificacion, opt => opt.MapFrom(Response => Response.Clasificacion))
                .ForMember(entidad => entidad.materials, opt => opt.MapFrom(Response => Response.materials));
        }
    }
}
