﻿using ConnectionDatabase.Domain.Enums;
using System;

namespace ConnectionDatabase.Domain.Models
{
    public class Settings
    {
        public Settings(string server, string database, string user, string password, int serverTypeSbo)
        {
            Server = server;
            Database = database;
            User = user;
            Password = password;
            ServerTypeSbo = serverTypeSbo;

            Validate();
        }

        public Settings(string server, string database, string user, string password, string userSbo, string passwordSbo, int serverTypeSbo, string companyDb)
        {
            Server = server;
            Database = database;
            User = user;
            Password = password;
            UserSbo = userSbo;
            PasswordSbo = passwordSbo;
            CompanyDb = companyDb;
            ServerTypeSbo = serverTypeSbo;

            Validate();
            ValidateSbo();
        }

        public string Server { get; }
        public string Database { get; }
        public string User { get; }
        public string Password { get; }
        public string UserSbo { get; }
        public string PasswordSbo { get; }
        public string CompanyDb { get; set; }
        public int ServerTypeSbo { get; private set; }
        public EServerType ServerTypeSboEnum
        {
            get { return (EServerType)ServerTypeSbo; }
            set { ServerTypeSbo = (int)value; }
        }

        private void Validate()
        {
            if (EServerType.None.Equals(ServerTypeSboEnum))
                throw new Exception("Tipo de servidor não informado");

            if (string.IsNullOrEmpty(Server))
                throw new Exception("Servidor não informado");

            if (string.IsNullOrEmpty(Database) && !EServerType.Hana.Equals(ServerTypeSboEnum))
                throw new Exception("Banco de dados não informado");

            if (string.IsNullOrEmpty(User))
                throw new Exception("Usuário não informado");

            if (string.IsNullOrEmpty(Password))
                throw new Exception("Senha não informada");
        }

        private void ValidateSbo()
        {
            if (string.IsNullOrEmpty(UserSbo))
                throw new Exception("Usuário SAP não informado");

            if (string.IsNullOrEmpty(PasswordSbo))
                throw new Exception("Senha SAP não informada");

            if (string.IsNullOrEmpty(CompanyDb))
                throw new Exception("Empresa não informada");
        }
    }
}
