
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
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 58);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 37);
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
            this.panel2.Location = new System.Drawing.Point(16, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 217);
            this.panel2.TabIndex = 21;
            // 
            // cencelButton
            // 
            this.cencelButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.cencelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.cencelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cencelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cencelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cencelButton.ForeColor = System.Drawing.Color.White;
            this.cencelButton.Location = new System.Drawing.Point(226, 172);
            this.cencelButton.Name = "cencelButton";
            this.cencelButton.Size = new System.Drawing.Size(120, 32);
            this.cencelButton.TabIndex = 27;
            this.cencelButton.Text = "Отменить";
            this.cencelButton.UseVisualStyleBackColor = false;
            this.cencelButton.Click += new System.EventHandler(this.cencelButton_Click);
            // 
            // privilegeComboBox
            // 
            this.privilegeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.privilegeComboBox.FormattingEnabled = true;
            this.privilegeComboBox.ItemHeight = 20;
            this.privilegeComboBox.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.privilegeComboBox.Location = new System.Drawing.Point(213, 120);
            this.privilegeComboBox.Name = "privilegeComboBox";
            this.privilegeComboBox.Size = new System.Drawing.Size(153, 28);
            this.privilegeComboBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(72, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Привилегия";
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
            this.buttonAdd.Location = new System.Drawing.Point(87, 172);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 32);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(118, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Имя пользователя";
            // 
            // passFild
            // 
            this.passFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passFild.Location = new System.Drawing.Point(213, 66);
            this.passFild.Name = "passFild";
            this.passFild.Size = new System.Drawing.Size(153, 26);
            this.passFild.TabIndex = 21;
            this.passFild.Enter += new System.EventHandler(this.passFild_Enter);
            this.passFild.Leave += new System.EventHandler(this.passFild_Leave);
            // 
            // loginFild
            // 
            this.loginFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginFild.Location = new System.Drawing.Point(213, 15);
            this.loginFild.Name = "loginFild";
            this.loginFild.Size = new System.Drawing.Size(153, 26);
            this.loginFild.TabIndex = 20;
            this.loginFild.Enter += new System.EventHandler(this.loginFild_Enter);
            this.loginFild.Leave += new System.EventHandler(this.loginFild_Leave);
            // 
            // addUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(414, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(430, 350);
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