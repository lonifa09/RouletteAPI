using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.DependencyInjection;
using RouletteAPI.Data;

namespace RouletteAPI
{
    public static class ServiceExtensions
    {
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<Player>(c => c.User.RequireUniqueEmail = true);
            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);
            builder.AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();
        }
    }
}
