

using GameHub.Attributes;
using System.Runtime.CompilerServices;

namespace GameHub.ViewModels
{
	public class CreateGameFormViewModel : GameFormViewModel
	{
		

		//validate extension and size
		[AllowedExtensions(FileSettings.AllowedExtensions),
			MaxFileSize(FileSettings.MaxFileSizeinBytes)]
		public IFormFile Cover { get; set; } = default!;


	}
}
