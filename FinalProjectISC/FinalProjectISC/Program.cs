using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace FinalProjectISC
{
    public class DatabaseConnector
    {
        SqlConnection connection;

        DatabaseConnector()
        {
            connection =  new SqlConnection("Data Source =LAPTOP-B6M8UUTC; Initial Catalog =ISC; Integrated Security=SSPI");
            connection.Open();
        }

        Student[] GetStudents()
        {
            var studentList = connection.Query<Student>(
                "usp_GetStudents",
                commandType: CommandType.StoredProcedure);
            return studentList.ToArray();
        }
        static void Main(string[] args)
        {
            var newconn = new DatabaseConnector();
            var xt = newconn.GetStudents();
            Console.WriteLine(xt); 


        }
    }
}
