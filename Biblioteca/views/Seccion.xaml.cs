namespace Biblioteca.views;

public partial class Seccion : ContentPage
{
	public Seccion()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped_For_SignUp(object sender, TappedEventArgs e)
    {
		await Shell.Current.GoToAsync("//Registro");
    }
}