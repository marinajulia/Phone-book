using PhoneBook.Domain.Services.Phone;
using PhoneBook.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook.Infra.Repositories.Phone
{
    public class PhoneRepository : IPhoneRepository
    {
        public IEnumerable<PhoneEntity> GetByPhone(string phone)
        {
            using (var context = new ApplicationContext())
            {
                return context.Phone.Where(x => x.Phone.Trim().ToLower() == phone.Trim().ToLower());
            }
        }

        public bool PostPhone(PhoneEntity phone)
        {
            using (var context = new ApplicationContext())
            {
                try
                {
                    context.Phone.Add(phone);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }

                return true;
            }
        }
    }
}