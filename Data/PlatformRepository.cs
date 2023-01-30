using PlatformService.Data;
using PlatformService.Models;

namespace mso_platform_service.Data
{
    public class PlatformRepository : Repository<Platform>, IRepository<Platform>
    {
        public PlatformRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}