namespace WindowsFormsApp6
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.BirthdateTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.PhoneTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.EmailTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.SurnameTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.NameTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.Birthdatelbl = new System.Windows.Forms.Label();
            this.Phonelbl = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Surnamelbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.PersonListBox = new System.Windows.Forms.ListBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.FilenameLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.ChangeBtn);
            this.groupBox1.Controls.Add(this.BirthdateTxtBx);
            this.groupBox1.Controls.Add(this.PhoneTxtBx);
            this.groupBox1.Controls.Add(this.EmailTxtBx);
            this.groupBox1.Controls.Add(this.SurnameTxtBx);
            this.groupBox1.Controls.Add(this.NameTxtBx);
            this.groupBox1.Controls.Add(this.Birthdatelbl);
            this.groupBox1.Controls.Add(this.Phonelbl);
            this.groupBox1.Controls.Add(this.Emaillbl);
            this.groupBox1.Controls.Add(this.Surnamelbl);
            this.groupBox1.Controls.Add(this.namelbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anket";
            // 
            // AddBtn
            // 
            this.AddBtn.ForeColor = System.Drawing.Color.Red;
            this.AddBtn.Location = new System.Drawing.Point(324, 341);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(101, 41);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.ForeColor = System.Drawing.Color.Blue;
            this.ChangeBtn.Location = new System.Drawing.Point(324, 283);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(101, 41);
            this.ChangeBtn.TabIndex = 10;
            this.ChangeBtn.Text = "Change";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // BirthdateTxtBx
            // 
            this.BirthdateTxtBx.Location = new System.Drawing.Point(135, 234);
            this.BirthdateTxtBx.Mask = "0000/00/00";
            this.BirthdateTxtBx.Name = "BirthdateTxtBx";
            this.BirthdateTxtBx.Size = new System.Drawing.Size(290, 31);
            this.BirthdateTxtBx.TabIndex = 9;
            this.BirthdateTxtBx.ValidatingType = typeof(System.DateTime);
            // 
            // PhoneTxtBx
            // 
            this.PhoneTxtBx.Culture = new System.Globalization.CultureInfo("");
            this.PhoneTxtBx.Location = new System.Drawing.Point(135, 184);
            this.PhoneTxtBx.Mask = "(994) 00-000-00-00";
            this.PhoneTxtBx.Name = "PhoneTxtBx";
            this.PhoneTxtBx.Size = new System.Drawing.Size(290, 31);
            this.PhoneTxtBx.TabIndex = 8;
            this.PhoneTxtBx.Text = "99";
            // 
            // EmailTxtBx
            // 
            this.EmailTxtBx.Location = new System.Drawing.Point(135, 136);
            this.EmailTxtBx.Name = "EmailTxtBx";
            this.EmailTxtBx.Size = new System.Drawing.Size(290, 31);
            this.EmailTxtBx.TabIndex = 7;
            // 
            // SurnameTxtBx
            // 
            this.SurnameTxtBx.Location = new System.Drawing.Point(135, 91);
            this.SurnameTxtBx.Name = "SurnameTxtBx";
            this.SurnameTxtBx.Size = new System.Drawing.Size(290, 31);
            this.SurnameTxtBx.TabIndex = 6;
            // 
            // NameTxtBx
            // 
            this.NameTxtBx.Location = new System.Drawing.Point(135, 43);
            this.NameTxtBx.Name = "NameTxtBx";
            this.NameTxtBx.Size = new System.Drawing.Size(290, 31);
            this.NameTxtBx.TabIndex = 5;
            // 
            // Birthdatelbl
            // 
            this.Birthdatelbl.AutoSize = true;
            this.Birthdatelbl.Location = new System.Drawing.Point(24, 237);
            this.Birthdatelbl.Name = "Birthdatelbl";
            this.Birthdatelbl.Size = new System.Drawing.Size(107, 25);
            this.Birthdatelbl.TabIndex = 4;
            this.Birthdatelbl.Text = "Birthdate";
            // 
            // Phonelbl
            // 
            this.Phonelbl.AutoSize = true;
            this.Phonelbl.Location = new System.Drawing.Point(24, 190);
            this.Phonelbl.Name = "Phonelbl";
            this.Phonelbl.Size = new System.Drawing.Size(79, 25);
            this.Phonelbl.TabIndex = 3;
            this.Phonelbl.Text = "Phone";
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Location = new System.Drawing.Point(24, 142);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(70, 25);
            this.Emaillbl.TabIndex = 2;
            this.Emaillbl.Text = "Email";
            // 
            // Surnamelbl
            // 
            this.Surnamelbl.AutoSize = true;
            this.Surnamelbl.Location = new System.Drawing.Point(24, 97);
            this.Surnamelbl.Name = "Surnamelbl";
            this.Surnamelbl.Size = new System.Drawing.Size(105, 25);
            this.Surnamelbl.TabIndex = 1;
            this.Surnamelbl.Text = "Surname";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(24, 49);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(72, 25);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "Name";
            // 
            // PersonListBox
            // 
            this.PersonListBox.FormattingEnabled = true;
            this.PersonListBox.Location = new System.Drawing.Point(465, 24);
            this.PersonListBox.Name = "PersonListBox";
            this.PersonListBox.Size = new System.Drawing.Size(303, 264);
            this.PersonListBox.TabIndex = 1;
            this.PersonListBox.SelectedIndexChanged += new System.EventHandler(this.PersonListBox_SelectedIndexChanged);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.LoadBtn.Location = new System.Drawing.Point(489, 371);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(101, 41);
            this.LoadBtn.TabIndex = 11;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.Red;
            this.SaveBtn.Location = new System.Drawing.Point(630, 371);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(101, 41);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // FilenameLbl
            // 
            this.FilenameLbl.AutoSize = true;
            this.FilenameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilenameLbl.Location = new System.Drawing.Point(547, 305);
            this.FilenameLbl.Name = "FilenameLbl";
            this.FilenameLbl.Size = new System.Drawing.Size(133, 31);
            this.FilenameLbl.TabIndex = 13;
            this.FilenameLbl.Text = "Filename";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilenameLbl);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.PersonListBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.MaskedTextBox BirthdateTxtBx;
        private System.Windows.Forms.MaskedTextBox PhoneTxtBx;
        private System.Windows.Forms.MaskedTextBox EmailTxtBx;
        private System.Windows.Forms.MaskedTextBox SurnameTxtBx;
        private System.Windows.Forms.MaskedTextBox NameTxtBx;
        private System.Windows.Forms.Label Birthdatelbl;
        private System.Windows.Forms.Label Phonelbl;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label Surnamelbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.ListBox PersonListBox;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label FilenameLbl;
    }
}

