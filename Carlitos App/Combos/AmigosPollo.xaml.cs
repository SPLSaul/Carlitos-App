using Carlitos_App.Conexion;
namespace Carlitos_App.Combos;
public partial class AmigosPollo : ContentPage
{
	public AmigosPollo()
	{
		InitializeComponent();
	}
    async void btnAgregar(object sender, EventArgs e)
    {
        await App.carlitosDb.SaveProduct(new CarlosAtributos
        {
            Name = "Combo Amigos Pollo",
            Precio = 185
        });
        await DisplayAlert("Agregado", "Producto agregado", "Ok");
    }
}