// See https://aka.ms/new-console-template for more information
class Usuario
{
    private string contrasena;
    

    public string Contrasena
    {
        get
        {
            if (contrasena.Length >= 8)
            {
                return "****";
            }
            else
            {
                return "Contraseña insegura";
            }
        }
        set
        {
            contrasena = value;
        }
    }
}