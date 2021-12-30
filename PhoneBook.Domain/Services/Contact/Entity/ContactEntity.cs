using PhoneBook.Domain.Services.Phone;
using System.Collections.Generic;

namespace PhoneBook.Domain.Services.Contact
{
    public class ContactEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<PhoneEntity> Phones { get; set; }
    }
}
