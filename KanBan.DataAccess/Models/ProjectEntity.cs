namespace KanBan.DataAccess.Models
{
	public class ProjectEntity
	{
		public Guid Id {  get; set; }
		public Guid AdminId { get; set; }
		public string Title { get; set; } = string.Empty;
		public List<ProjectEntity>? Projects { get; set; }
		public List<UserProjectEntity>? Users { get; set; }

	}
}
