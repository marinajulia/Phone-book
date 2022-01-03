using PhoneBook.Domain.Services.Contact;

namespace PhoneBook.Domain.Services.Phone.Dto
{
    public class PhoneDto
    {
        public int Id { get; set; }
        public int IdContact { get; set; }
        public string Phone { get; set; }
        public ContactEntity Contact { get; set; }
    }
}
