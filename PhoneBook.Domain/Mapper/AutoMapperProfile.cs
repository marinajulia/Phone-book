using AutoMapper;
using PhoneBook.Domain.Services.Contact;
using PhoneBook.Domain.Services.Contact.Dto;
using PhoneBook.Domain.Services.Phone;
using PhoneBook.Domain.Services.Phone.Dto;
using System.Linq;

namespace PhoneBook.Domain.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PhoneEntity, PhoneDto>().ReverseMap();
            CreateMap<ContactEntity, ContactDto>().ForMember(
                contact => contact.Phones,
                o => o.MapFrom(src => src.Phones.Select(x => new PhoneDto(x.Id, x.Phone))));

        }
    }
}