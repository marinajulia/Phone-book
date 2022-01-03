using PhoneBook.Domain.Services.Phone.Dto;
using System.Collections.Generic;

namespace PhoneBook.Domain.Services.Phone
{
    public interface IPhoneService
    {
        IEnumerable<PhoneDto> GetByPhone(string phone);
    }
}