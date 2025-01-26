namespace KanBan.DataAccess.Models
{
	public class TaskColumnEntity
	{
		public Guid Id {  get; set; }
		public Guid ProjectId { get; set; }
		public string Title { get; set; } = string.Empty;
		public int PositionId { get; set; }
		public bool IsPrivate { get; set; } = false;


	}	
}
