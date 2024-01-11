namespace OkulYönetimSistemi.UI
{
    partial class StudentPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pctrLecture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pctrExam = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLecture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrExam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(223, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Panel Yönetimi";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(671, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(26, 25);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(246, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dersler";
            // 
            // pctrLecture
            // 
            this.pctrLecture.BackgroundImage = global::OkulYönetimSistemi.UI.Properties.Resources.Lecture_icon;
            this.pctrLecture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctrLecture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrLecture.Location = new System.Drawing.Point(227, 56);
            this.pctrLecture.Name = "pctrLecture";
            this.pctrLecture.Size = new System.Drawing.Size(100, 101);
            this.pctrLecture.TabIndex = 11;
            this.pctrLecture.TabStop = false;
            this.pctrLecture.Click += new System.EventHandler(this.pctrLecture_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(358, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sınavlar";
            // 
            // pctrExam
            // 
            this.pctrExam.BackgroundImage = global::OkulYönetimSistemi.UI.Properties.Resources.Exam_icon;
            this.pctrExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctrExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrExam.Location = new System.Drawing.Point(343, 56);
            this.pctrExam.Name = "pctrExam";
            this.pctrExam.Size = new System.Drawing.Size(100, 101);
            this.pctrExam.TabIndex = 14;
            this.pctrExam.TabStop = false;
            this.pctrExam.Click += new System.EventHandler(this.pctrExam_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Monospac821 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.Location = new System.Drawing.Point(549, 47);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 15);
            this.lblUser.TabIndex = 16;
            this.lblUser.Text = "....";
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 210);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pctrExam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pctrLecture);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPanel";
            this.Load += new System.EventHandler(this.StudentPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrLecture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrExam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pctrLecture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pctrExam;
        private System.Windows.Forms.Label lblUser;
    }
}