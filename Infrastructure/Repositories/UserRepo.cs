using Infrastructure.Contexts;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories;

public class UserRepo(ApplicationIdentityContext context) : BaseRepo<UserEntity>(context)
{
    private readonly ApplicationIdentityContext _context = context;

}
