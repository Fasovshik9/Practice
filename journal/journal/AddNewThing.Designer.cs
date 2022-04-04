
namespace journal
{
    partial class AddNewThing
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usersLoginField = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.usersLoginComboBox = new System.Windows.Forms.ComboBox();
            this.buttonAddNewThing = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentField = new System.Windows.Forms.RichTextBox();
            this.topicField = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(884, 65);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление новой задачи";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.usersLoginField);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.usersLoginComboBox);
            this.panel2.Controls.Add(this.buttonAddNewThing);
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Controls.Add(this.commentField);
            this.panel2.Controls.Add(this.topicField);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(12, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 380);
            this.panel2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(339, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Задча";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Пользователь";
            // 
            // usersLoginField
            // 
            this.usersLoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usersLoginField.Location = new System.Drawing.Point(160, 11);
            this.usersLoginField.Name = "usersLoginField";
            this.usersLoginField.Size = new System.Drawing.Size(136, 26);
            this.usersLoginField.TabIndex = 25;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(515, 336);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 32);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // usersLoginComboBox
            // 
            this.usersLoginComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usersLoginComboBox.FormattingEnabled = true;
            this.usersLoginComboBox.Location = new System.Drawing.Point(160, 13);
            this.usersLoginComboBox.Name = "usersLoginComboBox";
            this.usersLoginComboBox.Size = new System.Drawing.Size(146, 28);
            this.usersLoginComboBox.TabIndex = 23;
            // 
            // buttonAddNewThing
            // 
            this.buttonAddNewThing.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAddNewThing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddNewThing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonAddNewThing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAddNewThing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewThing.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewThing.Location = new System.Drawing.Point(205, 336);
            this.buttonAddNewThing.Name = "buttonAddNewThing";
            this.buttonAddNewThing.Size = new System.Drawing.Size(120, 32);
            this.buttonAddNewThing.TabIndex = 22;
            this.buttonAddNewThing.Text = "Добавить";
            this.buttonAddNewThing.UseVisualStyleBackColor = false;
            this.buttonAddNewThing.Click += new System.EventHandler(this.buttonAddNewThing_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker.Location = new System.Drawing.Point(419, 17);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(278, 26);
            this.dateTimePicker.TabIndex = 21;
            // 
            // commentField
            // 
            this.commentField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.commentField.Location = new System.Drawing.Point(16, 81);
            this.commentField.Name = "commentField";
            this.commentField.Size = new System.Drawing.Size(829, 247);
            this.commentField.TabIndex = 20;
            this.commentField.Text = "";
            this.commentField.Enter += new System.EventHandler(this.commentField_Enter);
            this.commentField.Leave += new System.EventHandler(this.commentField_Leave);
            // 
            // topicField
            // 
            this.topicField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.topicField.Location = new System.Drawing.Point(88, 49);
            this.topicField.Name = "topicField";
            this.topicField.Size = new System.Drawing.Size(757, 26);
            this.topicField.TabIndex = 19;
            this.topicField.Enter += new System.EventHandler(this.topicField_Enter);
            this.topicField.Leave += new System.EventHandler(this.topicField_Leave);
            // 
            // AddNewThing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "AddNewThing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewThing";
            this.Load += new System.EventHandler(this.AddNewThing_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usersLoginField;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox usersLoginComboBox;
        private System.Windows.Forms.Button buttonAddNewThing;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RichTextBox commentField;
        private System.Windows.Forms.TextBox topicField;
    }
}