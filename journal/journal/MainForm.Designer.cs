
namespace journal
{
    partial class MainForm
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
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.jurnalTabPage = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOpenStatistic = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonChangeNewThing = new System.Windows.Forms.Button();
            this.buttonDeletThing = new System.Windows.Forms.Button();
            this.buttonAddNewThing = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usersLoginComboBox = new System.Windows.Forms.ComboBox();
            this.cancelFilterJurnalButton = new System.Windows.Forms.Button();
            this.finishFilterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.filterDateButton = new System.Windows.Forms.Button();
            this.beginFilterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.filterThingFild = new System.Windows.Forms.TextBox();
            this.listJournal = new System.Windows.Forms.ListView();
            this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loginUserColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topicColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegisterTabPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.listRegister = new System.Windows.Forms.ListView();
            this.UsersIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UsersLoginColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UsersPassColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UsersPrivilegeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.cancelFilterRegButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.filterRegFild = new System.Windows.Forms.TextBox();
            this.profileTabPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userNameProfileLabel = new System.Windows.Forms.Label();
            this.exitFromUserButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonChangeNewUserPass = new System.Windows.Forms.Button();
            this.oldUserPassFild = new System.Windows.Forms.TextBox();
            this.repitUserPassFild = new System.Windows.Forms.TextBox();
            this.newUserPassFild = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.jurnalTabPage.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.RegisterTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateColumnHeader
            // 
            this.dateColumnHeader.Text = "Дата";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 55);
            this.panel1.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userNameLabel.Location = new System.Drawing.Point(698, 31);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(97, 24);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "nameUser";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(672, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Пользователь:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(360, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Журнал";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.jurnalTabPage);
            this.mainTabControl.Controls.Add(this.RegisterTabPage);
            this.mainTabControl.Controls.Add(this.profileTabPage);
            this.mainTabControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 55);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(884, 606);
            this.mainTabControl.TabIndex = 2;
            this.mainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.mainTabControl_DrawItem);
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged_1);
            // 
            // jurnalTabPage
            // 
            this.jurnalTabPage.BackColor = System.Drawing.SystemColors.Info;
            this.jurnalTabPage.Controls.Add(this.panel6);
            this.jurnalTabPage.Controls.Add(this.panel5);
            this.jurnalTabPage.Controls.Add(this.listJournal);
            this.jurnalTabPage.ForeColor = System.Drawing.SystemColors.Info;
            this.jurnalTabPage.Location = new System.Drawing.Point(4, 29);
            this.jurnalTabPage.Name = "jurnalTabPage";
            this.jurnalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.jurnalTabPage.Size = new System.Drawing.Size(876, 573);
            this.jurnalTabPage.TabIndex = 0;
            this.jurnalTabPage.Text = "Журнал";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel6.Controls.Add(this.buttonExit);
            this.panel6.Controls.Add(this.buttonOpenStatistic);
            this.panel6.Controls.Add(this.buttonReport);
            this.panel6.Controls.Add(this.buttonChangeNewThing);
            this.panel6.Controls.Add(this.buttonDeletThing);
            this.panel6.Controls.Add(this.buttonAddNewThing);
            this.panel6.Location = new System.Drawing.Point(8, 526);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(860, 39);
            this.panel6.TabIndex = 16;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(737, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 32);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonOpenStatistic
            // 
            this.buttonOpenStatistic.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOpenStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenStatistic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonOpenStatistic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonOpenStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonOpenStatistic.ForeColor = System.Drawing.Color.White;
            this.buttonOpenStatistic.Location = new System.Drawing.Point(590, 4);
            this.buttonOpenStatistic.Name = "buttonOpenStatistic";
            this.buttonOpenStatistic.Size = new System.Drawing.Size(120, 32);
            this.buttonOpenStatistic.TabIndex = 19;
            this.buttonOpenStatistic.Text = "Статистика";
            this.buttonOpenStatistic.UseVisualStyleBackColor = false;
            this.buttonOpenStatistic.Click += new System.EventHandler(this.buttonOpenStatistic_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReport.ForeColor = System.Drawing.Color.White;
            this.buttonReport.Location = new System.Drawing.Point(446, 4);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(120, 32);
            this.buttonReport.TabIndex = 18;
            this.buttonReport.Text = "Отчет";
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonChangeNewThing
            // 
            this.buttonChangeNewThing.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonChangeNewThing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeNewThing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonChangeNewThing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonChangeNewThing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeNewThing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonChangeNewThing.ForeColor = System.Drawing.Color.White;
            this.buttonChangeNewThing.Location = new System.Drawing.Point(151, 3);
            this.buttonChangeNewThing.Name = "buttonChangeNewThing";
            this.buttonChangeNewThing.Size = new System.Drawing.Size(120, 32);
            this.buttonChangeNewThing.TabIndex = 17;
            this.buttonChangeNewThing.Text = "Изменить";
            this.buttonChangeNewThing.UseVisualStyleBackColor = false;
            this.buttonChangeNewThing.Click += new System.EventHandler(this.buttonChangeNewThing_Click);
            // 
            // buttonDeletThing
            // 
            this.buttonDeletThing.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDeletThing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeletThing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonDeletThing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDeletThing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletThing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDeletThing.ForeColor = System.Drawing.Color.White;
            this.buttonDeletThing.Location = new System.Drawing.Point(302, 3);
            this.buttonDeletThing.Name = "buttonDeletThing";
            this.buttonDeletThing.Size = new System.Drawing.Size(120, 32);
            this.buttonDeletThing.TabIndex = 16;
            this.buttonDeletThing.Text = "Удалить";
            this.buttonDeletThing.UseVisualStyleBackColor = false;
            this.buttonDeletThing.Click += new System.EventHandler(this.buttonDeletThing_Click);
            // 
            // buttonAddNewThing
            // 
            this.buttonAddNewThing.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAddNewThing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddNewThing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonAddNewThing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAddNewThing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewThing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddNewThing.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewThing.Location = new System.Drawing.Point(3, 3);
            this.buttonAddNewThing.Name = "buttonAddNewThing";
            this.buttonAddNewThing.Size = new System.Drawing.Size(120, 32);
            this.buttonAddNewThing.TabIndex = 15;
            this.buttonAddNewThing.Text = "Добавить";
            this.buttonAddNewThing.UseVisualStyleBackColor = false;
            this.buttonAddNewThing.Click += new System.EventHandler(this.buttonAddNewThing_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.usersLoginComboBox);
            this.panel5.Controls.Add(this.cancelFilterJurnalButton);
            this.panel5.Controls.Add(this.finishFilterDateTimePicker);
            this.panel5.Controls.Add(this.filterDateButton);
            this.panel5.Controls.Add(this.beginFilterDateTimePicker);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.filterThingFild);
            this.panel5.Location = new System.Drawing.Point(11, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(857, 114);
            this.panel5.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(324, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "конечная дата";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(313, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "начальная дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(363, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Фильтры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "по пользователям";
            // 
            // usersLoginComboBox
            // 
            this.usersLoginComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersLoginComboBox.FormattingEnabled = true;
            this.usersLoginComboBox.Location = new System.Drawing.Point(160, 75);
            this.usersLoginComboBox.Name = "usersLoginComboBox";
            this.usersLoginComboBox.Size = new System.Drawing.Size(147, 28);
            this.usersLoginComboBox.TabIndex = 20;
            this.usersLoginComboBox.TextChanged += new System.EventHandler(this.usersLoginComboBox_TextChanged);
            // 
            // cancelFilterJurnalButton
            // 
            this.cancelFilterJurnalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cancelFilterJurnalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelFilterJurnalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.cancelFilterJurnalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancelFilterJurnalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelFilterJurnalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelFilterJurnalButton.ForeColor = System.Drawing.Color.White;
            this.cancelFilterJurnalButton.Location = new System.Drawing.Point(674, 75);
            this.cancelFilterJurnalButton.Name = "cancelFilterJurnalButton";
            this.cancelFilterJurnalButton.Size = new System.Drawing.Size(180, 30);
            this.cancelFilterJurnalButton.TabIndex = 19;
            this.cancelFilterJurnalButton.Text = "Откл. фильтрацию";
            this.cancelFilterJurnalButton.UseVisualStyleBackColor = false;
            this.cancelFilterJurnalButton.Click += new System.EventHandler(this.cancelFilterJurnalButton_Click);
            // 
            // finishFilterDateTimePicker
            // 
            this.finishFilterDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishFilterDateTimePicker.Location = new System.Drawing.Point(452, 35);
            this.finishFilterDateTimePicker.Name = "finishFilterDateTimePicker";
            this.finishFilterDateTimePicker.Size = new System.Drawing.Size(216, 26);
            this.finishFilterDateTimePicker.TabIndex = 18;
            this.finishFilterDateTimePicker.Value = new System.DateTime(2022, 4, 4, 0, 0, 0, 0);
            // 
            // filterDateButton
            // 
            this.filterDateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.filterDateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterDateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.filterDateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.filterDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterDateButton.ForeColor = System.Drawing.Color.Transparent;
            this.filterDateButton.Location = new System.Drawing.Point(674, 33);
            this.filterDateButton.Name = "filterDateButton";
            this.filterDateButton.Size = new System.Drawing.Size(180, 30);
            this.filterDateButton.TabIndex = 17;
            this.filterDateButton.Text = "Фильтр по дате";
            this.filterDateButton.UseVisualStyleBackColor = false;
            this.filterDateButton.Click += new System.EventHandler(this.filterDateButton_Click);
            // 
            // beginFilterDateTimePicker
            // 
            this.beginFilterDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginFilterDateTimePicker.Location = new System.Drawing.Point(452, 77);
            this.beginFilterDateTimePicker.Name = "beginFilterDateTimePicker";
            this.beginFilterDateTimePicker.Size = new System.Drawing.Size(216, 26);
            this.beginFilterDateTimePicker.TabIndex = 16;
            this.beginFilterDateTimePicker.Value = new System.DateTime(2022, 4, 4, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "по всем полям";
            // 
            // filterThingFild
            // 
            this.filterThingFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterThingFild.Location = new System.Drawing.Point(129, 34);
            this.filterThingFild.Name = "filterThingFild";
            this.filterThingFild.Size = new System.Drawing.Size(178, 26);
            this.filterThingFild.TabIndex = 14;
            this.filterThingFild.TextChanged += new System.EventHandler(this.filterThingFild_TextChanged);
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
            this.listJournal.Location = new System.Drawing.Point(8, 126);
            this.listJournal.Name = "listJournal";
            this.listJournal.Size = new System.Drawing.Size(860, 397);
            this.listJournal.TabIndex = 0;
            this.listJournal.UseCompatibleStateImageBehavior = false;
            this.listJournal.View = System.Windows.Forms.View.Details;
            this.listJournal.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listJournal_ColumnWidthChanging);
            this.listJournal.DoubleClick += new System.EventHandler(this.listJournal_DoubleClick);
            this.listJournal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listJournal_MouseDown);
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Text = "ИД";
            // 
            // loginUserColumnHeader
            // 
            this.loginUserColumnHeader.Text = "Сотрудник";
            this.loginUserColumnHeader.Width = 98;
            // 
            // topicColumnHeader
            // 
            this.topicColumnHeader.Text = "Тема";
            // 
            // RegisterTabPage
            // 
            this.RegisterTabPage.BackColor = System.Drawing.SystemColors.Info;
            this.RegisterTabPage.Controls.Add(this.panel2);
            this.RegisterTabPage.Controls.Add(this.listRegister);
            this.RegisterTabPage.Controls.Add(this.panel4);
            this.RegisterTabPage.ForeColor = System.Drawing.SystemColors.Info;
            this.RegisterTabPage.Location = new System.Drawing.Point(4, 29);
            this.RegisterTabPage.Name = "RegisterTabPage";
            this.RegisterTabPage.Size = new System.Drawing.Size(876, 573);
            this.RegisterTabPage.TabIndex = 2;
            this.RegisterTabPage.Text = "Регистрация";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonChange);
            this.panel2.Location = new System.Drawing.Point(197, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 37);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(141, -326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 20;
            this.button1.Text = "Отчистить фильтр";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.cancelFilterRegButton_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 32);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Добавть";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(326, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 32);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonChange.ForeColor = System.Drawing.Color.White;
            this.buttonChange.Location = new System.Drawing.Point(166, 3);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(120, 32);
            this.buttonChange.TabIndex = 17;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // listRegister
            // 
            this.listRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listRegister.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UsersIdColumnHeader,
            this.UsersLoginColumnHeader,
            this.UsersPassColumnHeader,
            this.UsersPrivilegeColumnHeader});
            this.listRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRegister.FullRowSelect = true;
            this.listRegister.GridLines = true;
            this.listRegister.HideSelection = false;
            this.listRegister.Location = new System.Drawing.Point(197, 47);
            this.listRegister.Name = "listRegister";
            this.listRegister.Size = new System.Drawing.Size(449, 475);
            this.listRegister.TabIndex = 6;
            this.listRegister.UseCompatibleStateImageBehavior = false;
            this.listRegister.View = System.Windows.Forms.View.Details;
            this.listRegister.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listRegister_ColumnWidthChanging);
            this.listRegister.DoubleClick += new System.EventHandler(this.listRegister_DoubleClick);
            this.listRegister.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listRegister_MouseDown);
            // 
            // UsersIdColumnHeader
            // 
            this.UsersIdColumnHeader.Text = "ИД";
            // 
            // UsersLoginColumnHeader
            // 
            this.UsersLoginColumnHeader.Text = "Пользователь";
            // 
            // UsersPassColumnHeader
            // 
            this.UsersPassColumnHeader.Text = "Пароль";
            // 
            // UsersPrivilegeColumnHeader
            // 
            this.UsersPrivilegeColumnHeader.Text = "Привилегия";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.cancelFilterRegButton);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.filterRegFild);
            this.panel4.Location = new System.Drawing.Point(197, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 40);
            this.panel4.TabIndex = 3;
            // 
            // cancelFilterRegButton
            // 
            this.cancelFilterRegButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.cancelFilterRegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelFilterRegButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.cancelFilterRegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelFilterRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelFilterRegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cancelFilterRegButton.ForeColor = System.Drawing.Color.White;
            this.cancelFilterRegButton.Location = new System.Drawing.Point(246, 6);
            this.cancelFilterRegButton.Name = "cancelFilterRegButton";
            this.cancelFilterRegButton.Size = new System.Drawing.Size(200, 32);
            this.cancelFilterRegButton.TabIndex = 20;
            this.cancelFilterRegButton.Text = "Отчистить фильтр";
            this.cancelFilterRegButton.UseVisualStyleBackColor = false;
            this.cancelFilterRegButton.Click += new System.EventHandler(this.cancelFilterRegButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Фильтр";
            // 
            // filterRegFild
            // 
            this.filterRegFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.filterRegFild.Location = new System.Drawing.Point(94, 9);
            this.filterRegFild.Name = "filterRegFild";
            this.filterRegFild.Size = new System.Drawing.Size(146, 26);
            this.filterRegFild.TabIndex = 14;
            this.filterRegFild.TextChanged += new System.EventHandler(this.filterRegFild_TextChanged);
            // 
            // profileTabPage
            // 
            this.profileTabPage.BackColor = System.Drawing.SystemColors.Info;
            this.profileTabPage.Controls.Add(this.panel3);
            this.profileTabPage.ForeColor = System.Drawing.SystemColors.Info;
            this.profileTabPage.Location = new System.Drawing.Point(4, 29);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileTabPage.Size = new System.Drawing.Size(876, 573);
            this.profileTabPage.TabIndex = 3;
            this.profileTabPage.Text = "Профиль";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.userNameProfileLabel);
            this.panel3.Controls.Add(this.exitFromUserButton);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.buttonChangeNewUserPass);
            this.panel3.Controls.Add(this.oldUserPassFild);
            this.panel3.Controls.Add(this.repitUserPassFild);
            this.panel3.Controls.Add(this.newUserPassFild);
            this.panel3.Location = new System.Drawing.Point(325, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 311);
            this.panel3.TabIndex = 7;
            // 
            // userNameProfileLabel
            // 
            this.userNameProfileLabel.AutoSize = true;
            this.userNameProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.userNameProfileLabel.ForeColor = System.Drawing.Color.Black;
            this.userNameProfileLabel.Location = new System.Drawing.Point(66, 36);
            this.userNameProfileLabel.Name = "userNameProfileLabel";
            this.userNameProfileLabel.Size = new System.Drawing.Size(105, 24);
            this.userNameProfileLabel.TabIndex = 10;
            this.userNameProfileLabel.Text = "nameUser";
            // 
            // exitFromUserButton
            // 
            this.exitFromUserButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.exitFromUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitFromUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.exitFromUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitFromUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitFromUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.exitFromUserButton.ForeColor = System.Drawing.Color.White;
            this.exitFromUserButton.Location = new System.Drawing.Point(28, 261);
            this.exitFromUserButton.Name = "exitFromUserButton";
            this.exitFromUserButton.Size = new System.Drawing.Size(190, 36);
            this.exitFromUserButton.TabIndex = 8;
            this.exitFromUserButton.Text = "Выход из польз.";
            this.exitFromUserButton.UseVisualStyleBackColor = false;
            this.exitFromUserButton.Click += new System.EventHandler(this.exitFromUserButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(48, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пользователь:";
            // 
            // buttonChangeNewUserPass
            // 
            this.buttonChangeNewUserPass.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonChangeNewUserPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeNewUserPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonChangeNewUserPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonChangeNewUserPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeNewUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonChangeNewUserPass.ForeColor = System.Drawing.Color.White;
            this.buttonChangeNewUserPass.Location = new System.Drawing.Point(28, 207);
            this.buttonChangeNewUserPass.Name = "buttonChangeNewUserPass";
            this.buttonChangeNewUserPass.Size = new System.Drawing.Size(190, 35);
            this.buttonChangeNewUserPass.TabIndex = 6;
            this.buttonChangeNewUserPass.Text = "Сменить пароль";
            this.buttonChangeNewUserPass.UseVisualStyleBackColor = false;
            this.buttonChangeNewUserPass.Click += new System.EventHandler(this.buttonChangeNewUserPass_Click);
            // 
            // oldUserPassFild
            // 
            this.oldUserPassFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.oldUserPassFild.Location = new System.Drawing.Point(28, 72);
            this.oldUserPassFild.Name = "oldUserPassFild";
            this.oldUserPassFild.Size = new System.Drawing.Size(190, 26);
            this.oldUserPassFild.TabIndex = 2;
            this.oldUserPassFild.Enter += new System.EventHandler(this.oldUserPassFild_Enter);
            this.oldUserPassFild.Leave += new System.EventHandler(this.oldUserPassFild_Leave);
            // 
            // repitUserPassFild
            // 
            this.repitUserPassFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.repitUserPassFild.Location = new System.Drawing.Point(28, 165);
            this.repitUserPassFild.Name = "repitUserPassFild";
            this.repitUserPassFild.Size = new System.Drawing.Size(190, 26);
            this.repitUserPassFild.TabIndex = 4;
            this.repitUserPassFild.Enter += new System.EventHandler(this.repitUserPassFild_Enter);
            this.repitUserPassFild.Leave += new System.EventHandler(this.repitUserPassFild_Leave);
            // 
            // newUserPassFild
            // 
            this.newUserPassFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.newUserPassFild.Location = new System.Drawing.Point(28, 119);
            this.newUserPassFild.Name = "newUserPassFild";
            this.newUserPassFild.Size = new System.Drawing.Size(190, 26);
            this.newUserPassFild.TabIndex = 3;
            this.newUserPassFild.Enter += new System.EventHandler(this.newUserPassFild_Enter);
            this.newUserPassFild.Leave += new System.EventHandler(this.newUserPassFild_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.jurnalTabPage.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.RegisterTabPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.profileTabPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage jurnalTabPage;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TabPage profileTabPage;
        private System.Windows.Forms.TextBox repitUserPassFild;
        private System.Windows.Forms.TextBox newUserPassFild;
        private System.Windows.Forms.TextBox oldUserPassFild;
        private System.Windows.Forms.TabPage RegisterTabPage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonChangeNewUserPass;
        private System.Windows.Forms.ListView listJournal;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader loginUserColumnHeader;
        private System.Windows.Forms.ColumnHeader topicColumnHeader;
        private System.Windows.Forms.Button exitFromUserButton;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
        public System.Windows.Forms.Label userNameProfileLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filterRegFild;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonChangeNewThing;
        private System.Windows.Forms.Button buttonDeletThing;
        private System.Windows.Forms.Button buttonAddNewThing;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox usersLoginComboBox;
        private System.Windows.Forms.Button cancelFilterJurnalButton;
        private System.Windows.Forms.DateTimePicker finishFilterDateTimePicker;
        private System.Windows.Forms.Button filterDateButton;
        private System.Windows.Forms.DateTimePicker beginFilterDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filterThingFild;
        private System.Windows.Forms.ListView listRegister;
        private System.Windows.Forms.ColumnHeader UsersIdColumnHeader;
        private System.Windows.Forms.ColumnHeader UsersLoginColumnHeader;
        private System.Windows.Forms.ColumnHeader UsersPassColumnHeader;
        private System.Windows.Forms.ColumnHeader UsersPrivilegeColumnHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button cancelFilterRegButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOpenStatistic;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}