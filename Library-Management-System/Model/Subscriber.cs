using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	[Table("Subscribers")]
	public class Subscriber
	{
		[Column("subscriber_id")]
		public int Id { get; set; }
		[Column("username")]
		public string UserName { get; set; }
		[Column("password")]
		public string Password { get; set; }
		[Column("name")]
		public string Name { get; set; }

		public Subscriber()
		{
			Id = -1;
			UserName = "";
			Password = "";
			Name = "";
		}

		public Subscriber(int id)
		{
			Id = id;
			UserName = "";
			Password = "";
			Name = "";
		}

		public Subscriber(int id, string userName, string password, string name)
		{
			Id = id;
			UserName = userName;
			Password = password;
			Name = name;
		}

		public Subscriber(string userName, string password, string name)
		{
			UserName = userName;
			Password = password;
			Name = name;
		}
	}
}
