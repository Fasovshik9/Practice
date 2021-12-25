using MySql.Data.MySqlClient;
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
    public partial class ChangeUserForm : Form
    {
        const string phraseLogin = "Введите логин";
        const string phrasePass = "Введите пароль";

        public ChangeUserForm()
        {
            InitializeComponent();
            passFild.UseSystemPasswordChar = true;
        }

        private void changeUserButton_Click(object sender, EventArgs e)
        {
            if (loginFild.Text == phraseLogin || passFild.Text == phrasePass)
            {
                MessageBox.Show("All lines must fill in!");
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
                MessageBox.Show("This account already exists!\nChange login");
                return;
            }
            /////////////////////////////////////////////////////////////////////////////
            string userLogin = loginFild.Text;
            string userPass = passFild.Text;
            string userPrivilege = privilegeComboBox.Text;
            string userId = idFild.Text;
            //MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
            string query = "UPDATE `userlog` " +
                "SET `login`=@uL,`pass`=@uP,`privilege`=@uPr " +
                "WHERE id = @uId";
            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
            commandDatabase.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
            commandDatabase.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPass;
            commandDatabase.Parameters.Add("@uPr", MySqlDbType.VarChar).Value = userPrivilege;
            commandDatabase.Parameters.Add("@uId", MySqlDbType.VarChar).Value = userId;

            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            if (loginFild.TextLength >= 7)
            {
                if (passFild.TextLength >= 7)
                {
                    try
                    {
                        sqlConnection.Open();
                        reader = commandDatabase.ExecuteReader();
                        // Succesfully updated
                        sqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Ops, maybe the id doesn't exists ?
                        MessageBox.Show(ex.Message);
                    }
                }
                else MessageBox.Show("User pass too short! min 7 char");
            }
            else MessageBox.Show("User name too short! min 7 char");
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeUserForm_Load(object sender, EventArgs e)
        {
            this.privilegeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
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
                loginFild.Text = phraseLogin;
                loginFild.ForeColor = Color.Gray;
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
                passFild.Text = phrasePass;
                passFild.ForeColor = Color.Gray;
                passFild.UseSystemPasswordChar = false;
            }
        }
    }
}
