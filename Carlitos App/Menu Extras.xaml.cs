using Carlitos_App.Conexion;
using Carlitos_App.Combos;
namespace Carlitos_App;

public partial class Menu_Extras : ContentPage
{
	public Menu_Extras()
	{
		InitializeComponent();
	}
	async void btnCebolla(object sender, EventArgs e)
	{
        await App.carlitosDb.SaveProduct(new CarlosAtributos
        {
            Name = "Aros de cebolla",
            Precio = 69
        });
        await DisplayAlert("Agregado", "Producto Agregado", "Ok");
    }
    async void btnCaesar(object sender, EventArgs e)
    {
        await App.carlitosDb.SaveProduct(new CarlosAtributos
        {
            Name = "Ensalada Caeasar",
            Precio = 79
        });
        await DisplayAlert("Agregado", "Producto Agregado", "Ok");
    }
    async void btnFries(object sender, EventArgs e)
    {
        await App.carlitosDb.SaveProduct(new CarlosAtributos
        {
            Name = "Papas n' Cheese",
            Precio = 89
        });
        await DisplayAlert("Agregado", "Producto Agregado", "Ok");
    }
    async void btnNuggets(object sender, EventArgs e)
    {
        await App.carlitosDb.SaveProduct(new CarlosAtributos
        {
            Name = "Star Nuggets",
            Precio = 59
        });
        await DisplayAlert("Agregado", "Producto Agregado", "Ok");
    }
    async void btnPastel(object sender, EventArgs e)
    {
        await App.carlitosDb.SaveProduct(new CarlosAtributos
        {
            Name = "Pastel",
            Precio = 49
        });
        await DisplayAlert("Agregado", "Producto Agregado", "Ok");
    }
    async void btnWings(object sender, EventArgs e)
    {
        await App.carlitosDb.SaveProduct(new CarlosAtributos
        {
            Name = "Chicken Wings",
            Precio = 89
        });
        await DisplayAlert("Agregado", "Producto Agregado", "Ok");
    }
    private void btnPagar(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pago());
    }
}