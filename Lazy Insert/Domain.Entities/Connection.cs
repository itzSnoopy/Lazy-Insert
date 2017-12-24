using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
	public class Connection {
		//Relational Database Management System (ex: SQL Server)
		//TODO: Specify year?
		public string rdbms { get; set; }

		//User database login (ex: root)
		public string user { get; set; }

		//User database password (ex: sql)
		public string password { get; set; }

		//Database to connect to (ex: master)
		public string database { get; set; }

		//Server to connect to (ex: localhost:8810)
		//TODO: Separate port?
		public string server { get; set; }
	}
}
