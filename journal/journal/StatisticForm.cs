﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace journal
{
    public partial class StatisticForm : Form
    {
        private MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
        private List<string[]> rowsJournal = new List<string[]>();
        private List<string[]> filteredList = null;
        
        public StatisticForm()
        {
            InitializeComponent();
        }
        private void StatisticForm_Load(object sender, EventArgs e)
        {
            RefreshListJournal(sqlConnection);
            idColumnHeader.Width = 50;
            loginUserColumnHeader.Width = 100;
            topicColumnHeader.Width = 360;
            dateColumnHeader.Width = 70;

            UserLogginColumn.Width = 100;
            CountStatColumn.Width = 70;
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

        private void RefreshListJournal(List<string[]> list)
        {
            listJournal.Items.Clear();
            foreach (string[] s in list)
            {
                listJournal.Items.Add(new ListViewItem(s));
            }
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            listViewStatistics.Items.Clear();
            int countDelt = 0;
            int column2 = 0;
            int delt = 2;
            List<string> twoColumn = new List<string>();
            List<string> listStatistic = new List<string>();


            //count all isers name
            foreach (ListViewItem s in listJournal.Items)
            {
                twoColumn.Add(s.SubItems[1].Text);
            }
            twoColumn = twoColumn.Distinct().ToList();  //only unic valies
            foreach (var item in twoColumn)
            {
                countDelt = listJournal.Items.Cast<ListViewItem>().Where(x => x.SubItems[1].Text.ToString() == item).Count();
                listStatistic.Add(item);
                listStatistic.Add(countDelt.ToString());
            }
            foreach (var item in listStatistic)
            {
                delt++;
                if (delt % 2 == 1)
                {
                    column2 = listViewStatistics.Items.Add(item).Index;
                }
                else
                {
                    listViewStatistics.Items[column2].SubItems.Add(item);
                }

            }
        }

        private void listJournal_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listJournal.Columns[e.ColumnIndex].Width;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewStatistics_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listViewStatistics.Columns[e.ColumnIndex].Width;
        }

        private void finishFilterDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            filteredList = rowsJournal.Where(x =>
                    DateTime.Parse(x[3]) >= (beginFilterDateTimePicker.Value) &&
                    DateTime.Parse(x[3]) <= (finishFilterDateTimePicker.Value)
                    ).ToList();
            RefreshListJournal(filteredList);
        }

        private void beginFilterDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            filteredList = rowsJournal.Where(x =>
                    DateTime.Parse(x[3]) >= (beginFilterDateTimePicker.Value) &&
                    DateTime.Parse(x[3]) <= (finishFilterDateTimePicker.Value)
                    ).ToList();
            RefreshListJournal(filteredList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshListJournal(sqlConnection);
        }
    }
}