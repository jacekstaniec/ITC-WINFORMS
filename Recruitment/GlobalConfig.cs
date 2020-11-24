using Recruitment.DataAccess;
using Recruitment.Models;

namespace Recruitment
{
    public static class GlobalConfig
    {
        public static HeaderModel NewHeader = null;
        public static ArticleModel NewArticle = null;


        public static readonly float VAT = 1.23f;

        internal static IDataConnection Connection { get; private set; }

        internal static void InitializeConnection()
        {
            SqlConnector sql = new SqlConnector();
            Connection = sql;
        }

        public static string ConnectionStr()
        {
            return "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" + System.IO.Path.GetFullPath("Recruitment.mdf") + "; Integrated Security = True";
//            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
