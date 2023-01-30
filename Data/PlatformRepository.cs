using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlatformService.Data;
using PlatformService.Models;

namespace mso_platform_service.Data
{
    public class PlatformRepository : Repository<Platform>, IRepository<Platform>
    {
        public PlatformRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}