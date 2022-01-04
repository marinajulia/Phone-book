using AutoMapper;
using PhoneBook.Domain.Services.Contact;
using PhoneBook.Domain.Services.Contact.Dto;
using PhoneBook.Domain.Services.Phone;
using PhoneBook.Domain.Services.Phone.Dto;

namespace PhoneBook.Domain.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PhoneEntity, PhoneDto>().ReverseMap();
            CreateMap<ContactEntity, ContactDto>().ReverseMap();

            //CreateMap<ContactEntity, PhoneEntity>().ForMember(x => x.Phones, map => map.MapFrom(prop => prop.)).ReverseMap();

            CreateMap<ContactEntity, PhoneEntity>().ForMember(q => q.Id, option => option.Ignore());
            CreateMap<ContactDto, PhoneDto>().ForMember(q => q.Id, option => option.Ignore());
        }
    }
}