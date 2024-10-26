namespace aperezExamen.Views;

public partial class Resumen : ContentPage
{
	public Resumen()
	{
		InitializeComponent();
	}

    public void SetResumenData(string nombre, string apellido, string va, string ciudad, string montoInicial, string cuotaMensual, string pagoTotal)
    {
        NombreEntry.Text = nombre;
        ApellidoEntry.Text = apellido;
        VAEntry.Text = va;
        CiudadEntry.Text = ciudad;
        MontoEntry.Text = montoInicial;
        CuotaEntry.Text = cuotaMensual;
        TotalEntry.Text = pagoTotal;
    }
    private async void btnCerrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Login());
    }
}