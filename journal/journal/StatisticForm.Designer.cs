namespace journal
{
    partial class StatisticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cancelFilterJurnalButton = new System.Windows.Forms.Button();
            this.buttonStatiscics = new System.Windows.Forms.Button();
            this.listJournal = new System.Windows.Forms.ListView();
            this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loginUserColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topicColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewStatistics = new System.Windows.Forms.ListView();
            this.UserLogginColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountStatColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.finishFilterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.beginFilterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стастистика";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 55);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.Controls.Add(this.cancelFilterJurnalButton);
            this.panel5.Controls.Add(this.buttonStatiscics);
            this.panel5.Location = new System.Drawing.Point(162, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(448, 64);
            this.panel5.TabIndex = 16;
            // 
            // cancelFilterJurnalButton
            // 
            this.cancelFilterJurnalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cancelFilterJurnalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelFilterJurnalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.cancelFilterJurnalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancelFilterJurnalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelFilterJurnalButton.ForeColor = System.Drawing.Color.Black;
            this.cancelFilterJurnalButton.Location = new System.Drawing.Point(209, 13);
            this.cancelFilterJurnalButton.Name = "cancelFilterJurnalButton";
            this.cancelFilterJurnalButton.Size = new System.Drawing.Size(136, 23);
            this.cancelFilterJurnalButton.TabIndex = 19;
            this.cancelFilterJurnalButton.Text = "Отменить фильтрацию";
            this.cancelFilterJurnalButton.UseVisualStyleBackColor = false;
            // 
            // buttonStatiscics
            // 
            this.buttonStatiscics.Location = new System.Drawing.Point(209, 36);
            this.buttonStatiscics.Name = "buttonStatiscics";
            this.buttonStatiscics.Size = new System.Drawing.Size(136, 23);
            this.buttonStatiscics.TabIndex = 4;
            this.buttonStatiscics.Text = "Вывести статистику";
            this.buttonStatiscics.UseVisualStyleBackColor = true;
            // 
            // listJournal
            // 
            this.listJournal.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listJournal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.loginUserColumnHeader,
            this.topicColumnHeader,
            this.dateColumnHeader});
            this.listJournal.FullRowSelect = true;
            this.listJournal.GridLines = true;
            this.listJournal.HideSelection = false;
            this.listJournal.Location = new System.Drawing.Point(4, 131);
            this.listJournal.Name = "listJournal";
            this.listJournal.Size = new System.Drawing.Size(592, 303);
            this.listJournal.TabIndex = 3;
            this.listJournal.UseCompatibleStateImageBehavior = false;
            this.listJournal.View = System.Windows.Forms.View.Details;
            this.listJournal.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listJournal_ColumnWidthChanging);
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Text = "ИД";
            // 
            // loginUserColumnHeader
            // 
            this.loginUserColumnHeader.Text = "Пользователь";
            // 
            // topicColumnHeader
            // 
            this.topicColumnHeader.Text = "Тема";
            // 
            // dateColumnHeader
            // 
            this.dateColumnHeader.Text = "Дата";
            // 
            // listViewStatistics
            // 
            this.listViewStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listViewStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserLogginColumn,
            this.CountStatColumn});
            this.listViewStatistics.FullRowSelect = true;
            this.listViewStatistics.GridLines = true;
            this.listViewStatistics.HideSelection = false;
            this.listViewStatistics.Location = new System.Drawing.Point(602, 131);
            this.listViewStatistics.Name = "listViewStatistics";
            this.listViewStatistics.Size = new System.Drawing.Size(178, 303);
            this.listViewStatistics.TabIndex = 5;
            this.listViewStatistics.UseCompatibleStateImageBehavior = false;
            this.listViewStatistics.View = System.Windows.Forms.View.Details;
            this.listViewStatistics.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewStatistics_ColumnWidthChanging);
            // 
            // UserLogginColumn
            // 
            this.UserLogginColumn.Text = "Пользователь";
            // 
            // CountStatColumn
            // 
            this.CountStatColumn.Text = "Кол-во дел";
            this.CountStatColumn.Width = 65;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.buttonStatistics);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.finishFilterDateTimePicker);
            this.panel2.Controls.Add(this.beginFilterDateTimePicker);
            this.panel2.Location = new System.Drawing.Point(130, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 64);
            this.panel2.TabIndex = 16;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(383, 17);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(136, 23);
            this.buttonExit.TabIndex = 21;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.ForeColor = System.Drawing.Color.Black;
            this.buttonStatistics.Location = new System.Drawing.Point(209, 35);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(136, 23);
            this.buttonStatistics.TabIndex = 20;
            this.buttonStatistics.Text = "Вывод статистики";
            this.buttonStatistics.UseVisualStyleBackColor = false;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(209, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Отменить фильтрацию";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finishFilterDateTimePicker
            // 
            this.finishFilterDateTimePicker.Location = new System.Drawing.Point(3, 38);
            this.finishFilterDateTimePicker.Name = "finishFilterDateTimePicker";
            this.finishFilterDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.finishFilterDateTimePicker.TabIndex = 18;
            this.finishFilterDateTimePicker.Value = new System.DateTime(2021, 8, 22, 0, 0, 0, 0);
            this.finishFilterDateTimePicker.ValueChanged += new System.EventHandler(this.finishFilterDateTimePicker_ValueChanged);
            // 
            // beginFilterDateTimePicker
            // 
            this.beginFilterDateTimePicker.Location = new System.Drawing.Point(3, 6);
            this.beginFilterDateTimePicker.Name = "beginFilterDateTimePicker";
            this.beginFilterDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.beginFilterDateTimePicker.TabIndex = 16;
            this.beginFilterDateTimePicker.Value = new System.DateTime(2021, 8, 22, 0, 0, 0, 0);
            this.beginFilterDateTimePicker.ValueChanged += new System.EventHandler(this.beginFilterDateTimePicker_ValueChanged);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listViewStatistics);
            this.Controls.Add(this.listJournal);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticForm";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listJournal;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader loginUserColumnHeader;
        private System.Windows.Forms.ColumnHeader topicColumnHeader;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
        private System.Windows.Forms.Button buttonStatiscics;
        private System.Windows.Forms.ListView listViewStatistics;
        private System.Windows.Forms.ColumnHeader UserLogginColumn;
        private System.Windows.Forms.ColumnHeader CountStatColumn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button cancelFilterJurnalButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker finishFilterDateTimePicker;
        private System.Windows.Forms.DateTimePicker beginFilterDateTimePicker;
        private System.Windows.Forms.Button buttonExit;
    }
}