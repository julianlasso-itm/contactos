using HolaMundo.DataBase.Models;
using HolaMundo.Operations;
using HolaMundo.Operations.AddContact;
using HolaMundo.Operations.ListContacts;

namespace HolaMundo;

public class Menu
{
    private static Menu? _instance;
    private OperationHandler<Contact>? _operationHandler;
    private readonly DataBase.DataBase _dataBase;

    private Menu(DataBase.DataBase dataBase)
    {
        _dataBase = dataBase;
    }

    public static Menu Instance
    {
        get
        {
            if (_instance == null)
            {
                var dataBase = new DataBase.DataBase();
                _instance = new Menu(dataBase);
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
        if (opcion >= 1 && opcion <= 2)
        {
            ConfigureOperationHandler(opcion);
            _operationHandler?.Operate();
        }
        else if (opcion == 0)
        {
            Console.WriteLine("Salir del sistema!");
        }
        else
        {
            Console.WriteLine("Opción inválida");
        }
    }

    public void LimpiarPantalla()
    {
        Console.Clear();
    }

    private void ConfigureOperationHandler(int opcion)
    {
        if (opcion == 1)
        {
            _operationHandler = new ListContactsHandler(_dataBase);
        }
        else if (opcion == 2)
        {
            _operationHandler = new AddContactHandler(_dataBase);
        }
    }
}
