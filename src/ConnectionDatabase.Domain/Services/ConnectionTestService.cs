using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using ConnectionDatabase.Domain.Enums;
using ConnectionDatabase.Domain.Helpers;
using ConnectionDatabase.Domain.Models;
using SAPbobsCOM;

namespace ConnectionDatabase.Domain.Services
{
    public class ConnectionTestService : IConnectionTestService
    {
        public string LastErrorSbo { get; set; }

        public bool IsConnectedDatabase(Settings settings)
        {
            switch ((EServerType)settings.ServerTypeSbo)
            {
                case EServerType.Hana:
                    return IsConnectedHana(settings);
                default:
                    return IsConnectedSqlServer(settings);
            }
        }

        private bool IsConnectedSqlServer(Settings settings)
        {
            bool connected;

            using (var conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(settings);
                conn.Open();
                connected = ConnectionState.Open.Equals(conn.State);
                conn.Close();
            }

            return connected;
        }

        private bool IsConnectedHana(Settings settings)
        {
            bool connected;

            using (var conn = DbProviderFactories.GetFactory("Sap.Data.Hana").CreateConnection())
            {
                conn.ConnectionString = GetConnStringHana(settings);
                conn.Open();
                connected = ConnectionState.Open.Equals(conn.State);
                conn.Close();
            }

            //using (var conn = new HanaConnection())

            return connected;
        }

        public bool IsConnectedSbo(Settings settings)
        {
            LastErrorSbo = string.Empty;
            Company company = new Company();

            company.Server = settings.Server;
            company.CompanyDB = settings.CompanyDb;
            company.DbUserName = settings.User;
            company.DbPassword = settings.Password;
            company.DbServerType = (BoDataServerTypes)settings.ServerTypeSbo;

            company.UserName = settings.UserSbo;
            company.Password = settings.PasswordSbo;

            company.UseTrusted = false;
            company.language = BoSuppLangs.ln_Portuguese_Br;
            company.XmlExportType = BoXmlExportTypes.xet_ExportImportMode;

            var connected = decimal.Zero.Equals(company.Connect());

            if (!connected) SetLastErrorSbo(company);

            return connected;
        }

        private string GetConnString(Settings settings)
        {
            var connStr = new SqlConnectionStringBuilder();
            connStr.DataSource = settings.Server;
            connStr.InitialCatalog = settings.Database;
            connStr.UserID = settings.User;
            connStr.Password = settings.Password;
            return connStr.ToString();

            //return $"Data Source={settings.Server};" +
            //       $"Initial Catalog={settings.Database};" +
            //       $"User id={settings.User};" +
            //       $"Password={settings.Password};";
        }

        private string GetConnStringHana(Settings settings)
        {
            var server = $"{ ConnectionHelper.SubStringUntilTheEnd(settings.Server, "@").Replace("@", string.Empty) }";
            var database = settings.Server.Contains("@")
                ? $"Database={ConnectionHelper.SubStringStartUntil(settings.Database, "@").Replace("@", string.Empty)}"
                : string.Empty;

            return $"Server={server};" +
                   $"UserName={settings.User};" +
                   $"Password={settings.Password};" +
                   database;

            //var connStr = new HanaConnectionStringBuilder();
            //connStr.Server = settings.Server;
            //connStr.CurrentSchema = settings.Database;
            //connStr.UserName = settings.User;
            //connStr.Password = settings.Password;
            //return connStr.ToString();
            //@"Server=hanab1:30015;Initial Catalog=SBODEMOBR;databaseName=NDB;UserID=system;Password=Ramo2278";
        }

        private void SetLastErrorSbo(Company company)
        {
            LastErrorSbo = "Erro ao conectar no sap:" +
                           $"[{company.GetLastErrorCode()}] - [{company.GetLastErrorDescription()}]";
        }
    }
}
