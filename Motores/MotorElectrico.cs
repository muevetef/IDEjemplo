public class MotorElectrico : IMotor
{
    public void Arrancar()
    {
        Console.WriteLine("Motor electrico arrancado.");
    }

    public void Parar()
    {
        Console.WriteLine("Motor electrico parado.");
    }
}