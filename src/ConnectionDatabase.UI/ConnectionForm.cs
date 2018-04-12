﻿using System;
using System.Windows.Forms;
using ConnectionDatabase.Domain.Models;
using ConnectionDatabase.Domain.Services;

namespace ConnectionDatabase.UI
{
    public partial class ConnectionForm : MetroFramework.Forms.MetroForm
    {
        private readonly IConnectionTestService _connectionService;

        public ConnectionForm(IConnectionTestService connectionTestService)
        {
            InitializeComponent();
            _connectionService = connectionTestService;
            FormatServerType();
        }

        #region Messages

        private void MessageSuccess(string message = "Operação realizada com sucesso!")
        {
            MessageBox.Show(message, "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MessageError(string message)
        {
            MessageBox.Show(message, "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        private void FormatServerType()
        {
            var serverTypes = new[]
            {
                new { Id = 1, Description = "MySql" },
                new { Id = 4, Description = "Sql Server 2005" },
                new { Id = 6, Description = "Sql Server 2008" },
                new { Id = 7, Description = "Sql Server 2012" },
                new { Id = 8, Description = "Sql Server 2014" },
                new { Id = 10, Description = "Sql Server 2016" },
                new { Id = 9, Description = "Hana" }
            };

            cbServerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbServerType.DataSource = serverTypes;
            cbServerType.ValueMember = "Id";
            cbServerType.DisplayMember = "Description";
        }

        private Settings CreateSettings()
        {
            return new Settings(txtServer.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text);
        }

        private Settings CreateSettingsSbo()
        {
            var serverType = (int) cbServerType.SelectedValue;

            return new Settings(
                txtServer.Text,
                txtDatabase.Text,
                txtUser.Text,
                txtPassword.Text,
                txtUserSbo.Text,
                txtPasswordSbo.Text,
                serverType);
        }

        private bool StartTest()
        {
            var settings = CreateSettings();
            return _connectionService.IsConnectedDatabase(settings);
        }

        private bool StarTestSbo()
        {
            var settings = CreateSettingsSbo();
            return _connectionService.IsConnectedSbo(settings);
        }

        private void btnConTest_Click(object sender, EventArgs e)
        {
            try
            {
                btnConTest.Enabled = false;

                if (StartTest())
                    MessageSuccess();
                else
                    MessageError("Conexão não realizada");
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
            finally
            {
                btnConTest.Enabled = true;
            }
        }

        private void btnConnTestSbo_Click(object sender, EventArgs e)
        {
            try
            {
                btnConnTestSbo.Enabled = false;
                if (StarTestSbo())
                    MessageSuccess();
                else
                    MessageError(_connectionService.LastErrorSbo);
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
            finally
            {
                btnConnTestSbo.Enabled = true;
            }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }
    }
}