namespace KanBan.DataAccess.Models
{
	public class TaskEntity
	{
		public Guid Id {  get; set; }
		public Guid ColumnId { get; set; } 
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public DateTime Date {  get; set; }
		public List<TaskActionEntity>? Actions {  get; set; }
		
	}	

}
