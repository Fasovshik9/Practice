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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.finishFilterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.beginFilterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стастистика";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 55);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.Controls.Add(this.cancelFilterJurnalButton);
            this.panel5.Controls.Add(this.buttonStatiscics);
            this.panel5.Location = new System.Drawing.Point(212, 61);
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
            this.listJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJournal.FullRowSelect = true;
            this.listJournal.GridLines = true;
            this.listJournal.HideSelection = false;
            this.listJournal.Location = new System.Drawing.Point(1, 159);
            this.listJournal.Name = "listJournal";
            this.listJournal.Size = new System.Drawing.Size(659, 433);
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
            this.loginUserColumnHeader.Text = "Сотрудник";
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
            this.listViewStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewStatistics.FullRowSelect = true;
            this.listViewStatistics.GridLines = true;
            this.listViewStatistics.HideSelection = false;
            this.listViewStatistics.Location = new System.Drawing.Point(666, 159);
            this.listViewStatistics.Name = "listViewStatistics";
            this.listViewStatistics.Size = new System.Drawing.Size(209, 433);
            this.listViewStatistics.TabIndex = 5;
            this.listViewStatistics.UseCompatibleStateImageBehavior = false;
            this.listViewStatistics.View = System.Windows.Forms.View.Details;
            this.listViewStatistics.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewStatistics_ColumnWidthChanging);
            // 
            // UserLogginColumn
            // 
            this.UserLogginColumn.Text = "Сотрулник";
            this.UserLogginColumn.Width = 95;
            // 
            // CountStatColumn
            // 
            this.CountStatColumn.Text = "Кол-во дел";
            this.CountStatColumn.Width = 98;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.buttonStatistics);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.finishFilterDateTimePicker);
            this.panel2.Controls.Add(this.beginFilterDateTimePicker);
            this.panel2.Location = new System.Drawing.Point(10, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 82);
            this.panel2.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(119, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "конечная дата";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(108, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "начальная дата";
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatistics.ForeColor = System.Drawing.Color.White;
            this.buttonStatistics.Location = new System.Drawing.Point(544, 42);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(229, 30);
            this.buttonStatistics.TabIndex = 20;
            this.buttonStatistics.Text = "Вывод статистики";
            this.buttonStatistics.UseVisualStyleBackColor = false;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(544, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Отменить фильтрацию";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finishFilterDateTimePicker
            // 
            this.finishFilterDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.finishFilterDateTimePicker.Location = new System.Drawing.Point(250, 46);
            this.finishFilterDateTimePicker.Name = "finishFilterDateTimePicker";
            this.finishFilterDateTimePicker.Size = new System.Drawing.Size(276, 26);
            this.finishFilterDateTimePicker.TabIndex = 18;
            this.finishFilterDateTimePicker.Value = new System.DateTime(2022, 4, 4, 0, 0, 0, 0);
            this.finishFilterDateTimePicker.ValueChanged += new System.EventHandler(this.finishFilterDateTimePicker_ValueChanged);
            // 
            // beginFilterDateTimePicker
            // 
            this.beginFilterDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.beginFilterDateTimePicker.Location = new System.Drawing.Point(250, 7);
            this.beginFilterDateTimePicker.Name = "beginFilterDateTimePicker";
            this.beginFilterDateTimePicker.Size = new System.Drawing.Size(276, 26);
            this.beginFilterDateTimePicker.TabIndex = 16;
            this.beginFilterDateTimePicker.Value = new System.DateTime(2022, 4, 4, 0, 0, 0, 0);
            this.beginFilterDateTimePicker.ValueChanged += new System.EventHandler(this.beginFilterDateTimePicker_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonExit);
            this.panel3.Location = new System.Drawing.Point(1, 608);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 38);
            this.panel3.TabIndex = 17;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(323, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(197, 30);
            this.buttonExit.TabIndex = 22;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listViewStatistics);
            this.Controls.Add(this.listJournal);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticForm";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}