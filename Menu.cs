namespace HolaMundo;

public class Menu
{
    private static Menu? _instance;

    private Menu() { }

    public static Menu Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Menu();
            }
            return _instance;
        }
    }

    public void MostrarMenu()
    {
        Console.WriteLine("1. Listar contactos");
        Console.WriteLine("2. Agregar contacto");
        Console.WriteLine("0. Salir");
    }

    public int SeleccionarOpcion()
    {
        Console.WriteLine("Seleccione una opción: ");
        LimpiarPantalla();
        return Convert.ToInt32(Console.ReadLine());
    }

    public void EjecutarOpcion(int opcion)
    {
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Hola Mundo!");
                break;
            case 2:
                Console.WriteLine("Adiós Mundo!");
                break;
            case 3:
                Console.WriteLine("Hasta luego!");
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }

    public void LimpiarPantalla()
    {
        Console.Clear();
    }
}
