using PhoneBook.Domain.Services.Contact.Dto;
using System.Collections.Generic;

namespace PhoneBook.Domain.Services.Contact
{
    public interface IContactService
    {
        bool PostContact(ContactDto contact);
        IEnumerable<ContactDto> GetData(string data);

    }
}