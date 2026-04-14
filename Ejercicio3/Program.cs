// See https://aka.ms/new-console-template for more information
class Producto
{
    private double precio;
    public double Precio
    {
        get
        {
            if (precio >= 0)
            {
                return precio;
            }
            else
            {
                return 0;
            }
        }
        set
        {
            precio = value;
        }
    }
}