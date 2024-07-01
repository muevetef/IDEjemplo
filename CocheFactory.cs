using Microsoft.Extensions.DependencyInjection;
using System;

public static class CocheFactory
{
    public static Coche CrearCoche(IServiceProvider serviceProvider, string tipoMotor)
    {
        var motorFactories = serviceProvider.GetRequiredService<IDictionary<string, Func<IServiceProvider, IMotor>>>();
        if (!motorFactories.TryGetValue(tipoMotor, out var motorFactory))
        {
            throw new ArgumentException($"Motor of type {tipoMotor} not registered.");
        }

        var motor = motorFactory(serviceProvider);
        return new Coche(motor);
    }
}