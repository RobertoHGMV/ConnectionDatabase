﻿using System;
using System.Windows.Forms;
using ConnectionDatabase.Domain.Enums;
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
            SetEvents();
        }

        #region Events

        private void SetEvents()
        {
            chkIsCcc.CheckedChanged += ChkIsCcc_CheckedChanged;
        }

        private void ChkIsCcc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkIsCcc.Checked)
                {
                    txtDatabase.Enabled = false;
                    txtDatabase.Text = "NDB";
                }
                else
                {
                    txtDatabase.Enabled = true;
                    txtDatabase.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }
        }

        #endregion

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
                new { Id = (int)EServerType.None, Description = "Não definido" },
                //new { Id = (int)EServerType.MySql, Description = "MySql" },
                new { Id = (int)EServerType.Sql_Server_2005, Description = "Sql Server 2005" },
                new { Id = (int)EServerType.Sql_Server_2008, Description = "Sql Server 2008" },
                new { Id = (int)EServerType.Sql_Server_2012, Description = "Sql Server 2012" },
                new { Id = (int)EServerType.Sql_Server_2014, Description = "Sql Server 2014" },
                new { Id = (int)EServerType.Sql_Server_2016, Description = "Sql Server 2016" },
                new { Id = (int)EServerType.Sql_Server_2017, Description = "Sql Server 2017" },
                new { Id = (int)EServerType.Hana, Description = "Hana" }
            };

            cbServerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbServerType.DataSource = serverTypes;
            cbServerType.ValueMember = "Id";
            cbServerType.DisplayMember = "Description";
        }

        private Settings CreateSettings()
        {
            var serverType = (int)cbServerType.SelectedValue;
            return new Settings(txtServer.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text, serverType);
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
                serverType,
                txtCompanyDb.Text);
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

        private void BtnTestClick()
        {
            btnConTest.Enabled = false;

            if (StartTest())
                MessageSuccess();
            else
                MessageError("Conexão não realizada");
        }

        private void btnConTest_Click(object sender, EventArgs e)
        {
            try
            {
                BtnTestClick();
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

        private void BtnTestSboClick()
        {
            btnConnTestSbo.Enabled = false;
            if (StarTestSbo())
                MessageSuccess();
            else
                MessageError(_connectionService.LastErrorSbo);
        }

        private void btnConnTestSbo_Click(object sender, EventArgs e)
        {
            try
            {
                BtnTestSboClick();
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
