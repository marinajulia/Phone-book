using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PhoneBook.Domain.Mapper;
using PhoneBook.Domain.Services.Contact;
using PhoneBook.Domain.Services.Phone;
using PhoneBook.Infra.Data;
using PhoneBook.Infra.Repositories.Contact;
using PhoneBook.Infra.Repositories.Phone;
using SharedKernel.Domain.Notification;

namespace PhoneBook.Api.Infra
{
    public static class DependencyResolver
    {
        public static void Resolve(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(m =>
            {
                m.AddProfile(new AutoMapperProfile());
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<INotification, Notification>();
            services.AddDbContext<ApplicationContext>();
            Repositories(services);
            Services(services);
        }

        public static void Repositories(IServiceCollection services)
        {
            services.AddScoped<IPhoneRepository, PhoneRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
        }

        public static void Services(IServiceCollection services)
        {
            services.AddScoped<IPhoneService, PhoneService>();
            services.AddScoped<IContactService, ContactService>();
        }
    }
}