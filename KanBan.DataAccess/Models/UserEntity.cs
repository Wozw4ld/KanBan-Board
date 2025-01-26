using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBan.DataAccess.Models
{
	public class UserEntity
	{
		public Guid Id {  get; set; }
		public string UserName { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public List<DeviceEntity>? Devices { get; set; } 
		public List<UserProjectEntity>? Projects { get; set; }

	}	

}
