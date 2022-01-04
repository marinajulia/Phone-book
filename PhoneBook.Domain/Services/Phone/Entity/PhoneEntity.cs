using PhoneBook.Domain.Services.Contact;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneBook.Domain.Services.Phone
{
    public class PhoneEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Contact")]
        public int IdContact { get; set; }
        public ContactEntity Contact { get; set; }

        public string Phone { get; set; }
    }
}