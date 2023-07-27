using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
	/// <summary>
	/// 
	/// </summary>
	/// <param name="Name">Nombre del libro</param>
	/// <param name="Description"> Descripcion del libro</param>
	/// <param name="StartDateTime"></param>
	/// <param name="EndDatetime"></param>
	/// <param name="Image">Imagen del libro</param>
	/// <param name="Savory">Categoria</param>
	/// <param name="Sweet">Categoria Principal</param>
	public record Breakfast
   (
	   string Name,
	   string Description,
	   DateTime StartDateTime,
	   DateTime EndDatetime,
	   Uri Image,
	   List<string> Savory,
	   List<string> Sweet

   );
}
