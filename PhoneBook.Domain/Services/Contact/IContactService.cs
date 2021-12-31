using PhoneBook.Domain.Services.Contact.Dto;

namespace PhoneBook.Domain.Services.Contact
{
    public interface IContactService
    {
        bool PostContact(ContactDto contact);
    }
}