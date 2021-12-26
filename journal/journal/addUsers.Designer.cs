
namespace journal
{
    partial class addUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cencelButton = new System.Windows.Forms.Button();
            this.privilegeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passFild = new System.Windows.Forms.TextBox();
            this.loginFild = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 58);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавление пользователя";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.cencelButton);
            this.panel2.Controls.Add(this.privilegeComboBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.passFild);
            this.panel2.Controls.Add(this.loginFild);
            this.panel2.Location = new System.Drawing.Point(33, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 179);
            this.panel2.TabIndex = 21;
            // 
            // cencelButton
            // 
            this.cencelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cencelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.cencelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cencelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cencelButton.Location = new System.Drawing.Point(136, 141);
            this.cencelButton.Name = "cencelButton";
            this.cencelButton.Size = new System.Drawing.Size(75, 23);
            this.cencelButton.TabIndex = 27;
            this.cencelButton.Text = "Отменить";
            this.cencelButton.UseVisualStyleBackColor = false;
            this.cencelButton.Click += new System.EventHandler(this.cencelButton_Click);
            // 
            // privilegeComboBox
            // 
            this.privilegeComboBox.FormattingEnabled = true;
            this.privilegeComboBox.ItemHeight = 13;
            this.privilegeComboBox.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.privilegeComboBox.Location = new System.Drawing.Point(123, 73);
            this.privilegeComboBox.Name = "privilegeComboBox";
            this.privilegeComboBox.Size = new System.Drawing.Size(100, 21);
            this.privilegeComboBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(49, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Привилегия";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(136, 111);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(72, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Имя пользователя";
            // 
            // passFild
            // 
            this.passFild.Location = new System.Drawing.Point(123, 43);
            this.passFild.Name = "passFild";
            this.passFild.Size = new System.Drawing.Size(100, 20);
            this.passFild.TabIndex = 21;
            this.passFild.Enter += new System.EventHandler(this.passFild_Enter);
            this.passFild.Leave += new System.EventHandler(this.passFild_Leave);
            // 
            // loginFild
            // 
            this.loginFild.Location = new System.Drawing.Point(123, 12);
            this.loginFild.Name = "loginFild";
            this.loginFild.Size = new System.Drawing.Size(100, 20);
            this.loginFild.TabIndex = 20;
            this.loginFild.Enter += new System.EventHandler(this.loginFild_Enter);
            this.loginFild.Leave += new System.EventHandler(this.loginFild_Leave);
            // 
            // addUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(314, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(330, 300);
            this.Name = "addUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addUsers";
            this.Load += new System.EventHandler(this.addUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cencelButton;
        private System.Windows.Forms.ComboBox privilegeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passFild;
        private System.Windows.Forms.TextBox loginFild;
    }
}