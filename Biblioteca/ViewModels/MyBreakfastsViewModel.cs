using Biblioteca.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ViewModels
{
	public partial class MyBreakFastsViewModel : ObservableObject
	{

		/// <summary>
		/// Hacemos una lista de la clase Breakfast que es encuentra en la Carpeta Models
		/// </summary>
		[ObservableProperty]
		List<Breakfast> breakfasts;

		public MyBreakFastsViewModel()
		{
			LoadBreakfasts();
		}
		/// <summary>
		/// Usamos las propiedades de la Clase Brearkfast para darles sus caracteristicas al apartado de Inicio
		/// </summary>
		/// 
		[RelayCommand]
		public void LoadBreakfasts()
		{
			Breakfasts = new()
				{

					new Breakfast(
					Name: "Principio",
					Description: "Novela de Antoine de Saint-Exupéry " +
					"$100",
					StartDateTime: DateTime.UtcNow.AddDays(1),
					EndDatetime: DateTime.UtcNow.AddDays(1).AddHours(2),
					Image: new Uri("https://cdn.culturagenial.com/es/imagenes/el-principito-portada-cke.jpg"),
					Savory: new List<string> { "Ficcion especulativa", "Novela filosófica", "novela infantil", "Fabula", "Novela Corta" },
					Sweet: new List<string> { "Novela" }
					),

					new Breakfast(
					Name: "Bajo la misma estrella " ,
					Description: "Novela de John Green" +
					" $500",
					StartDateTime: DateTime.UtcNow.AddDays(5),
					EndDatetime: DateTime.UtcNow.AddHours(2),
					Image: new Uri("https://cdn.culturagenial.com/es/imagenes/bajo-la-misma-estrella-portada-0-cke.jpg"),
					Savory: new List<string> { "Novela Rosa", "Ficcion de adolecentes", "Literatura", "Novela Compenporanea", "Narrativa Extranjera" },
					Sweet: new List<string> { "Novela" }
					),

					new Breakfast(
					Name: "La Lanza del Emprerador",
					Description: "warhammer 40k " + " $700",
					StartDateTime: DateTime.UtcNow.AddDays(5),
					EndDatetime: DateTime.UtcNow.AddHours(2),
					Image: new Uri("https://www.estudioenescarlata.com/media/img/portadas/_visd_0001JPG01K1F.jpg"),
					Savory: new List<string> { "Fantacia", "Combate de Fantacia", "Accion", "Guerra" },
					Sweet: new List<string> { "Ciencia Ficcion" }
					)

				};
		}







	}
}
