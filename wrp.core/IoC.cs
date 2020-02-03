using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using wrp.core.Database;
using wrp.core.Infrastructure.Utils;

namespace wrp.core
{
    public class IoC
    {
        public static void Register(ServiceCollection services, IConfigurationRoot configuration)
        {
            RegisterDatabase(services, configuration);

            services.AddSingleton<ILogger, FileLogger>(sp =>
                new FileLogger(
                    configuration.GetValue<string>("Logging:FileOptions:Folder"),
                    configuration.GetValue<string>("Logging:FileOptions:Filename"))
            );

        }

        private static void RegisterDatabase(ServiceCollection services, IConfigurationRoot configuration)
        {
            services
                .AddEntityFrameworkNpgsql()
                .AddDbContext<WrpContext>(options => options.UseNpgsql(configuration.GetValue<string>("Database:ConnectionString")),
                    ServiceLifetime.Transient);
        }
    }
}
