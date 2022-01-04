using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<PhoneEntity> GetContainsPhone(string phone)
        {
            using (var context = new ApplicationContext())
            {
                return context.Phone
                    .Include(x=> x.Contact)
                    .Where(x => x.Phone.Trim().ToLower().Contains(phone.Trim().ToLower()))
                    .ToList();
            }
        }

        public IEnumerable<PhoneEntity> GetPhonesByIdContact(int id)
        {
            using (var context = new ApplicationContext())
            {
                return context.Phone.Where(x => x.IdContact == id);
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