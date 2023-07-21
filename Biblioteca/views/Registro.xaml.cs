namespace Biblioteca.views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped_For_SingIn(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("//Seccion");
    }
}