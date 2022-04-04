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
    public partial class ChangeThingForm : Form
    {
        const string phraseComment = "Введите комментарий";
        const string phraseTopic = "Введите тему";

        public string userNameForReadOnly;
        public string idChangeThing;
        public string privilageUserAddThing;
        MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);


        public ChangeThingForm()
        {
            InitializeComponent();
        }

        private void buttonChangeThing_Click(object sender, EventArgs e)
        {
            if (topicField.Text == phraseTopic || commentField.Text == phraseComment)
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
                return;
            }
            string usersLogin;
            string topic = topicField.Text;
            string comment = commentField.Text;
            string thingId = idFild.Text;

            //MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
            string theDate = dateTimePicker.Value.ToString("yyyy-MM-dd");

            string query = "UPDATE `usersjournal` " +
                "SET `loginUser`=@uL,`topic`=@T,`comment`=@C,`date`=('" + theDate + "') " +
                "WHERE id = @Id";
            
            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
            if (privilageUserAddThing == "admin")
            {
                usersLogin = usersLoginComboBox.Text;
            }
            else usersLogin = usersLoginFild.Text;



            commandDatabase.Parameters.Add("@uL", MySqlDbType.VarChar).Value = usersLogin;
            commandDatabase.Parameters.Add("@T", MySqlDbType.VarChar).Value = topic;
            commandDatabase.Parameters.Add("@C", MySqlDbType.VarChar).Value = comment;
            commandDatabase.Parameters.Add("@Id", MySqlDbType.VarChar).Value = thingId;


            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            if (topicField.TextLength >= 1 && commentField.TextLength >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите применить изменения?", "Удаление задачи", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
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
                    this.Close();
                }
            }
            else MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
        }

        private void ChangeThingForm_Load(object sender, EventArgs e)
        {

            topicField.Text = phraseTopic;
            commentField.Text = phraseComment;
            commentField.ForeColor = Color.Black;
            topicField.ForeColor = Color.Black;
            label1.Select();

            if (privilageUserAddThing == "admin")
            {
                usersLoginComboBox.Items.Clear();
                usersLoginComboBox.ResetText();

                //idFild.Text = idChangeThing;
                
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
                sqlConnection.Close();
                usersLoginFild.Visible = false;
            }

            idFild.Text = idChangeThing;
            MySqlCommand command = new MySqlCommand("SELECT * FROM `usersjournal` WHERE id = @Id", sqlConnection);
            command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = idChangeThing;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (privilageUserAddThing == "admin")
            {
                usersLoginComboBox.Text = Convert.ToString(table.Rows[0].ItemArray[1]);
            }
            else
            {
                usersLoginComboBox.Visible = false;
                usersLoginFild.Text = Convert.ToString(table.Rows[0].ItemArray[1]);
                if (userNameForReadOnly == usersLoginFild.Text)
                {
                    buttonChangeThing.Enabled = true;
                    dateTimePicker.Enabled = true;
                    topicField.ReadOnly = false;
                    commentField.ReadOnly = false;
                }
                else
                {
                    buttonChangeThing.Enabled = false;
                    dateTimePicker.Enabled = false;
                    topicField.ReadOnly = true;
                    commentField.ReadOnly = true;
                }
            }
            
            topicField.Text = Convert.ToString(table.Rows[0].ItemArray[2]);
            commentField.Text = Convert.ToString(table.Rows[0].ItemArray[3]);
            dateTimePicker.Text = Convert.ToString(table.Rows[0].ItemArray[4]);

            this.usersLoginComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
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
