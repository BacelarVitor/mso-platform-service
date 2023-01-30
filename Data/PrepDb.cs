namespace PlatformService.Data
{
    public static class PrepDeb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                System.Console.WriteLine("--> Seeding Data...");
                context.Platforms.AddRange(
                    new Models.Platform("Dotnet", "Microsoft", "Free"),
                    new Models.Platform("Flutter", "Google", "Free"),
                    new Models.Platform("Angular", "Google", "Free"),
                    new Models.Platform("SvelteKit", "Vercel", "Free"),
                    new Models.Platform("Golang", "Google", "Free")
                );

                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("--> We already have data");
            }
        }
    }
}