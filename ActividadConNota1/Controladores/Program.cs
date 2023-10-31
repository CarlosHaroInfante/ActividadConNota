using ActividadConNota1.Servicios;

class Program
{
    static void Main(string[] args)
    {
        NumeroInterfaz num = new NumeroImplementacion();
        int a = num.Mes();
        int b = num.año();

       bool cerrarMenu = false;

        MenuInterfaz menu = new MenuImplementacion();
        int c = menu.menu();
        //int opcionElegida;

        while (!cerrarMenu)
        {
            c = menu.menu();
            Console.WriteLine(c);
            

            switch (c)
            {
                case 0:
                    Console.WriteLine("[INFO] - Se cerrará el programa");
                    cerrarMenu = true;
                    break;
                case 1:
                    Console.WriteLine("[INFO] - Volver ha realizar");
                    cerrarMenu = false;
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    break; 
                default:
                    Console.WriteLine("No ha elegido una opción valida");
                    break;
            }
        }
    
    }
}
