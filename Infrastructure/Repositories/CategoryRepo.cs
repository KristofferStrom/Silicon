using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class CategoryRepo(ApplicationIdentityContext context) : BaseRepo<CategoryEntity>(context)
{
}
