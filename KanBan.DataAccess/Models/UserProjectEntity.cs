namespace KanBan.DataAccess.Models
{
	public class UserProjectEntity
	{
		public Guid Id {  get; set; }
		public Guid UserId {  get; set; }
		public Guid ProjectId {  get; set; }
		public int UserRole {  get; set; }

	}	
}
