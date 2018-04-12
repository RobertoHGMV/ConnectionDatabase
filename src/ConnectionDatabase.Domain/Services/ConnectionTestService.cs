using System.Data;
using System.Data.SqlClient;
using ConnectionDatabase.Domain.Models;
using SAPbobsCOM;

namespace ConnectionDatabase.Domain.Services
{
    public class ConnectionTestService : IConnectionTestService
    {
        public string LastErrorSbo { get; set; }

        public bool IsConnectedDatabase(Settings settings)
        {
            using (var conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(settings);
                conn.Open();

                return conn.State == ConnectionState.Open;
            }
        }

        public bool IsConnectedSbo(Settings settings)
        {
            LastErrorSbo = string.Empty;
            Company company = new Company();

            company.Server = settings.Server;
            company.CompanyDB = settings.Database;
            company.DbUserName = settings.User;
            company.DbPassword = settings.Password;
            company.DbServerType = (BoDataServerTypes)settings.ServerTypeSbo;

            company.UserName = settings.UserSbo;
            company.Password = settings.PasswordSbo;

            company.UseTrusted = false;
            company.language = BoSuppLangs.ln_Portuguese_Br;
            company.XmlExportType = BoXmlExportTypes.xet_ExportImportMode;

            var connected = company.Connect() == 0;

            if (!connected) SetLastErrorSbo(company);

            return connected;
        }

        private string GetConnString(Settings settings)
        {
            return $"Data Source={settings.Server};" +
                   $"Initial Catalog={settings.Database};" +
                   $"User id={settings.User};" +
                   $"Password={settings.Password};";
        }

        private void SetLastErrorSbo(Company company)
        {
            LastErrorSbo = "Erro ao conectar no sap:" +
                           $"[{company.GetLastErrorCode()}] - [{company.GetLastErrorDescription()}]";
        }
    }
}
