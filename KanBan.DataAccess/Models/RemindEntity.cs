using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBan.DataAccess.Models
{
	public class RemindEntity
	{
		public Guid Id { get; set; }
		public DateTime Time {  get; set; }
		public Guid UserId {  get; set; }
	}
}
