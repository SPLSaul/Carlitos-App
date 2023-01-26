using Carlitos_App.Conexion;
namespace Carlitos_App.Combos;

public partial class CEstudiante : ContentPage
{
	public CEstudiante()
	{
		InitializeComponent();
	}
    async void btnAgregar(object sender, EventArgs e)
    {
        await App.carlitosDb.SaveProduct(new CarlosAtributos
        {
            Name = "Combo Estudiante",
            Precio = 79
        });
        await DisplayAlert("Agregado", "Producto agregado", "Ok");
    }
}