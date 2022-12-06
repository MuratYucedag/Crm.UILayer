using Crm.BusinessLayer.Abstact;
using Crm.BusinessLayer.Concrete;
using Crm.BusinessLayer.ValidationRules.AnnouncementValidationRules;
using Crm.DataAccessLayer.Abstract;
using Crm.DataAccessLayer.EntityFramework;
using Crm.DTO.DTOs.AnnouncementDtos;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Crm.BusinessLayer.DIContainer
{
    public static class Extension
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IEmployeeDal, EfEmployeeDal>();

            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IMessageDal, EfMessageDal>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
        }
        public static void DtoValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementAddValidator>();
            services.AddTransient<IValidator<AnnouncementUpdateDto>, AnnouncementUpdateValidator>();
        }
    }
}
