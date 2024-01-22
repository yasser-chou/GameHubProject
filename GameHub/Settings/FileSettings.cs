using static System.Net.Mime.MediaTypeNames;

namespace GameHub.Settings
{
	public static class FileSettings
	{
		public const string ImagePath = "/assets/images/games";
		public const string AllowedExtensions = ".jpg,.jpeg,.png";
		public const int MaxFileSizeinMB=5;
		public const int MaxFileSizeinBytes = MaxFileSizeinMB*1024*1024;
	}
}
