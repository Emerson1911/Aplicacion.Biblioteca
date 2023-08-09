using Biblioteca.Shopping;
using Biblioteca.ViewModels;

namespace Biblioteca.views;

public partial class Inicio : ContentPage
{
	public Inicio()
	{
		InitializeComponent();
		BindingContext = new MyBreakFastsViewModel();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Shop_Book_1());
    }
}