using System.Collections.Generic;

namespace PhoneBook.Domain.Services.Phone
{
    public interface IPhoneRepository
    {
        bool PostContact(PhoneEntity phone);
        IEnumerable<PhoneEntity> GetByPhone(string phone);
    }
}
