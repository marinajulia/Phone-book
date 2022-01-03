using AutoMapper;
using PhoneBook.Domain.Services.Contact.Dto;
using PhoneBook.Domain.Services.Phone;
using PhoneBook.Domain.Services.Phone.Dto;
using SharedKernel.Domain.Notification;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook.Domain.Services.Contact
{
    public class ContactService : IContactService
    {
        private readonly INotification _notification;
        private readonly IContactRepository _contactRepository;
        private readonly IPhoneRepository _phoneRepository;
        private readonly IMapper _mapper;

        public ContactService(INotification notification, IContactRepository contactRepository,
            IPhoneRepository phoneRepository, IMapper mapper)
        {
            _notification = notification;
            _contactRepository = contactRepository;
            _phoneRepository = phoneRepository;
            _mapper = mapper;
        }

        public IEnumerable<ContactDto> GetByName(string name)
        {
            var names = _contactRepository.GetContainsName(name);

            if (names.Count() < 1)
                return null;

            return _mapper.Map<IEnumerable<ContactDto>>(names);
        }

        public bool PostContact(ContactDto contact)
        {
            if (string.IsNullOrEmpty(contact.Name))
            {
                _notification.AddWithReturn<bool>("Ops.. o nome não pode ser nulo");
                return false;
            }

            if (!_contactRepository.PostContact(new ContactEntity
            {
                Id = contact.Id,
                Name = contact.Name,
                Phones = contact.Phones
            }))
            {
                _notification.AddWithReturn<bool>("Ops.. houve algum problema ao salvar o contato");
                return false;
            }

            return true;
        }
    }
}