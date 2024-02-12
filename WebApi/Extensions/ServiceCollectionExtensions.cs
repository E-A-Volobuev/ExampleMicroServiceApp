using Domain.Entities;
using FluentValidation;
using Infrastructure.Masstransit;
using Infrastructure.Repositories.Implementations;
using Services.Abstractions;
using Services.Contracts;
using Services.Implementations;
using Services.Repositories.Abstractions;
using WebApi.Validators;
namespace WebApi.Extensions;

internal static class ServiceCollectionExtensions
{
    /// <summary>
    /// Метод-расширение для регистрации сервисов бизнес-логики по работе с данными
    /// </summary>
    public static IServiceCollection AddBLLServices(this IServiceCollection services)
    {
        services.AddScoped<IApplicationFormRepository, ApplicationFormRepository>()
                .AddScoped<IEFGenericRepository<ApplicationForm>, EFGenericRepository<ApplicationForm>>()
                .AddScoped<IEFGenericRepository<EventLogEntity>, EFGenericRepository<EventLogEntity>>()
                .AddScoped<IValidator<ApplicationFormDto>, ApplicationFormValidator>()
                .AddScoped<IMassTransitHelper, MassTransitHelper>()
                .AddScoped<IEventLogService, EventLogService>();

        return services;
    }
}
