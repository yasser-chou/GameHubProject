namespace GameHub.Services
{
	public interface ICategoriesService
	{
		 IEnumerable<SelectListItem> GetSelectList();
	}
}
