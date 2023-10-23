using Domain.Entities;
using Infrastructure.EntityFramework;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations;

public class ApplicationFormRepository:EFGenericRepository<ApplicationForm>,IApplicationFormRepository
{
    public ApplicationFormRepository(DateBaseContext context) : base(context) { }
}
