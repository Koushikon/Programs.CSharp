using FPWDI.Devices.SmartServices;
using FPWDI.DeviceServices;
using FPWDI.LabelGen;
using FPWDI.RecorderServices;
using FPWDI.RelayServices;

namespace FPWDI;

/**
 * ? Use Of Factory Pattern With Dependency Injection in .NET
 * Article: https://code-maze.com/dotnet-factory-pattern-dependency-injection/
 * Source: https://github.com/CodeMazeBlog/CodeMazeGuides/tree/main/dotnet-dependency-injection/FactoryPatternInDependencyInjection
 */

public class Helper
{
    public static IServiceProvider CreateServiceProvider()
    {
        var host = Host.CreateDefaultBuilder()
            .ConfigureServices(ConfigureServices)
            .Build();

        return host.Services;
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        // Bind the appsettings.json value to LabelGenOptions Model
        services.AddOptions<LabelGenOptions>().BindConfiguration("LabelGenOptions");

        // Register LabelGen, Factory services
        services.AddSingleton<LabelGenService>(serviceProvider =>
        {
            var options = serviceProvider
                .GetService<IOptions<LabelGenOptions>>()!.Value;

            return new LabelGenService(
                options.Prefix,
                options.Suffix);
        });
        services.AddSingleton<LabelGenServiceFactory>();

        // Register Device, Factory services
        services.AddTransient<DeviceFactory>();
        services.AddTransient<IDeviceFactory, DeviceFactory>();
        services.AddTransient<IDeviceFactory, SmartDeviceFactory>();
        services.AddTransient<MasterDeviceFactory>();

        // Register Relay, Factory services
        services.AddTransient<IRelayService, SandBoxRelayService>();
        services.AddTransient<IRelayService, LiveRelayService>();
        services.AddTransient<IRelayService, OfflineRelayService>();
        services.AddTransient<RelayServiceFactory>();

        // Register Recorder, Factory services
        services.AddTransient<RecorderServiceFactory>();
    }
}
