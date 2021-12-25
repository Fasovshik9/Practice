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

    public partial class AuthorizationForm : Form
    {
        const string phraseLogin = "Введите логин";
        const string phrasePass = "Введите пароль";
        //private MySqlConnection sqlConnection = null;
        public AuthorizationForm()
        {
            InitializeComponent();
            loginFild.Text = phraseLogin;
            passFild.Text = phrasePass;
            passFild.ForeColor = Color.Gray;
            loginFild.ForeColor = Color.Gray;
            label1.Select();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string loginUser = loginFild.Text;
            string passUser = passFild.Text;
            string idValueUser;
            string privilegeUser;
            //UserPass = passFild.Text;
            try
            {
                MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `userlog` WHERE `login` = @uL AND `pass` = @uP", sqlConnection);

                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);



                if (loginFild.Text == phraseLogin || passFild.Text == phrasePass)
                {
                    MessageBox.Show("Введите логин и пароль!");
                    return;
                }
                else
                {
                    if (table.Rows.Count > 0)
                    {
                        Hide();
                        using (MainForm MainForm = new MainForm())
                        {
                            idValueUser = Convert.ToString(table.Rows[0].ItemArray[0]);
                            privilegeUser = Convert.ToString(table.Rows[0].ItemArray[3]);
                            MainForm.userNameLabel.Text = this.loginFild.Text;
                            //MainForm.oldUserPass = passFild.Text;
                            MainForm.idValueUser = idValueUser;
                            MainForm.privilegeUser = privilegeUser;
                            MainForm.ShowDialog();
                        }
                        Show();
                    }
                    else
                    {
                        MessageBox.Show("Неправльный логин или пароль!");
                    }
                        
                }
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Error message:\n" + ex.Message, "Unable to connect to database!",
                MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
            try
            { 
                sqlConnection.Open();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Error message:\n" + ex.Message, "Unable to connect to database!",
                MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            finally
            {
                sqlConnection.Close();
            }
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

        private void AuthorizationForm_Activated(object sender, EventArgs e)
        {
            passFild.Text = phrasePass;
            passFild.ForeColor = Color.Gray;
            passFild.UseSystemPasswordChar = false;
            loginFild.Text = phraseLogin;
            loginFild.ForeColor = Color.Gray;
        }
    }
}
