using Carlitos_App.Combos;
namespace Carlitos_App;

public partial class MenuCombos : ContentPage
{
	public MenuCombos()
	{
		InitializeComponent();
	}
    private void btnCEstudiante(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CEstudiante());
    }
    private void btnAmigosPollo(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AmigosPollo());
    }
    private void btnCMania(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CarlosMania1());
    }
    private void btnCFantasi(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FantasiCombo());
    }
    private void btnCInfantil(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CInfantil());
    }
    private void btnPagar(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pago());
    }
}