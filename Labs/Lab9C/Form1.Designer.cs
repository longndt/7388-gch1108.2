namespace Lab9C
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.nudGPA = new System.Windows.Forms.NumericUpDown();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblUniversity = new System.Windows.Forms.Label();
            this.txtUniversity = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnVietnamese = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.ckbBestStudent = new System.Windows.Forms.CheckBox();
            this.lblBestStudent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudGPA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(37, 105);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(167, 42);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblBirthday
            // 
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.ForeColor = System.Drawing.Color.Red;
            this.lblBirthday.Location = new System.Drawing.Point(37, 168);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(167, 42);
            this.lblBirthday.TabIndex = 1;
            this.lblBirthday.Text = "Birthday";
            // 
            // lblGPA
            // 
            this.lblGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.ForeColor = System.Drawing.Color.Red;
            this.lblGPA.Location = new System.Drawing.Point(37, 232);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(167, 42);
            this.lblGPA.TabIndex = 2;
            this.lblGPA.Text = "GPA";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(315, 798);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 61);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(253, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(413, 35);
            this.txtName.TabIndex = 4;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(253, 168);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(294, 26);
            this.dtpBirthday.TabIndex = 5;
            // 
            // nudGPA
            // 
            this.nudGPA.DecimalPlaces = 1;
            this.nudGPA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudGPA.Location = new System.Drawing.Point(253, 232);
            this.nudGPA.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGPA.Name = "nudGPA";
            this.nudGPA.Size = new System.Drawing.Size(72, 26);
            this.nudGPA.TabIndex = 6;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.Aqua;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.Blue;
            this.lblAdd.Location = new System.Drawing.Point(277, 29);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(300, 40);
            this.lblAdd.TabIndex = 7;
            this.lblAdd.Text = "Add new student";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Blue;
            this.btnClear.Location = new System.Drawing.Point(463, 798);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 61);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblUniversity
            // 
            this.lblUniversity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniversity.ForeColor = System.Drawing.Color.Red;
            this.lblUniversity.Location = new System.Drawing.Point(37, 302);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(167, 42);
            this.lblUniversity.TabIndex = 9;
            this.lblUniversity.Text = "University";
            // 
            // txtUniversity
            // 
            this.txtUniversity.Enabled = false;
            this.txtUniversity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUniversity.ForeColor = System.Drawing.Color.Blue;
            this.txtUniversity.Location = new System.Drawing.Point(253, 302);
            this.txtUniversity.Name = "txtUniversity";
            this.txtUniversity.ReadOnly = true;
            this.txtUniversity.Size = new System.Drawing.Size(413, 35);
            this.txtUniversity.TabIndex = 10;
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Red;
            this.lblGender.Location = new System.Drawing.Point(37, 375);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(178, 42);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(253, 617);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(413, 154);
            this.txtDescription.TabIndex = 12;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Red;
            this.lblDescription.Location = new System.Drawing.Point(37, 617);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(178, 42);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description";
            // 
            // btnVietnamese
            // 
            this.btnVietnamese.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVietnamese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVietnamese.ForeColor = System.Drawing.Color.Blue;
            this.btnVietnamese.Location = new System.Drawing.Point(665, 29);
            this.btnVietnamese.Name = "btnVietnamese";
            this.btnVietnamese.Size = new System.Drawing.Size(146, 40);
            this.btnVietnamese.TabIndex = 14;
            this.btnVietnamese.Text = "Vietnamese";
            this.btnVietnamese.UseVisualStyleBackColor = false;
            this.btnVietnamese.Click += new System.EventHandler(this.btnVietnamese_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.ForeColor = System.Drawing.Color.Blue;
            this.btnEnglish.Location = new System.Drawing.Point(43, 29);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(128, 40);
            this.btnEnglish.TabIndex = 15;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = false;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.ForeColor = System.Drawing.Color.Blue;
            this.rbMale.Location = new System.Drawing.Point(253, 375);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(84, 29);
            this.rbMale.TabIndex = 16;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.ForeColor = System.Drawing.Color.Blue;
            this.rbFemale.Location = new System.Drawing.Point(358, 375);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(108, 29);
            this.rbFemale.TabIndex = 17;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Red;
            this.lblDepartment.Location = new System.Drawing.Point(37, 452);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(187, 42);
            this.lblDepartment.TabIndex = 18;
            this.lblDepartment.Text = "Department";
            // 
            // cbDepartment
            // 
            this.cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "Computing",
            "Graphic Design",
            "Business"});
            this.cbDepartment.Location = new System.Drawing.Point(253, 452);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(413, 37);
            this.cbDepartment.TabIndex = 19;
            // 
            // ckbBestStudent
            // 
            this.ckbBestStudent.AutoSize = true;
            this.ckbBestStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBestStudent.Location = new System.Drawing.Point(253, 543);
            this.ckbBestStudent.Name = "ckbBestStudent";
            this.ckbBestStudent.Size = new System.Drawing.Size(22, 21);
            this.ckbBestStudent.TabIndex = 20;
            this.ckbBestStudent.UseVisualStyleBackColor = true;
            // 
            // lblBestStudent
            // 
            this.lblBestStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestStudent.ForeColor = System.Drawing.Color.Red;
            this.lblBestStudent.Location = new System.Drawing.Point(37, 535);
            this.lblBestStudent.Name = "lblBestStudent";
            this.lblBestStudent.Size = new System.Drawing.Size(187, 42);
            this.lblBestStudent.TabIndex = 21;
            this.lblBestStudent.Text = "Best student";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(823, 901);
            this.Controls.Add(this.lblBestStudent);
            this.Controls.Add(this.ckbBestStudent);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnVietnamese);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtUniversity);
            this.Controls.Add(this.lblUniversity);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.nudGPA);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudGPA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nudGPA;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.TextBox txtUniversity;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnVietnamese;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.CheckBox ckbBestStudent;
        private System.Windows.Forms.Label lblBestStudent;
    }
}

