using Biblioteca.ViewModels;

namespace Biblioteca.views;

public partial class Inicio : ContentPage
{
	public Inicio()
	{
		InitializeComponent();
		BindingContext = new MyBreakFastsViewModel();
	}
}