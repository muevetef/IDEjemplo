using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        //configurar el contenedor de servicios
        var serviceCollection = new ServiceCollection();
        ServiceConfiguration.ConfigureServices(serviceCollection);

        var serviceProvider = serviceCollection.BuildServiceProvider();

        var cocheElectrico = CocheFactory.CrearCoche(serviceProvider, MotorOptions.Electrico);
        cocheElectrico.Arrancar();
        cocheElectrico.Parar();

        var cocheCombustible = CocheFactory.CrearCoche(serviceProvider, MotorOptions.Combustion);
        cocheCombustible.Arrancar();
        cocheCombustible.Parar();
    }
}