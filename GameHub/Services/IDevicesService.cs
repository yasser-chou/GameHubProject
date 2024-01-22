namespace GameHub.Services
{
	public interface IDevicesService
	{
		IEnumerable<SelectListItem> GetSelectList();
	}
}
