using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLoginSel.AccessDataExel
{
     class ExelDataAccess
    {
        public static string TestDataFileConnection()
        {
            var fileName = ConfigurationManager.AppSettings["testdatapath"];
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);
            return con;
        }

        public static UserData GetTestData(string LoginTest)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [Sheet1$] where key='{0}'", LoginTest);
                var value = connection.Query<UserData>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }

         //internal static object GetTestData(object testName)
         //{
         //    throw new NotImplementedException();
         //}
    }
}
