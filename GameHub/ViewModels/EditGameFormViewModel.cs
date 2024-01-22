using GameHub.Attributes;

namespace GameHub.ViewModels
{
	public class EditGameFormViewModel : GameFormViewModel
	{
		public int Id { get; set; }
		public string? CurrentCover { get; set; }

		//validate extension and size
		[AllowedExtensions(FileSettings.AllowedExtensions),
			MaxFileSize(FileSettings.MaxFileSizeinBytes)]
		public IFormFile? Cover { get; set; } = default!;
	}
}
