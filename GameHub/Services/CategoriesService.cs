

namespace GameHub.Services
{
	public class CategoriesService : ICategoriesService
	{
		private readonly ApplicationDbContext _context;
		

		public CategoriesService(ApplicationDbContext context)
		{
			_context = context;
		
		}
		IEnumerable<SelectListItem> ICategoriesService.GetSelectList()
		{
			return _context.categories.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
				.OrderBy(c => c.Text)
				.AsNoTracking()
				.ToList();
		}

	
	}
}
