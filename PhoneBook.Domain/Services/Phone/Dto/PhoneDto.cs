namespace PhoneBook.Domain.Services.Phone.Dto
{
    public class PhoneDto
    {
        public PhoneDto(int Id, string Phone)
        {
            this.Id = Id;
            this.Phone = Phone;
        }

        public int Id { get; set; }
        public string Phone { get; set; }
    }
}