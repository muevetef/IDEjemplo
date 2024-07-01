public class MotorCombustion : IMotor
{
    public void Arrancar()
    {
        Console.WriteLine("Motor combustión arrancado.");
    }

    public void Parar()
    {
        Console.WriteLine("Motor combustión parado.");
    }
}