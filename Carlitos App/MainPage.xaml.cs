namespace Carlitos_App;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

    private void btnIngresar_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Usuario.Text) && !string.IsNullOrEmpty(Contraseña.Text))
        {
            string user = "Saul";
            string password = "carlos123";
            if (Usuario.Text != user && Contraseña.Text != password)
            {
                DisplayAlert("Error", "Usuario o contraseña incorrectos", "Ok");
            }
            else
            {
                DisplayAlert("Inicio", $"Bienvenido {user}", "Ok");
                Navigation.PushAsync(new MenuCombos());
            }
        }
        else if (Usuario.Text == null || Contraseña.Text == null)
        {
            //DisplayAlert("Error", "No hay valores ingresados", "Ok");
            Navigation.PushAsync(new MenuCombos());
        }
    }
}

