using AutoMapper;
using PhoneBook.Domain.Services.Phone.Dto;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook.Domain.Services.Phone
{
    public class PhoneService : IPhoneService
    {
        private readonly IPhoneRepository _phoneRepository;
        private readonly IMapper _mapper;

        public PhoneService(IPhoneRepository phoneRepository, IMapper mapper)
        {
            _phoneRepository = phoneRepository;
            _mapper = mapper;
        }

        public IEnumerable<PhoneDto> GetByPhone(string phone)
        {
            var phones = _phoneRepository.GetContainsPhone(phone);

            if (phones.Count() < 1)
                return null;

            return _mapper.Map<IEnumerable<PhoneDto>>(phones);
        }
    }
}