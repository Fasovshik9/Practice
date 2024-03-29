﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace journal
{
    public partial class addUsers : Form
    {
        const string phraseLogin = "Введите логин";
        const string phrasePass = "Введите пароль";

        public addUsers()
        {
            InitializeComponent();
            loginFild.Text = phraseLogin;
            passFild.Text = phrasePass;
            zeroFildsLogin();
            zeroFildsPass();
            label1.Select();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (loginFild.Text == phraseLogin || passFild.Text == phrasePass)
            {
                MessageBox.Show("Все поля должны быть заполенны !");
                return;
            }
            ///////////////////////////////////////////////////////////////////////////// check new user to reapit
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `userlog` WHERE login = @uL", sqlConnection);
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginFild.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Этот пользователь уже существует!\nИзменить логин!", "Ошибка");
                return;
            }
            /////////////////////////////////////////////////////////////////////////////
            string userLogin = loginFild.Text;
            string userPass = passFild.Text;
            string userPrivilege = privilegeComboBox.Text;

           

            string query = "INSERT INTO userlog(`id`, `login`, `pass`, `privilege`) " +
                "VALUES (NULL, @uL, @uP, @uPr)";
            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);

            commandDatabase.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
            commandDatabase.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPass;
            commandDatabase.Parameters.Add("@uPr", MySqlDbType.VarChar).Value = userPrivilege;

            commandDatabase.CommandTimeout = 60;
            if (loginFild.TextLength <= 12 && loginFild.TextLength >= 5) 
            {
                if (passFild.TextLength >= 5)
                {
                    try
                    {
                        sqlConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        MessageBox.Show("Пользователь успешно зарегистрирован!", "Уведомление");
                        sqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }
                    this.Close();
                }
                else MessageBox.Show("Пароль пользователя слишком короткий!\nМинимум 5 знаков!", "Ошибка");
            }
            else MessageBox.Show("Некоректное имя пользователя!\nМинимум 5 знаков и максимум 12!", "Ошибка");
        }

        private void addUsers_Load(object sender, EventArgs e)
        {
            this.privilegeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            privilegeComboBox.SelectedIndex = 0;
        }

        private void cencelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zeroFildsPass()
        {
            passFild.Text = phrasePass;
            passFild.ForeColor = Color.Gray;
            passFild.UseSystemPasswordChar = false;
        }
        private void zeroFildsLogin()
        {
            loginFild.Text = phraseLogin;
            loginFild.ForeColor = Color.Gray;
        }

        private void loginFild_Enter(object sender, EventArgs e)
        {
            if (loginFild.Text == phraseLogin)
            {
                loginFild.Text = "";
                loginFild.ForeColor = Color.Black;
            }
        }

        private void loginFild_Leave(object sender, EventArgs e)
        {
            if (loginFild.Text == "")
            {
                zeroFildsLogin();
            }
        }

        private void passFild_Enter(object sender, EventArgs e)
        {
            if (passFild.Text == phrasePass)
            {
                passFild.Text = "";
                passFild.ForeColor = Color.Black;
                passFild.UseSystemPasswordChar = true;
            }
        }

        private void passFild_Leave(object sender, EventArgs e)
        {
            if (passFild.Text == "")
            {
                zeroFildsPass();
            }
        }
    }
}
