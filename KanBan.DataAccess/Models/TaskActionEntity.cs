namespace KanBan.DataAccess.Models
{
	public class TaskActionEntity
	{
		public Guid Id {  get; set; }
		public Guid UserId {  get; set; }
		public Guid TaskId { get; set; } 
		public string Action { get; set; } = string.Empty;
		public DateTime Date {  get; set; }
		
	}	

}
