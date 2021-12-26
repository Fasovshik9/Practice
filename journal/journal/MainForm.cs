using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace journal
{
    public partial class MainForm : Form
    {
        //try
        private ChangeUserForm ChangeUserForm = new ChangeUserForm();
        private ChangeThingForm ChangeThingForm = new ChangeThingForm();

        private List<string[]> rowsJournal = new List<string[]>();
        private List<string[]> rowsUser = new List<string[]>();
        private List<string[]> filteredList = null;

        private string loginUserForDelete;
        public string idValueMouse;
        public string idValueUser;
        public string privilegeUser;
        private bool exitValue = true;
        private MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);

        const string phraseNewPass = "Введите пароль";
        const string phraseOldPass = "Введите старый пароль";
        const string phraseRepPass = "Введите новый пароль";

        public MainForm()
        {
            InitializeComponent();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addUsers add_Users = new addUsers();
            add_Users.ShowDialog();
            RefreshListRegister(sqlConnection);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userNameProfileLabel.Text = userNameLabel.Text;
            idColumnHeader.Width = 50;
            loginUserColumnHeader.Width = 100;
            topicColumnHeader.Width = 530;
            dateColumnHeader.Width = 70;

            UsersIdColumnHeader.Width = 50;
            UsersLoginColumnHeader.Width = 90;
            UsersPassColumnHeader.Width = 90;
            UsersPrivilegeColumnHeader.Width = 80;


            RefreshListRegister(sqlConnection);
            RefreshListJournal(sqlConnection);
            if (privilegeUser == "user")
            {
                mainTabControl.TabPages.Remove(RegisterTabPage);
            }

            mainTabControl.SelectedIndex += 1;
            mainTabControl.SelectedIndex -= 1;
            this.usersLoginComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            oldUserPassFild.Text = phraseOldPass;
            newUserPassFild.Text = phraseNewPass;
            repitUserPassFild.Text = phraseRepPass;

            oldUserPassFild.UseSystemPasswordChar = newUserPassFild.UseSystemPasswordChar = repitUserPassFild.UseSystemPasswordChar = false;

            repitUserPassFild.ForeColor  = newUserPassFild.ForeColor = oldUserPassFild.ForeColor = Color.Gray;


            
        }

        private void RefreshListRegister(List<string[]> list)
        {
            listRegister.Items.Clear();
            foreach (string[] s in list)
            {
                listRegister.Items.Add(new ListViewItem(s));
            }
        }

        private void RefreshListJournal(List<string[]> list)
        {
            listJournal.Items.Clear();
            foreach (string[] s in list)
            {
                listJournal.Items.Add(new ListViewItem(s));
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void RefreshListRegister(MySqlConnection sqlConnection)
        {
            rowsUser.Clear();
            MySqlDataReader dataReader = null;
            string[] row;
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM userlog", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dataReader["id"]),
                        Convert.ToString(dataReader["login"]),
                        Convert.ToString(dataReader["pass"]),
                        Convert.ToString(dataReader["privilege"])
                    };
                    rowsUser.Add(row);
                }       
                sqlConnection.Close();
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            RefreshListRegister(rowsUser);
        }
        private void RefreshListJournal(MySqlConnection sqlConnection)
        {
            rowsJournal.Clear();
            MySqlDataReader dataReader = null;
            string[] row;
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM usersjournal", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {

                    row = new string[]
                    {

                        Convert.ToString(dataReader["id"]),
                        Convert.ToString(dataReader["loginUser"]),
                        Convert.ToString(dataReader["topic"]),
                        Convert.ToString(dataReader["date"]),
                };
                    row[3] = DateTime.Parse(row[3]).ToShortDateString();    //genius on vadim
                    rowsJournal.Add(row);
                }
                sqlConnection.Close();
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            RefreshListJournal(rowsJournal);
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void listRegister_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listRegister.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                this.idValueMouse = item.SubItems[0].Text;
                ChangeUserForm.loginFild.Text = item.SubItems[1].Text;
                ChangeUserForm.passFild.Text = item.SubItems[2].Text;
                ChangeUserForm.privilegeComboBox.Text = item.SubItems[3].Text;
            }
            else
            {
                this.listRegister.SelectedItems.Clear();
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.listRegister.SelectedItems.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить пользователя?", "Удалить пользователя", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string idUserMouse = idValueMouse;
                    string query = "DELETE FROM `userlog` WHERE `id` = @uIM";
                    MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                    commandDatabase.Parameters.Add("@uIM", MySqlDbType.VarChar).Value = idUserMouse;

                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    try
                    {
                        sqlConnection.Open();
                        reader = commandDatabase.ExecuteReader();
                        // Succesfully deleted
                        sqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    RefreshListRegister(sqlConnection);
                }
            }
            else
            {
                MessageBox.Show("Выберете строку в таблице!");
            }

            //DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the user?", "Delete user", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{

            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    //do something else
            //} 
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (this.listRegister.SelectedItems.Count != 0)
            {
                ChangeUserForm.idFild.Text = idValueMouse;
                ChangeUserForm.ShowDialog();
                RefreshListRegister(sqlConnection);
            }
            else
            {
                MessageBox.Show("Выберете строку в таблице!");
            }
        }

        private void buttonChangeNewUserPass_Click(object sender, EventArgs e)
        {
            if (oldUserPassFild.Text == phraseOldPass || newUserPassFild.Text == phraseNewPass || newUserPassFild.Text == phraseRepPass)
            {
                MessageBox.Show("Все поля должны быть заполнены!");
                return;
            }
            string idUser = idValueUser;
            string newUserPass = newUserPassFild.Text;
            string oldUserPassword;

            string query = "UPDATE `userlog` SET `pass`= @uP WHERE id = @uI";
            MySqlCommand command = new MySqlCommand("SELECT * FROM `userlog` WHERE id = @uI", sqlConnection);
            MySqlDataReader reader;
            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
            commandDatabase.Parameters.Add("@uP", MySqlDbType.VarChar).Value = newUserPass;
            commandDatabase.Parameters.Add("@uI", MySqlDbType.VarChar).Value = idUser;
            command.Parameters.Add("@uI", MySqlDbType.VarChar).Value = idUser;
            commandDatabase.CommandTimeout = 60;

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            oldUserPassword = Convert.ToString(table.Rows[0].ItemArray[2]);


            if (oldUserPassFild.Text != "" && newUserPassFild.Text != "" && repitUserPassFild.Text != "")
            {
                if (oldUserPassword == oldUserPassFild.Text)
                {
                    if (oldUserPassword != newUserPassFild.Text)
                    {
                        if (newUserPassFild.Text == repitUserPassFild.Text)
                        {
                            if (newUserPassFild.TextLength >= 5)
                            {
                                try
                                {
                                    sqlConnection.Open();
                                    reader = commandDatabase.ExecuteReader();
                                    // Succesfully updated
                                    sqlConnection.Close();
                                    MessageBox.Show("Вы успешно изменили ваш пароль!");
                                }
                                catch (Exception ex)
                                {
                                    // Ops, maybe the id doesn't exists ?
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else MessageBox.Show("Пароль слишком короткий! минимум 5 знаков");
                        }
                        else MessageBox.Show("Введенный второй раз пароль не совпадает!");
                    }
                    else MessageBox.Show("Старый и новый пароль одинаковые!");
                }
                else MessageBox.Show("Вы ввели неверный старый пароль!");
            }
            else MessageBox.Show("Все поля должны быть заполнены!");
            oldUserPassword = newUserPassFild.Text;
            oldUserPassFild.Text = phraseOldPass;
            newUserPassFild.Text = phraseNewPass;
            repitUserPassFild.Text = phraseRepPass;
            repitUserPassFild.ForeColor = newUserPassFild.ForeColor = oldUserPassFild.ForeColor = Color.Gray;
            oldUserPassFild.UseSystemPasswordChar = newUserPassFild.UseSystemPasswordChar = repitUserPassFild.UseSystemPasswordChar = false;
        }

        private void buttonAddNewThing_Click(object sender, EventArgs e)
        {
            AddNewThing addNewThing = new AddNewThing();
            addNewThing.privilageUserAddThing = privilegeUser;
            addNewThing.loginUser = userNameLabel.Text;
            addNewThing.ShowDialog();
            RefreshListJournal(sqlConnection);
        }

        private void listJournal_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listJournal.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                this.idValueMouse = item.SubItems[0].Text;
                this.loginUserForDelete = item.SubItems[1].Text;
            }
            else
            {
                this.listJournal.SelectedItems.Clear();
            }

        }

        private void buttonDeletThing_Click(object sender, EventArgs e)
        {
            if (this.listJournal.SelectedItems.Count != 0)
            {
                if ((loginUserForDelete == userNameLabel.Text && privilegeUser == "user") || privilegeUser == "admin")
                {
                    DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить выполненное дело?", "Delete user", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string idUserMouse = idValueMouse;
                        string query = "DELETE FROM `usersjournal` WHERE id = @uIM";
                        MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                        commandDatabase.CommandTimeout = 60;
                        commandDatabase.Parameters.Add("@uIM", MySqlDbType.VarChar).Value = idUserMouse;
                        MySqlDataReader reader;
                        try
                        {
                            sqlConnection.Open();
                            reader = commandDatabase.ExecuteReader();
                           // Succesfully deleted
                            sqlConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            // Ops, maybe the id doesn't exists ?
                            MessageBox.Show(ex.Message);
                        }
                        RefreshListJournal(sqlConnection);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    MessageBox.Show("Это не выше выполненное дело!"); 
                }
            }
            else
            { 
                MessageBox.Show("Выберете строку в таблице!"); 
            }        
        }

        private void buttonChangeNewThing_Click(object sender, EventArgs e)
        {
            if (this.listJournal.SelectedItems.Count != 0)
            {
                //if ((loginUserForDelete == userNameLabel.Text && privilegeUser == "user") || privilegeUser == "admin")
                //{
                    ChangeThingForm.idChangeThing = idValueMouse;
                    ChangeThingForm.privilageUserAddThing = privilegeUser;
                    ChangeThingForm.userNameForReadOnly = userNameLabel.Text;
                    ChangeThingForm.ShowDialog();
                    RefreshListJournal(sqlConnection);
               // }    
                //else
                //{
                //    MessageBox.Show("This thing isnt your!");
                //}
            }
            else
            {
                MessageBox.Show("Выберете строку в таблице!");
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void filterThingFild_TextChanged(object sender, EventArgs e)
        {
            filteredList = rowsJournal.Where(x =>
            (x[0].ToLower().Contains(filterThingFild.Text.ToLower())) ||
            (x[1].ToLower().Contains(filterThingFild.Text.ToLower())) ||
            (x[2].ToLower().Contains(filterThingFild.Text.ToLower()))
            ).ToList();
            RefreshListJournal(filteredList);
        }
        private void filterRegFild_TextChanged(object sender, EventArgs e)
        {
            filteredList = rowsUser.Where(x =>
                (x[0].ToLower().Contains(filterRegFild.Text.ToLower())) ||
                (x[1].ToLower().Contains(filterRegFild.Text.ToLower())) ||
                (x[2].ToLower().Contains(filterRegFild.Text.ToLower())) ||
                (x[3].ToLower().Contains(filterRegFild.Text.ToLower()))
            ).ToList();
            RefreshListRegister(filteredList);
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void listJournal_DoubleClick(object sender, EventArgs e)
        {
            if (this.listJournal.SelectedItems.Count != 0)
            {
                //if ((loginUserForDelete == userNameLabel.Text && privilegeUser == "user") || privilegeUser == "admin")
                //{
                ChangeThingForm.idChangeThing = idValueMouse;
                ChangeThingForm.privilageUserAddThing = privilegeUser;
                ChangeThingForm.userNameForReadOnly = userNameLabel.Text;
                ChangeThingForm.ShowDialog();
                RefreshListJournal(sqlConnection);
                // }    
                //else
                //{
                //    MessageBox.Show("This thing isnt your!");
                //}
            }
            else
            {
                MessageBox.Show("Выберете строку в таблице!");
            }
        }

        private void listRegister_DoubleClick(object sender, EventArgs e)
        {
            buttonChange.PerformClick();
        }

        private void filterDateButton_Click(object sender, EventArgs e)
        {
            filteredList = rowsJournal.Where(x =>
            DateTime.Parse(x[3]) >= (beginFilterDateTimePicker.Value) &&
            DateTime.Parse(x[3]) <= (finishFilterDateTimePicker.Value)
            ).ToList();
            RefreshListJournal(filteredList);
        }

        private void cancelFilterJurnalButton_Click(object sender, EventArgs e)
        {
            filterThingFild.Text = "";
            usersLoginComboBox.SelectedIndex = -1;
            RefreshListJournal(sqlConnection);
        }

        private void cancelFilterRegButton_Click(object sender, EventArgs e)
        {
            filterRegFild.Text = "";
            RefreshListRegister(sqlConnection);
        }
        private void exitFromUserButton_Click(object sender, EventArgs e)
        {
            exitValue = false;
            this.Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exitValue == true)
            {
                Environment.Exit(0);
            }
            this.Close();
        }

        private void mainTabControl_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("select * from userlog order by login", sqlConnection);
            sqlConnection.Open();
            MySqlDataReader reader;
            reader = com.ExecuteReader();
            usersLoginComboBox.Items.Clear();
            usersLoginComboBox.ResetText();
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
            //usersLoginComboBox.Text = loginUser;
            sqlConnection.Close();
            usersLoginComboBox.SelectedIndex = -1;
            RefreshListRegister(sqlConnection);


            oldUserPassFild.Text = phraseOldPass;
            newUserPassFild.Text = phraseNewPass;
            repitUserPassFild.Text = phraseRepPass;
            oldUserPassFild.UseSystemPasswordChar = newUserPassFild.UseSystemPasswordChar = repitUserPassFild.UseSystemPasswordChar = false;
            repitUserPassFild.ForeColor = newUserPassFild.ForeColor = oldUserPassFild.ForeColor = Color.Gray;
        }

        private void usersLoginComboBox_TextChanged(object sender, EventArgs e)
        {
            filteredList = rowsJournal.Where(x =>
                    (x[1].ToLower().Contains(usersLoginComboBox.Text.ToLower()))
                    ).ToList();
            RefreshListJournal(filteredList);
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (System.IO.TextWriter tw = new System.IO.StreamWriter(@"C:\Users\vadim\Desktop\listViewContent.txt"))
                {
                    foreach (ListViewItem item in listJournal.Items)
                    {
                        //tw.WriteLine(item.Text);
                        for (int a = 2; a <= 2; a++) //the 3 = number of subitems in a listview 
                        {
                            tw.Write(item.SubItems[a].Text);
                        }
                        tw.WriteLine();
                    }
                }
            }
            catch
            {
                MessageBox.Show("TEXT FILE NOT FOUND");
            }
        }

        private void oldUserPassFild_Enter(object sender, EventArgs e)
        {
            if (oldUserPassFild.Text == phraseOldPass)
            {
                oldUserPassFild.Text = "";
                oldUserPassFild.ForeColor = Color.Black;
            }
            oldUserPassFild.UseSystemPasswordChar = true;
        }

        private void oldUserPassFild_Leave(object sender, EventArgs e)
        {
            if (oldUserPassFild.Text == "")
            {
                oldUserPassFild.Text = phraseOldPass;
                oldUserPassFild.ForeColor = Color.Gray;
                oldUserPassFild.UseSystemPasswordChar = false;
            }
        }

        private void newUserPassFild_Enter(object sender, EventArgs e)
        {
            if (newUserPassFild.Text == phraseNewPass)
            {
                newUserPassFild.Text = "";
                newUserPassFild.ForeColor = Color.Black;
            }
            newUserPassFild.UseSystemPasswordChar = true;
        }

        private void newUserPassFild_Leave(object sender, EventArgs e)
        {
            if (newUserPassFild.Text == "")
            {
                newUserPassFild.Text = phraseNewPass;
                newUserPassFild.ForeColor = Color.Gray;
                newUserPassFild.UseSystemPasswordChar = false;
            }
        }

        private void repitUserPassFild_Enter(object sender, EventArgs e)
        {
            if (repitUserPassFild.Text == phraseRepPass)
            {
                repitUserPassFild.Text = "";
                repitUserPassFild.ForeColor = Color.Black;
                repitUserPassFild.UseSystemPasswordChar = true;
            }
            
        }

        private void repitUserPassFild_Leave(object sender, EventArgs e)
        {
            if (repitUserPassFild.Text == "")
            {
                repitUserPassFild.Text = phraseRepPass;
                repitUserPassFild.ForeColor = Color.Gray;
                repitUserPassFild.UseSystemPasswordChar = false;
            }
        }
///
        private void mainTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = mainTabControl.TabPages[e.Index];
            e.Graphics.FillRectangle(new SolidBrush(page.BackColor), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, Font, paddedBounds, page.ForeColor);
        
        }
    }

}
