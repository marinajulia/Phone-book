using PhoneBook.Domain.Services.Contact.Dto;
using SharedKernel.Domain.Notification;

namespace PhoneBook.Domain.Services.Contact
{
    public class ContactService : IContactService
    {
        private readonly INotification _notification;
        private readonly IContactRepository _contactRepository;

        public ContactService(INotification notification, IContactRepository contactRepository)
        {
            _notification = notification;
            _contactRepository = contactRepository;
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