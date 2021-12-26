
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
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonChangeNewThing = new System.Windows.Forms.Button();
            this.buttonDeletThing = new System.Windows.Forms.Button();
            this.buttonAddNewThing = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.label5 = new System.Windows.Forms.Label();
            this.exitFromUserButton = new System.Windows.Forms.Button();
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
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 55);
            this.panel1.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userNameLabel.Location = new System.Drawing.Point(634, 28);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(97, 24);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "nameUser";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(612, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Пользователь:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Журнал";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.jurnalTabPage);
            this.mainTabControl.Controls.Add(this.RegisterTabPage);
            this.mainTabControl.Controls.Add(this.profileTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mainTabControl.Location = new System.Drawing.Point(0, 55);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.ShowToolTips = true;
            this.mainTabControl.Size = new System.Drawing.Size(784, 406);
            this.mainTabControl.TabIndex = 2;
            this.mainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.mainTabControl_DrawItem);
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged_1);
            // 
            // jurnalTabPage
            // 
            this.jurnalTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.jurnalTabPage.Controls.Add(this.panel6);
            this.jurnalTabPage.Controls.Add(this.panel5);
            this.jurnalTabPage.Controls.Add(this.listJournal);
            this.jurnalTabPage.ForeColor = System.Drawing.Color.White;
            this.jurnalTabPage.Location = new System.Drawing.Point(4, 22);
            this.jurnalTabPage.Name = "jurnalTabPage";
            this.jurnalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.jurnalTabPage.Size = new System.Drawing.Size(776, 380);
            this.jurnalTabPage.TabIndex = 0;
            this.jurnalTabPage.Text = "Журнал";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel6.Controls.Add(this.buttonReport);
            this.panel6.Controls.Add(this.buttonChangeNewThing);
            this.panel6.Controls.Add(this.buttonDeletThing);
            this.panel6.Controls.Add(this.buttonAddNewThing);
            this.panel6.Location = new System.Drawing.Point(176, 340);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(392, 32);
            this.panel6.TabIndex = 16;
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.ForeColor = System.Drawing.Color.Black;
            this.buttonReport.Location = new System.Drawing.Point(312, 3);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(75, 23);
            this.buttonReport.TabIndex = 18;
            this.buttonReport.Text = "Отчет";
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonChangeNewThing
            // 
            this.buttonChangeNewThing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonChangeNewThing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeNewThing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonChangeNewThing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonChangeNewThing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeNewThing.ForeColor = System.Drawing.Color.Black;
            this.buttonChangeNewThing.Location = new System.Drawing.Point(101, 3);
            this.buttonChangeNewThing.Name = "buttonChangeNewThing";
            this.buttonChangeNewThing.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeNewThing.TabIndex = 17;
            this.buttonChangeNewThing.Text = "Изменить";
            this.buttonChangeNewThing.UseVisualStyleBackColor = false;
            this.buttonChangeNewThing.Click += new System.EventHandler(this.buttonChangeNewThing_Click);
            // 
            // buttonDeletThing
            // 
            this.buttonDeletThing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonDeletThing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeletThing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonDeletThing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDeletThing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletThing.ForeColor = System.Drawing.Color.Black;
            this.buttonDeletThing.Location = new System.Drawing.Point(202, 3);
            this.buttonDeletThing.Name = "buttonDeletThing";
            this.buttonDeletThing.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletThing.TabIndex = 16;
            this.buttonDeletThing.Text = "Удалить";
            this.buttonDeletThing.UseVisualStyleBackColor = false;
            this.buttonDeletThing.Click += new System.EventHandler(this.buttonDeletThing_Click);
            // 
            // buttonAddNewThing
            // 
            this.buttonAddNewThing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAddNewThing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddNewThing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonAddNewThing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAddNewThing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewThing.ForeColor = System.Drawing.Color.Black;
            this.buttonAddNewThing.Location = new System.Drawing.Point(3, 3);
            this.buttonAddNewThing.Name = "buttonAddNewThing";
            this.buttonAddNewThing.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNewThing.TabIndex = 15;
            this.buttonAddNewThing.Text = "Добавить";
            this.buttonAddNewThing.UseVisualStyleBackColor = false;
            this.buttonAddNewThing.Click += new System.EventHandler(this.buttonAddNewThing_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.usersLoginComboBox);
            this.panel5.Controls.Add(this.cancelFilterJurnalButton);
            this.panel5.Controls.Add(this.finishFilterDateTimePicker);
            this.panel5.Controls.Add(this.filterDateButton);
            this.panel5.Controls.Add(this.beginFilterDateTimePicker);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.filterThingFild);
            this.panel5.Location = new System.Drawing.Point(80, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(647, 64);
            this.panel5.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(21, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Фильтр по пользователям";
            // 
            // usersLoginComboBox
            // 
            this.usersLoginComboBox.FormattingEnabled = true;
            this.usersLoginComboBox.Location = new System.Drawing.Point(171, 38);
            this.usersLoginComboBox.Name = "usersLoginComboBox";
            this.usersLoginComboBox.Size = new System.Drawing.Size(100, 21);
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
            this.cancelFilterJurnalButton.ForeColor = System.Drawing.Color.Black;
            this.cancelFilterJurnalButton.Location = new System.Drawing.Point(492, 10);
            this.cancelFilterJurnalButton.Name = "cancelFilterJurnalButton";
            this.cancelFilterJurnalButton.Size = new System.Drawing.Size(136, 23);
            this.cancelFilterJurnalButton.TabIndex = 19;
            this.cancelFilterJurnalButton.Text = "Отменить фильтрацию";
            this.cancelFilterJurnalButton.UseVisualStyleBackColor = false;
            this.cancelFilterJurnalButton.Click += new System.EventHandler(this.cancelFilterJurnalButton_Click);
            // 
            // finishFilterDateTimePicker
            // 
            this.finishFilterDateTimePicker.Location = new System.Drawing.Point(286, 39);
            this.finishFilterDateTimePicker.Name = "finishFilterDateTimePicker";
            this.finishFilterDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.finishFilterDateTimePicker.TabIndex = 18;
            this.finishFilterDateTimePicker.Value = new System.DateTime(2021, 8, 22, 0, 0, 0, 0);
            // 
            // filterDateButton
            // 
            this.filterDateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.filterDateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterDateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.filterDateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.filterDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterDateButton.ForeColor = System.Drawing.Color.Black;
            this.filterDateButton.Location = new System.Drawing.Point(492, 36);
            this.filterDateButton.Name = "filterDateButton";
            this.filterDateButton.Size = new System.Drawing.Size(136, 23);
            this.filterDateButton.TabIndex = 17;
            this.filterDateButton.Text = "Фильтр по дате";
            this.filterDateButton.UseVisualStyleBackColor = false;
            this.filterDateButton.Click += new System.EventHandler(this.filterDateButton_Click);
            // 
            // beginFilterDateTimePicker
            // 
            this.beginFilterDateTimePicker.Location = new System.Drawing.Point(286, 13);
            this.beginFilterDateTimePicker.Name = "beginFilterDateTimePicker";
            this.beginFilterDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.beginFilterDateTimePicker.TabIndex = 16;
            this.beginFilterDateTimePicker.Value = new System.DateTime(2021, 8, 22, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(39, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Фильтр по всем полям";
            // 
            // filterThingFild
            // 
            this.filterThingFild.Location = new System.Drawing.Point(171, 12);
            this.filterThingFild.Name = "filterThingFild";
            this.filterThingFild.Size = new System.Drawing.Size(100, 20);
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
            this.listJournal.FullRowSelect = true;
            this.listJournal.GridLines = true;
            this.listJournal.HideSelection = false;
            this.listJournal.Location = new System.Drawing.Point(8, 71);
            this.listJournal.Name = "listJournal";
            this.listJournal.Size = new System.Drawing.Size(760, 263);
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
            this.loginUserColumnHeader.Text = "Пользователь";
            // 
            // topicColumnHeader
            // 
            this.topicColumnHeader.Text = "Тема";
            // 
            // RegisterTabPage
            // 
            this.RegisterTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegisterTabPage.Controls.Add(this.panel2);
            this.RegisterTabPage.Controls.Add(this.listRegister);
            this.RegisterTabPage.Controls.Add(this.panel4);
            this.RegisterTabPage.ForeColor = System.Drawing.Color.White;
            this.RegisterTabPage.Location = new System.Drawing.Point(4, 22);
            this.RegisterTabPage.Name = "RegisterTabPage";
            this.RegisterTabPage.Size = new System.Drawing.Size(776, 380);
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
            this.panel2.Location = new System.Drawing.Point(268, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 29);
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
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Добавть";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(165, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.ForeColor = System.Drawing.Color.Black;
            this.buttonChange.Location = new System.Drawing.Point(84, 3);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
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
            this.listRegister.FullRowSelect = true;
            this.listRegister.GridLines = true;
            this.listRegister.HideSelection = false;
            this.listRegister.Location = new System.Drawing.Point(216, 47);
            this.listRegister.Name = "listRegister";
            this.listRegister.Size = new System.Drawing.Size(320, 291);
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
            this.panel4.Location = new System.Drawing.Point(236, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 38);
            this.panel4.TabIndex = 3;
            // 
            // cancelFilterRegButton
            // 
            this.cancelFilterRegButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cancelFilterRegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelFilterRegButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.cancelFilterRegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelFilterRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelFilterRegButton.ForeColor = System.Drawing.Color.Black;
            this.cancelFilterRegButton.Location = new System.Drawing.Point(173, 8);
            this.cancelFilterRegButton.Name = "cancelFilterRegButton";
            this.cancelFilterRegButton.Size = new System.Drawing.Size(75, 21);
            this.cancelFilterRegButton.TabIndex = 20;
            this.cancelFilterRegButton.Text = "Отчистить фильтр";
            this.cancelFilterRegButton.UseVisualStyleBackColor = false;
            this.cancelFilterRegButton.Click += new System.EventHandler(this.cancelFilterRegButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Фильтр";
            // 
            // filterRegFild
            // 
            this.filterRegFild.Location = new System.Drawing.Point(56, 8);
            this.filterRegFild.Name = "filterRegFild";
            this.filterRegFild.Size = new System.Drawing.Size(100, 20);
            this.filterRegFild.TabIndex = 14;
            this.filterRegFild.TextChanged += new System.EventHandler(this.filterRegFild_TextChanged);
            // 
            // profileTabPage
            // 
            this.profileTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profileTabPage.Controls.Add(this.panel3);
            this.profileTabPage.ForeColor = System.Drawing.Color.White;
            this.profileTabPage.Location = new System.Drawing.Point(4, 22);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileTabPage.Size = new System.Drawing.Size(776, 380);
            this.profileTabPage.TabIndex = 3;
            this.profileTabPage.Text = "Профиль";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.userNameProfileLabel);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.exitFromUserButton);
            this.panel3.Controls.Add(this.buttonChangeNewUserPass);
            this.panel3.Controls.Add(this.oldUserPassFild);
            this.panel3.Controls.Add(this.repitUserPassFild);
            this.panel3.Controls.Add(this.newUserPassFild);
            this.panel3.Location = new System.Drawing.Point(275, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 250);
            this.panel3.TabIndex = 7;
            // 
            // userNameProfileLabel
            // 
            this.userNameProfileLabel.AutoSize = true;
            this.userNameProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameProfileLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userNameProfileLabel.Location = new System.Drawing.Point(66, 36);
            this.userNameProfileLabel.Name = "userNameProfileLabel";
            this.userNameProfileLabel.Size = new System.Drawing.Size(97, 24);
            this.userNameProfileLabel.TabIndex = 10;
            this.userNameProfileLabel.Text = "nameUser";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(48, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пользователь:";
            // 
            // exitFromUserButton
            // 
            this.exitFromUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exitFromUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitFromUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.exitFromUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitFromUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitFromUserButton.ForeColor = System.Drawing.Color.Black;
            this.exitFromUserButton.Location = new System.Drawing.Point(70, 212);
            this.exitFromUserButton.Name = "exitFromUserButton";
            this.exitFromUserButton.Size = new System.Drawing.Size(108, 23);
            this.exitFromUserButton.TabIndex = 8;
            this.exitFromUserButton.Text = "Выход из польз.";
            this.exitFromUserButton.UseVisualStyleBackColor = false;
            this.exitFromUserButton.Click += new System.EventHandler(this.exitFromUserButton_Click);
            // 
            // buttonChangeNewUserPass
            // 
            this.buttonChangeNewUserPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonChangeNewUserPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeNewUserPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonChangeNewUserPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonChangeNewUserPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeNewUserPass.ForeColor = System.Drawing.Color.Black;
            this.buttonChangeNewUserPass.Location = new System.Drawing.Point(70, 183);
            this.buttonChangeNewUserPass.Name = "buttonChangeNewUserPass";
            this.buttonChangeNewUserPass.Size = new System.Drawing.Size(108, 23);
            this.buttonChangeNewUserPass.TabIndex = 6;
            this.buttonChangeNewUserPass.Text = "Сменить пароль";
            this.buttonChangeNewUserPass.UseVisualStyleBackColor = false;
            this.buttonChangeNewUserPass.Click += new System.EventHandler(this.buttonChangeNewUserPass_Click);
            // 
            // oldUserPassFild
            // 
            this.oldUserPassFild.Location = new System.Drawing.Point(56, 75);
            this.oldUserPassFild.Name = "oldUserPassFild";
            this.oldUserPassFild.Size = new System.Drawing.Size(136, 20);
            this.oldUserPassFild.TabIndex = 2;
            this.oldUserPassFild.Enter += new System.EventHandler(this.oldUserPassFild_Enter);
            this.oldUserPassFild.Leave += new System.EventHandler(this.oldUserPassFild_Leave);
            // 
            // repitUserPassFild
            // 
            this.repitUserPassFild.Location = new System.Drawing.Point(56, 144);
            this.repitUserPassFild.Name = "repitUserPassFild";
            this.repitUserPassFild.Size = new System.Drawing.Size(136, 20);
            this.repitUserPassFild.TabIndex = 4;
            this.repitUserPassFild.Enter += new System.EventHandler(this.repitUserPassFild_Enter);
            this.repitUserPassFild.Leave += new System.EventHandler(this.repitUserPassFild_Leave);
            // 
            // newUserPassFild
            // 
            this.newUserPassFild.Location = new System.Drawing.Point(56, 108);
            this.newUserPassFild.Name = "newUserPassFild";
            this.newUserPassFild.Size = new System.Drawing.Size(136, 20);
            this.newUserPassFild.TabIndex = 3;
            this.newUserPassFild.Enter += new System.EventHandler(this.newUserPassFild_Enter);
            this.newUserPassFild.Leave += new System.EventHandler(this.newUserPassFild_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.panel1);
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
    }
}