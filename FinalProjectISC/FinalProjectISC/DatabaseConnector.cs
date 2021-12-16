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
            connection = new SqlConnection("Data Source =NIZ17; Initial Catalog =ISCDatabase; Integrated Security=SSPI");
            connection.Open();
        }

        // Getter Functions
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
        
        /*
        public Events[] GetEvents()
        {
            var eventslist = connection.Query<Events>(
                "usp_GetEvents",
                commandType: CommandType.StoredProcedure);
            return eventslist.ToArray();
        }
        */

        public Clubs[] GetClubs()
        {
            var clubsList = connection.Query<Clubs>(
                "usp_GetClubs",
                commandType: CommandType.StoredProcedure);
            return clubsList.ToArray();
        }

        public LoginInfo[] GetLoginInfo(string ID, string Pwd)
        {
            var loginInfo = connection.Query<LoginInfo>(
                "usp_CheckLogin @ID = " + ID + " @Pwd = " + Pwd,
                commandType: CommandType.StoredProcedure);
                return loginInfo.ToArray();
        }

        public bool checkLogin(string ID, string Pwd)
        {
            LoginInfo[] count = GetLoginInfo(ID, Pwd);
            if (count.Length > 0)
            {
                return true;
            } else
            {
                return false;
            }

        }

    }
}
