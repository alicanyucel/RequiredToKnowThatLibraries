using AutoMapper;
using FluentValidationApp.Web.DTOs;
using FluentValidationApp.Web.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FluentValidationApp.Web.Mapping
{
    public class CustomerProfile:Profile
    {
        public CustomerProfile() 
        {
            //ReverseMap Function is make mapping for reverse.
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.İsim, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Eposta, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.Yaş, opt => opt.MapFrom(x => x.Age));
        }
    }
}
