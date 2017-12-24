using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entities;

namespace Infrastructure.Libraries {
	public class Connectivity {
		public string generateConnectionString(Connection connection) {
			string con = "";

			switch(connection.rdbms) {
				case "SQL Server":
					//TODO: Create string
					break;
				case "MySQL Workbench":
					break;
				default:
					//TODO: Throw ERROR
					break;
			}

			return con;
		}
	}
}
