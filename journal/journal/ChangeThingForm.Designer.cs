﻿
namespace journal
{
    partial class ChangeThingForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.usersLoginFild = new System.Windows.Forms.TextBox();
            this.usersLoginComboBox = new System.Windows.Forms.ComboBox();
            this.idFild = new System.Windows.Forms.TextBox();
            this.buttonChangeThing = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Изменение задачи";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.usersLoginFild);
            this.panel2.Controls.Add(this.usersLoginComboBox);
            this.panel2.Controls.Add(this.idFild);
            this.panel2.Controls.Add(this.buttonChangeThing);
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Controls.Add(this.commentField);
            this.panel2.Controls.Add(this.topicField);
            this.panel2.Location = new System.Drawing.Point(12, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 380);
            this.panel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(703, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(339, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 32;
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
            this.label3.TabIndex = 31;
            this.label3.Text = "Задча";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Пользователь:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(512, 336);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 32);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // usersLoginFild
            // 
            this.usersLoginFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usersLoginFild.Location = new System.Drawing.Point(160, 11);
            this.usersLoginFild.Name = "usersLoginFild";
            this.usersLoginFild.ReadOnly = true;
            this.usersLoginFild.Size = new System.Drawing.Size(136, 26);
            this.usersLoginFild.TabIndex = 28;
            // 
            // usersLoginComboBox
            // 
            this.usersLoginComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usersLoginComboBox.FormattingEnabled = true;
            this.usersLoginComboBox.Location = new System.Drawing.Point(160, 13);
            this.usersLoginComboBox.Name = "usersLoginComboBox";
            this.usersLoginComboBox.Size = new System.Drawing.Size(146, 28);
            this.usersLoginComboBox.TabIndex = 27;
            // 
            // idFild
            // 
            this.idFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idFild.Location = new System.Drawing.Point(745, 17);
            this.idFild.Name = "idFild";
            this.idFild.ReadOnly = true;
            this.idFild.Size = new System.Drawing.Size(100, 26);
            this.idFild.TabIndex = 26;
            // 
            // buttonChangeThing
            // 
            this.buttonChangeThing.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonChangeThing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeThing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonChangeThing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonChangeThing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeThing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonChangeThing.ForeColor = System.Drawing.Color.White;
            this.buttonChangeThing.Location = new System.Drawing.Point(203, 336);
            this.buttonChangeThing.Name = "buttonChangeThing";
            this.buttonChangeThing.Size = new System.Drawing.Size(120, 32);
            this.buttonChangeThing.TabIndex = 25;
            this.buttonChangeThing.Text = "Изменить";
            this.buttonChangeThing.UseVisualStyleBackColor = false;
            this.buttonChangeThing.Click += new System.EventHandler(this.buttonChangeThing_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker.Location = new System.Drawing.Point(419, 17);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(278, 26);
            this.dateTimePicker.TabIndex = 24;
            // 
            // commentField
            // 
            this.commentField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.commentField.Location = new System.Drawing.Point(16, 81);
            this.commentField.Name = "commentField";
            this.commentField.Size = new System.Drawing.Size(829, 246);
            this.commentField.TabIndex = 23;
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
            this.topicField.TabIndex = 22;
            this.topicField.Enter += new System.EventHandler(this.topicField_Enter);
            this.topicField.Leave += new System.EventHandler(this.topicField_Leave);
            // 
            // ChangeThingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "ChangeThingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangeThingForm";
            this.Load += new System.EventHandler(this.ChangeThingForm_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox usersLoginFild;
        private System.Windows.Forms.ComboBox usersLoginComboBox;
        private System.Windows.Forms.TextBox idFild;
        private System.Windows.Forms.Button buttonChangeThing;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RichTextBox commentField;
        private System.Windows.Forms.TextBox topicField;
    }
}