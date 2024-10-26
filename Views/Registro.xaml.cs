namespace aperezExamen.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private async void btnResumen_Clicked(object sender, EventArgs e)
    {
       
        var resumenPage = new Resumen();

        
        resumenPage.SetResumenData(
            NombreEEntry.Text,
            ApellidoEEntry.Text,
        pkValores.SelectedItem?.ToString() ?? "",
            pkCiudades.SelectedItem?.ToString() ?? "",
            MontoInicial.Text,
            "89.25",   
            "312.75"    
        );

        
        await Navigation.PushAsync(resumenPage);
    }

    private async void btnAcercade_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Acerca de", "Este programa fue realizado por Andrés Pérez Codutti", "OK");
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {

    }
}