using Microsoft.AspNetCore.Mvc;
using PhoneBook.Domain.Services.Contact;
using PhoneBook.Domain.Services.Phone;
using SharedKernel.Domain.Notification;

namespace PhoneBook.Api.Controllers.Contact
{
    [ApiController]
    [Route("contact")]
    public class ContactController: Controller
    {
        private readonly INotification _notification;
        private readonly IPhoneService _phoneService;
        private readonly IContactService _contactService;

        public ContactController(INotification notification, IPhoneService phoneService, IContactService contactService)
        {
            _notification = notification;
            _phoneService = phoneService;
            _contactService = contactService;
        }

        [HttpGet("getbycontact")]
        public IActionResult GetByValue(string value)
        {
            var response = _contactService.GetByName(value);

            return Ok(response);
        }
    }
}
