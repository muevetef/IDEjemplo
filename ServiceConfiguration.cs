using Microsoft.Extensions.DependencyInjection;

public static class ServiceConfiguration
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<MotorElectrico>();
        services.AddTransient<MotorCombustion>();
        // Registrar un diccionario de motores
        services.AddSingleton<IDictionary<string, Func<IServiceProvider, IMotor>>>(serviceProvider =>
            new Dictionary<string, Func<IServiceProvider, IMotor>>
            {
                { MotorOptions.Electrico, sp => sp.GetRequiredService<MotorElectrico>() },
                { MotorOptions.Combustion, sp => sp.GetRequiredService<MotorCombustion>() }
            });

        // Registrar el servicio del coche
        services.AddTransient<Coche>();
    }
}