using System.Collections.Generic;

namespace PhoneBook.Domain.Services.Contact
{
    public interface IContactRepository
    {
        bool PostContact(ContactEntity contact);

        IEnumerable<ContactEntity> GetByName(string name);

        ContactEntity GetName(string name);
    }
}