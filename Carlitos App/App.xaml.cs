using Carlitos_App.Conexion;
namespace Carlitos_App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    private static Database carlosDB;    //Base de Datos 
    public static Database carlitosDb
    {
        get
        {
            if (carlosDB == null)
            {
                carlosDB = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Carlos.db3"));
            }
            return carlosDB;
        }
    }
}
