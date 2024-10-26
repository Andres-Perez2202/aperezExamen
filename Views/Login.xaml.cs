namespace aperezExamen.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
      
        string estudiante = "estudiante2024";
        string uisrael = "uisrael2024";
        string examen = "examen1";
        string parcial = "parcial1";
        string nombre = "NombreEstudiante";
        string year = "2024";

       
        if (EstudianteEntry.Text == estudiante &&
            UisraelEntry.Text == uisrael &&
            ExamenlEntry.Text == examen &&
            ParcialEntry.Text == parcial &&
            NombreEntry.Text == nombre &&
            YaerEntry.Text == year)
        {
           
            await Navigation.PushAsync(new Registro());
        }
        else
        {
            
            await DisplayAlert("Error", "Usuario y contraseña incorrecto", "OK");
        }
    }
}