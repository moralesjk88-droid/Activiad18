// See https://aka.ms/new-console-template for more information
class Empleado
{
    private double salario;
    private double salarioMinimo = 1500;

    public double SAlario
    { get
        {
            if (salario>=salarioMinimo)
            {
                return salario;   
            }
            else
            {
                Console.WriteLine("Salario Invalido");
                return 0;
            }
        }
        set { 
            salario = value;
        }
    }

}