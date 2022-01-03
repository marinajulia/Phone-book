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
            CreateMap<PhoneEntity, PhoneDto>();
            CreateMap<PhoneDto, PhoneEntity>();

            CreateMap<ContactEntity, ContactDto>();
            CreateMap<ContactDto, ContactEntity>();
        }
    }
}