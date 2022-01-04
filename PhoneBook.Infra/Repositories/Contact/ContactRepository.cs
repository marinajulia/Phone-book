using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain.Services.Contact;
using PhoneBook.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook.Infra.Repositories.Contact
{
    public class ContactRepository : IContactRepository
    {
        public IEnumerable<ContactEntity> GetContainsName(string name)
        {
            using (var context = new ApplicationContext())
            {
                return context.Contact
                    .Include(x=> x.Phones)
                    .Where(x => x.Name.Trim().ToLower().Contains(name.Trim().ToLower()))
                    .ToList();
            }
        }

        public ContactEntity GetByName(string name)
        {
            using (var context = new ApplicationContext())
            {
                return context.Contact.FirstOrDefault(x => x.Name.Trim().ToLower() == name.Trim().ToLower());
            }
        }

        public bool PostContact(ContactEntity contact)
        {
            using (var context = new ApplicationContext())
            {
                try
                {
                    context.Contact.Add(contact);
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