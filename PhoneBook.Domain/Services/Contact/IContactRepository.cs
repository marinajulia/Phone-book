using System.Collections.Generic;

namespace PhoneBook.Domain.Services.Contact
{
    public interface IContactRepository
    {
        bool PostContact(ContactEntity contact);
        IEnumerable<ContactEntity> GetContainsName(string name);
        ContactEntity GetByName(string name);
    }
}