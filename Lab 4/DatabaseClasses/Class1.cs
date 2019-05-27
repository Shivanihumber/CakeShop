using CakeClasses;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace DatabaseClasses
{
	public class CustomerInformationTable

	{
		private OracleConnection oracleConnection;
		private OracleCommand oracleCommand;
		private OracleDataReader oracleDataReader;
		private const string HOST = "calvin.humber.ca";
		private const string SID = "grok";
		internal const string PASSWORD = "oracle";
		private const string USER_ID = "n01249114";

		private static readonly string strCONNECTIONSTRING = string.Format("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)" +
															"(HOST={0})(PORT=1521))(CONNECT_DATA=(SID={1}))); " +
															"PASSWORD={2}; USER ID={3}", HOST, SID, PASSWORD, USER_ID);


		public CustomerInformationTable()
		{
			try
			{
				oracleConnection = new OracleConnection(strCONNECTIONSTRING);
				oracleCommand = new OracleCommand();
				oracleCommand.Connection = oracleConnection;
				oracleConnection.Open();
				CreateData(oracleCommand);
			}
			catch (Exception objException)
			{
				throw objException;
			}
		}

		public void CreateData(OracleCommand oracleCommand)
		{

			oracleCommand.CommandText = "Create table CustomerInformation(FirstName Varchar2(20), LastName Varchar2(20), Address varchar2(20), City varchar2(20), PostalCode varchar2(20), Province varchar2(20), Mailings varchar2(20))";
			try
			{
				oracleCommand.ExecuteNonQuery();
			}
			catch (Exception objException)
			{
				DropTable(oracleCommand);
				oracleCommand.CommandText = "Create table CustomerInformation (FirstName Varchar2(20), LastName Varchar2(20), Address varchar2(20), City varchar2(20),PostalCode varchar2(20),Province varchar2(20),Mailings varchar2(20))";
				oracleCommand.ExecuteNonQuery();
			}
			
			oracleCommand.CommandText = "INSERT INTO CustomerInformation VALUES('Shivani', 'Sharma','93,Eastview gate','Brampton','Lg6 7hg','Ontario','Y,N,Y')";
			oracleCommand.ExecuteNonQuery();
			oracleCommand.CommandText = "INSERT INTO CustomerInformation VALUES('Deependra', 'Parsad','93,Eastview gate','Brampton','Lg6 7hg','Ontario','N,Y,Y')";
			oracleCommand.ExecuteNonQuery();
			oracleCommand.CommandText = "INSERT INTO CustomerInformation VALUES ('Ferda', 'Ozel','10,Macmohan drive','Toronto','M2k 0kh','Ontario','N,N,Y')";
			oracleCommand.ExecuteNonQuery();
			oracleCommand.CommandText = "INSERT INTO CustomerInformation VALUES('Jasleen', 'Jill','56,Pitker hill','Mississauga','H9u 2kh','Ontario','N,N,N')";
			oracleCommand.ExecuteNonQuery();
			oracleCommand.CommandText = "INSERT INTO CustomerInformation VALUES('Vaishali', 'Gupta','2011,Singer court','Toronto','M3k 8gd','Ontario','Y,Y,Y')";
			oracleCommand.ExecuteNonQuery();
		}
		public Customer GetCustomer(string strLastName)
		{
			string strSQL = "SELECT * from CustomerInformation Where LastName= '" + strLastName+"'";
			Customer myCustomer = new Customer();

			try
			{
				oracleCommand.CommandText = strSQL;
				oracleDataReader = oracleCommand.ExecuteReader();
				if (oracleDataReader.Read())
				{
					myCustomer.LastName = Convert.ToString(oracleDataReader["LastName"]);
					myCustomer.FirstName = Convert.ToString(oracleDataReader["FirstName"]);
					string Street = Convert.ToString(oracleDataReader["Address"]);
					string Mailings = Convert.ToString(oracleDataReader["Mailings"]);
					string[] MailingsValues = Mailings.Split(',');
					myCustomer.Mailings = new List<string>();
					if (MailingsValues[0] == "Y")
					{
						myCustomer.Mailings.Add("Specials");
					}
					if (MailingsValues[1] == "Y")
					{
						myCustomer.Mailings.Add("Events");
					}
					if (MailingsValues[2] == "Y")
					{
						myCustomer.Mailings.Add("Bookings");
					}
					string City = Convert.ToString(oracleDataReader["City"]);
					string Province = Convert.ToString(oracleDataReader["Province"]);
					string PostCode = Convert.ToString(oracleDataReader["PostalCode"]);
					myCustomer.Address = new Address(Street, City, Province, PostCode);
					
				}
				else
				{
					Exception myException = new Exception("Sorry, that record id doesn't exist on the database");
					throw myException;
				}
			}
			catch (Exception objException)
			{
				throw objException;
			}
			return myCustomer;
		}
		public void DropTable(OracleCommand command)
		{
			try
			{
				oracleCommand.CommandText = "drop table CustomerInformation ";
				oracleCommand.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public void Close()
		{
			//need to close connection since Visual Studio no longer
			//seems to do this for us when we close the project
			try
			{
				if (oracleConnection.State != System.Data.ConnectionState.Closed)
				{
					DropTable(oracleCommand);
					oracleConnection.Close();
				}
			}
			catch (Exception objException)
			{
				throw objException;
			}
		}
	}
}