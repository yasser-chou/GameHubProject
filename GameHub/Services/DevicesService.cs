
namespace GameHub.Services
{
	public class DevicesService : IDevicesService
	{
		private readonly ApplicationDbContext _context;

		public DevicesService(ApplicationDbContext context)
		{
			_context = context;
		}

		IEnumerable<SelectListItem> IDevicesService.GetSelectList()
		{
			return _context.Devices
				.Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name })
				.OrderBy(d => d.Text) // Order by the Text property, not Id
				.AsNoTracking()
				.ToList();
		}
	}
}
