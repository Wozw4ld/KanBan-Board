using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBan.DataAccess.Models
{
	public class DeviceEntity
	{
		public Guid Id { get; set; }
		public int DeviceModel {  get; set; } = 0;
		public string DeviceKey {  get; set; } = string.Empty;
		public DateTime LastLogin { get; set; } = DateTime.Now;
		public bool IsActive { get; set; } = false;
		public Guid UserId { get; set; }
		public UserEntity? User { get; set; }

	}
}
