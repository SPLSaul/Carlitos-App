using Carlitos_App.Conexion;
namespace Carlitos_App.Combos;

public partial class CInfantil : ContentPage
{
	public CInfantil()
	{
		InitializeComponent();
	}
    async void btnAgregar(object sender, EventArgs e)
    {
        await App.carlitosDb.SaveProduct(new CarlosAtributos
        {
            Name = "Combo Infantil",
            Precio = 89
        });
        await DisplayAlert("Agregado", "Producto agregado", "Ok");
    }
}