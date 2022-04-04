
namespace journal
{
    partial class ChangeUserForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.privilegeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idFild = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passFild = new System.Windows.Forms.TextBox();
            this.loginFild = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.changeUserButton);
            this.panel2.Controls.Add(this.privilegeComboBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.idFild);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.passFild);
            this.panel2.Controls.Add(this.loginFild);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(19, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 235);
            this.panel2.TabIndex = 27;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(219, 181);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 32);
            this.buttonCancel.TabIndex = 36;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // changeUserButton
            // 
            this.changeUserButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.changeUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.changeUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.changeUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.changeUserButton.ForeColor = System.Drawing.Color.White;
            this.changeUserButton.Location = new System.Drawing.Point(72, 181);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(120, 32);
            this.changeUserButton.TabIndex = 35;
            this.changeUserButton.Text = "Изменить";
            this.changeUserButton.UseVisualStyleBackColor = false;
            this.changeUserButton.Click += new System.EventHandler(this.changeUserButton_Click);
            // 
            // privilegeComboBox
            // 
            this.privilegeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.privilegeComboBox.FormattingEnabled = true;
            this.privilegeComboBox.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.privilegeComboBox.Location = new System.Drawing.Point(202, 138);
            this.privilegeComboBox.Name = "privilegeComboBox";
            this.privilegeComboBox.Size = new System.Drawing.Size(178, 28);
            this.privilegeComboBox.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(68, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Привилегия";
            // 
            // idFild
            // 
            this.idFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idFild.Location = new System.Drawing.Point(202, 10);
            this.idFild.Name = "idFild";
            this.idFild.ReadOnly = true;
            this.idFild.Size = new System.Drawing.Size(178, 26);
            this.idFild.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(167, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(114, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Имя пользователя";
            // 
            // passFild
            // 
            this.passFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passFild.Location = new System.Drawing.Point(202, 95);
            this.passFild.Name = "passFild";
            this.passFild.Size = new System.Drawing.Size(178, 26);
            this.passFild.TabIndex = 28;
            this.passFild.Enter += new System.EventHandler(this.passFild_Enter);
            this.passFild.Leave += new System.EventHandler(this.passFild_Leave);
            // 
            // loginFild
            // 
            this.loginFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginFild.Location = new System.Drawing.Point(202, 54);
            this.loginFild.Name = "loginFild";
            this.loginFild.ReadOnly = true;
            this.loginFild.Size = new System.Drawing.Size(178, 26);
            this.loginFild.TabIndex = 27;
            this.loginFild.Enter += new System.EventHandler(this.loginFild_Enter);
            this.loginFild.Leave += new System.EventHandler(this.loginFild_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Редактирование";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 58);
            this.panel1.TabIndex = 25;
            // 
            // ChangeUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(414, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(430, 350);
            this.Name = "ChangeUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeUserForm";
            this.Load += new System.EventHandler(this.ChangeUserForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button changeUserButton;
        public System.Windows.Forms.ComboBox privilegeComboBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox idFild;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox passFild;
        public System.Windows.Forms.TextBox loginFild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}