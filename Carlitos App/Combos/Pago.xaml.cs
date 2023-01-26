namespace Carlitos_App.Combos;

public partial class Pago : ContentPage
{
	public Pago()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        colleciontView.ItemsSource = await App.carlitosDb.GetOrder();
    }
    async void btnLimpiar(object sender, EventArgs e)
    {
        await App.carlitosDb.DeleteAll();
        colleciontView.ItemsSource = await App.carlitosDb.GetOrder();
        await DisplayAlert("Borrar", "Se ha eliminado exitosamente", "Ok");
    }
    async void btnEliminarLista(object sender, EventArgs e)
    {
        string id = ((MenuItem)sender).CommandParameter.ToString();
        var articulo = await App.carlitosDb.GetComboID(Convert.ToInt32(id));
        await App.carlitosDb.DeleteProduct(articulo);
        await DisplayAlert("Borrar", "Se ha eliminado exitosamente", "Ok");
        colleciontView.ItemsSource = await App.carlitosDb.GetOrder();
    }
}