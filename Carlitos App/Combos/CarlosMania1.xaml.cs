using Carlitos_App.Conexion;
namespace Carlitos_App.Combos;

public partial class CarlosMania1 : ContentPage
{
	public CarlosMania1()
	{
		InitializeComponent();
	}
    async void btnAgregar(object sender, EventArgs e)
    {
        await App.carlitosDb.SaveProduct(new CarlosAtributos
        {
            Name = "Combo Carlos Mania",
            Precio = 199
        });
        await DisplayAlert("Agregado", "Producto agregado", "Ok");
    }
}