using Blockter.Configuration;
using Blockter.Infrastructure.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blockter.Configuration;

public static class AppSettingsConfiguration
{
    public static IServiceCollection AddAppSettingsModule(this IServiceCollection services, IConfiguration configuration)
    {
        // Use this to load settings from appSettings file
        services.Configure<SecuritySettings>(options => configuration.GetSection("security").Bind(options));

        return services;
    }
}
