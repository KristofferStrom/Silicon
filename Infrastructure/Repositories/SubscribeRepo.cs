using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class SubscribeRepo(ApplicationIdentityContext context) : BaseRepo<SubscriberEntity>(context)
    {
        
    }
}
