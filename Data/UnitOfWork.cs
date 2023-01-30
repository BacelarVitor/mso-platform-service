namespace PlatformService.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _ctx;
        public UnitOfWork(AppDbContext ctx, IPlatformRepository platformRepository)
        {
            _ctx = ctx;
            PlatformRepository = platformRepository;
        }
        public IPlatformRepository PlatformRepository { get; private set; }

        public int Complete()
        {
            return _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}