// See https://aka.ms/new-console-template for more information
class CuentaBancaria
{ 
    private double saldo;

    public double Saldo
    { get
        {
            if (saldo<0)
            {
                return saldo;
            }
            else
            {
                Console.WriteLine("SAldo no disponnible");
                return 0;
            }

        } 
    set
            {
            saldo = value;
        }
    }



}