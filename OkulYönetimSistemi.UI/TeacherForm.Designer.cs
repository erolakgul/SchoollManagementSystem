namespace OkulYönetimSistemi.UI
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pctrReports = new System.Windows.Forms.PictureBox();
            this.pctrAttendance = new System.Windows.Forms.PictureBox();
            this.pctrLecture = new System.Windows.Forms.PictureBox();
            this.pctrExam = new System.Windows.Forms.PictureBox();
            this.pctrStudent = new System.Windows.Forms.PictureBox();
            this.pctrTeacher = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTFCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLecture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Öğretmen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(147, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Öğrenci";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(383, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sınavlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(267, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dersler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(507, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Yoklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(622, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Raporlar";
            // 
            // pctrReports
            // 
            this.pctrReports.BackColor = System.Drawing.SystemColors.Control;
            this.pctrReports.BackgroundImage = global::OkulYönetimSistemi.UI.Properties.Resources.Reports_icon;
            this.pctrReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctrReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrReports.Location = new System.Drawing.Point(608, 100);
            this.pctrReports.Name = "pctrReports";
            this.pctrReports.Size = new System.Drawing.Size(100, 101);
            this.pctrReports.TabIndex = 5;
            this.pctrReports.TabStop = false;
            this.pctrReports.Click += new System.EventHandler(this.pctrReports_Click);
            // 
            // pctrAttendance
            // 
            this.pctrAttendance.BackgroundImage = global::OkulYönetimSistemi.UI.Properties.Resources.Attendance_icon;
            this.pctrAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctrAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrAttendance.Location = new System.Drawing.Point(488, 100);
            this.pctrAttendance.Name = "pctrAttendance";
            this.pctrAttendance.Size = new System.Drawing.Size(100, 101);
            this.pctrAttendance.TabIndex = 4;
            this.pctrAttendance.TabStop = false;
            this.pctrAttendance.Click += new System.EventHandler(this.pctrAttendance_Click);
            // 
            // pctrLecture
            // 
            this.pctrLecture.BackgroundImage = global::OkulYönetimSistemi.UI.Properties.Resources.Lecture_icon;
            this.pctrLecture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctrLecture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrLecture.Location = new System.Drawing.Point(248, 100);
            this.pctrLecture.Name = "pctrLecture";
            this.pctrLecture.Size = new System.Drawing.Size(100, 101);
            this.pctrLecture.TabIndex = 3;
            this.pctrLecture.TabStop = false;
            this.pctrLecture.Click += new System.EventHandler(this.pctrLecture_Click);
            // 
            // pctrExam
            // 
            this.pctrExam.BackgroundImage = global::OkulYönetimSistemi.UI.Properties.Resources.Exam_icon;
            this.pctrExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctrExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrExam.Location = new System.Drawing.Point(368, 100);
            this.pctrExam.Name = "pctrExam";
            this.pctrExam.Size = new System.Drawing.Size(100, 101);
            this.pctrExam.TabIndex = 2;
            this.pctrExam.TabStop = false;
            this.pctrExam.Click += new System.EventHandler(this.pctrExam_Click);
            // 
            // pctrStudent
            // 
            this.pctrStudent.BackgroundImage = global::OkulYönetimSistemi.UI.Properties.Resources.Student_icon;
            this.pctrStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctrStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrStudent.Location = new System.Drawing.Point(131, 100);
            this.pctrStudent.Name = "pctrStudent";
            this.pctrStudent.Size = new System.Drawing.Size(100, 101);
            this.pctrStudent.TabIndex = 1;
            this.pctrStudent.TabStop = false;
            this.pctrStudent.Click += new System.EventHandler(this.pctrStudent_Click);
            // 
            // pctrTeacher
            // 
            this.pctrTeacher.BackgroundImage = global::OkulYönetimSistemi.UI.Properties.Resources.Teacher_icon;
            this.pctrTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctrTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrTeacher.Location = new System.Drawing.Point(14, 100);
            this.pctrTeacher.Name = "pctrTeacher";
            this.pctrTeacher.Size = new System.Drawing.Size(100, 101);
            this.pctrTeacher.TabIndex = 0;
            this.pctrTeacher.TabStop = false;
            this.pctrTeacher.Click += new System.EventHandler(this.pctrTeacher_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bilgi Yönetim Sistemi";
            // 
            // btnTFCancel
            // 
            this.btnTFCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnTFCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTFCancel.BackgroundImage")));
            this.btnTFCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTFCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTFCancel.Location = new System.Drawing.Point(677, 12);
            this.btnTFCancel.Name = "btnTFCancel";
            this.btnTFCancel.Size = new System.Drawing.Size(28, 28);
            this.btnTFCancel.TabIndex = 13;
            this.btnTFCancel.UseVisualStyleBackColor = false;
            this.btnTFCancel.Click += new System.EventHandler(this.btnTFCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(545, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hoşgeldiniz";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.Location = new System.Drawing.Point(639, 54);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 14);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = " ....";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 249);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTFCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctrReports);
            this.Controls.Add(this.pctrAttendance);
            this.Controls.Add(this.pctrLecture);
            this.Controls.Add(this.pctrExam);
            this.Controls.Add(this.pctrStudent);
            this.Controls.Add(this.pctrTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi Yönetim Sistemi";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLecture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrTeacher;
        private System.Windows.Forms.PictureBox pctrStudent;
        private System.Windows.Forms.PictureBox pctrExam;
        private System.Windows.Forms.PictureBox pctrLecture;
        private System.Windows.Forms.PictureBox pctrAttendance;
        private System.Windows.Forms.PictureBox pctrReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTFCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUser;
    }
}