using PhoneBook.Domain.Services.Contact.Dto;
using PhoneBook.Domain.Services.Phone;
using SharedKernel.Domain.Notification;
using System.Collections.Generic;

namespace PhoneBook.Domain.Services.Contact
{
    public class ContactService : IContactService
    {
        private readonly INotification _notification;
        private readonly IContactRepository _contactRepository;
        private readonly IPhoneRepository _phoneRepository;

        public ContactService(INotification notification, IContactRepository contactRepository,
            IPhoneRepository phoneRepository)
        {
            _notification = notification;
            _contactRepository = contactRepository;
            _phoneRepository = phoneRepository;
        }

        public IEnumerable<ContactDto> GetData(string data)
        {
            var names = _contactRepository.GetContainsName(data);
            var phones = _phoneRepository.GetContainsPhone(data);

            if (names == null)
            {
                if (phones == null)
                    _notification.AddWithReturn<IEnumerable<ContactDto>>("Ops.. não encontramos nenhum registro");
            }
            throw new System.NotImplementedException();
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