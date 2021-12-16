using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectISC
{
    public class DatabaseConnector
    {
        public SqlConnection connection;

        public DatabaseConnector()
        {
            connection = new SqlConnection("Data Source =LAPTOP-B6M8UUTC; Initial Catalog =ISC; Integrated Security=SSPI");
            connection.Open();
        }

        public Student[] GetStudents()
        {
            var studentList = connection.Query<Student>(
                "usp_GetStudents",
                commandType: CommandType.StoredProcedure);
            return studentList.ToArray();
        }

        public Visits[] GetStudentVisits()
        {
            var visitsList = connection.Query<Visits>(
                "usp_GetStudentVisits",
                commandType: CommandType.StoredProcedure);
            return visitsList.ToArray();
        }
    }
}
