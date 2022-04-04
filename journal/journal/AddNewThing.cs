using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace journal
{
    public partial class AddNewThing : Form
    {
        const string phraseComment = "Введите коментарий";
        const string phraseTopic = "Введите тему";

        public string loginUser;
        public string privilageUserAddThing;
        public AddNewThing()
        {
            InitializeComponent();
            topicField.Text = phraseTopic;
            commentField.Text = phraseComment;
            zeroFieldComment();
            zeroFildsTopic();
            label1.Select();
        }

        private void buttonAddNewThing_Click(object sender, EventArgs e)
        {
            if (topicField.Text == phraseTopic || commentField.Text == phraseComment)
            {
                MessageBox.Show("Все поля должны быть заполенны!", "Ошибка");
                return;
            }
            string userLogin = usersLoginComboBox.Text;
            string topic = topicField.Text;
            string comment = commentField.Text;
            string theDate = dateTimePicker.Value.ToString("yyyy-MM-dd");
            if (privilageUserAddThing == "user")
            {
                userLogin = usersLoginField.Text;
            }
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
            
            string query = "INSERT INTO usersjournal(`id`,`loginUser`, `topic`,`comment`, `date`) " +
                "VALUES (NULL, @uL, @T, @C, '" + theDate + "')";
            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);

            commandDatabase.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
            commandDatabase.Parameters.Add("@T", MySqlDbType.VarChar).Value = topic;
            commandDatabase.Parameters.Add("@C", MySqlDbType.VarChar).Value = comment;
           
            commandDatabase.CommandTimeout = 60;
            if (topicField.TextLength >= 1 && commentField.TextLength >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите добавить задачу?", "Удаление задачи", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        sqlConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        MessageBox.Show("Новая задача было добавлено", "Уведомление");
                        sqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }
                    this.Close();
                }
            }
            else MessageBox.Show("Все поля должны быть заполнены !", "Ошибка");

        }

        private void AddNewThing_Load(object sender, EventArgs e)
        {
            usersLoginField.Visible = true;
            usersLoginComboBox.Visible = true;
            this.usersLoginComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (privilageUserAddThing == "admin")
            {
                MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
                MySqlCommand com = new MySqlCommand("select * from userlog order by login", sqlConnection);
                sqlConnection.Open();
                MySqlDataReader reader;
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        string result = reader.GetString(1);
                        usersLoginComboBox.Items.Add(result);
                        usersLoginComboBox.Text = result;
                    }
                    catch { }

                }
                usersLoginComboBox.Text = loginUser;
                sqlConnection.Close();
                usersLoginField.Visible = false;
            }
            else
            {
                usersLoginField.ReadOnly = true;
                usersLoginField.Text = loginUser;
                usersLoginComboBox.Visible = false;
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void zeroFildsTopic()
        {
            topicField.Text = phraseTopic;
            topicField.ForeColor = Color.Gray;
        }
        private void zeroFieldComment()
        {
            commentField.Text = phraseComment;
            commentField.ForeColor = Color.Gray;
        }

        private void topicField_Enter(object sender, EventArgs e)
        {
            if (topicField.Text == phraseTopic)
            {
                topicField.Text = "";
                topicField.ForeColor = Color.Black;
            }
        }

        private void topicField_Leave(object sender, EventArgs e)
        {
            if (topicField.Text == "")
            {
                zeroFildsTopic();
            }
        }

        private void commentField_Enter(object sender, EventArgs e)
        {
            if (commentField.Text == phraseComment)
            {
                commentField.Text = "";
                commentField.ForeColor = Color.Black;
            }
        }

        private void commentField_Leave(object sender, EventArgs e)
        {
            if (commentField.Text == "")
            {
                zeroFieldComment();
            }
        }
    }
}
