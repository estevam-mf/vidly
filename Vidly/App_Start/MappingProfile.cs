using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Models;
using Vidly.Dtos;
namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to DTO
            Mapper.CreateMap<CustomerModel, CustomerDto>();
            Mapper.CreateMap<MovieModel, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<GenreModel, GenreDto>();


            // DTO to Domain
            Mapper.CreateMap<CustomerDto, CustomerModel>().ForMember(x => x.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, MovieModel>().ForMember(x => x.Id, opt => opt.Ignore());

        }
    }
}