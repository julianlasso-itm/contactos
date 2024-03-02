using HolaMundo;

while (true)
{
    var menu = Menu.Instance;
    menu.MostrarMenu();
    int opcion = menu.SeleccionarOpcion();
    menu.EjecutarOpcion(opcion);
    if (opcion == 0)
    {
        break;
    }
}
