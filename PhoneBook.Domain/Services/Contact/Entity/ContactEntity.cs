using PhoneBook.Domain.Services.Phone;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Domain.Services.Contact
{
    public class ContactEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public IEnumerable<PhoneEntity> Phones { get; set; }
    }
}