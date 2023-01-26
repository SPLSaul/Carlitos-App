using Carlitos_App.Conexion;
namespace Carlitos_App.Combos;

public partial class FantasiCombo : ContentPage
{
	public FantasiCombo()
	{
		InitializeComponent();
	}
    async void btnAgregar(object sender, EventArgs e)
    {
        await App.carlitosDb.SaveProduct(new CarlosAtributos
        {
            Name = "Fantasi Combo",
            Precio = 219
        });
        await DisplayAlert("Agregado", "Producto agregado", "Ok");
    }
}