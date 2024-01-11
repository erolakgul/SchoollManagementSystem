namespace OkulYönetimSistemi.UI
{
    partial class AttendanceEdit
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
            this.listStuAtt = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHours = new System.Windows.Forms.ComboBox();
            this.listAtt = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAllStu = new System.Windows.Forms.Button();
            this.btnRemoveStu = new System.Windows.Forms.Button();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listStu = new System.Windows.Forms.ListBox();
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            this.listTea = new System.Windows.Forms.ListBox();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.listClassLectures = new System.Windows.Forms.ListBox();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.listClass = new System.Windows.Forms.ListBox();
            this.btnClassDelete = new System.Windows.Forms.Button();
            this.btnClassEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listStuAtt
            // 
            this.listStuAtt.FormattingEnabled = true;
            this.listStuAtt.ItemHeight = 14;
            this.listStuAtt.Location = new System.Drawing.Point(184, 31);
            this.listStuAtt.Margin = new System.Windows.Forms.Padding(2);
            this.listStuAtt.Name = "listStuAtt";
            this.listStuAtt.Size = new System.Drawing.Size(194, 116);
            this.listStuAtt.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 14);
            this.label8.TabIndex = 31;
            this.label8.Text = "Yoklamada Mevcut Öğrenciler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 31;
            this.label5.Text = "Öğrenciler";
            // 
            // cmbHours
            // 
            this.cmbHours.FormattingEnabled = true;
            this.cmbHours.Location = new System.Drawing.Point(257, 133);
            this.cmbHours.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHours.Name = "cmbHours";
            this.cmbHours.Size = new System.Drawing.Size(104, 22);
            this.cmbHours.TabIndex = 33;
            // 
            // listAtt
            // 
            this.listAtt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listAtt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listAtt.FullRowSelect = true;
            this.listAtt.GridLines = true;
            this.listAtt.Location = new System.Drawing.Point(2, 162);
            this.listAtt.Margin = new System.Windows.Forms.Padding(2);
            this.listAtt.MultiSelect = false;
            this.listAtt.Name = "listAtt";
            this.listAtt.Size = new System.Drawing.Size(713, 149);
            this.listAtt.TabIndex = 32;
            this.listAtt.UseCompatibleStateImageBehavior = false;
            this.listAtt.View = System.Windows.Forms.View.Details;
            this.listAtt.SelectedIndexChanged += new System.EventHandler(this.listAtt_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tarih";
            this.columnHeader1.Width = 173;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Öğretmen";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sınıf";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ders";
            this.columnHeader4.Width = 147;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ders Saati";
            this.columnHeader5.Width = 112;
            // 
            // btnAllStu
            // 
            this.btnAllStu.Location = new System.Drawing.Point(427, 124);
            this.btnAllStu.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllStu.Name = "btnAllStu";
            this.btnAllStu.Size = new System.Drawing.Size(116, 23);
            this.btnAllStu.TabIndex = 33;
            this.btnAllStu.Text = "Toplu Yoklama";
            this.btnAllStu.UseVisualStyleBackColor = true;
            this.btnAllStu.Click += new System.EventHandler(this.btnAllStu_Click);
            // 
            // btnRemoveStu
            // 
            this.btnRemoveStu.Location = new System.Drawing.Point(427, 79);
            this.btnRemoveStu.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveStu.Name = "btnRemoveStu";
            this.btnRemoveStu.Size = new System.Drawing.Size(116, 25);
            this.btnRemoveStu.TabIndex = 33;
            this.btnRemoveStu.Text = "Çıkar";
            this.btnRemoveStu.UseVisualStyleBackColor = true;
            this.btnRemoveStu.Click += new System.EventHandler(this.btnRemoveStu_Click);
            // 
            // btnAddStu
            // 
            this.btnAddStu.Location = new System.Drawing.Point(427, 31);
            this.btnAddStu.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(116, 29);
            this.btnAddStu.TabIndex = 33;
            this.btnAddStu.Text = "Ekle";
            this.btnAddStu.UseVisualStyleBackColor = true;
            this.btnAddStu.Click += new System.EventHandler(this.btnAddStu_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAllStu);
            this.tabPage2.Controls.Add(this.btnRemoveStu);
            this.tabPage2.Controls.Add(this.btnAddStu);
            this.tabPage2.Controls.Add(this.listStuAtt);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.listStu);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(717, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Öğrenci Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listStu
            // 
            this.listStu.FormattingEnabled = true;
            this.listStu.ItemHeight = 14;
            this.listStu.Location = new System.Drawing.Point(20, 31);
            this.listStu.Margin = new System.Windows.Forms.Padding(2);
            this.listStu.Name = "listStu";
            this.listStu.Size = new System.Drawing.Size(146, 116);
            this.listStu.TabIndex = 32;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(464, 3);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(163, 51);
            this.txtStatus.TabIndex = 31;
            this.txtStatus.Text = "";
            // 
            // listTea
            // 
            this.listTea.FormattingEnabled = true;
            this.listTea.ItemHeight = 14;
            this.listTea.Location = new System.Drawing.Point(257, 3);
            this.listTea.Margin = new System.Windows.Forms.Padding(2);
            this.listTea.Name = "listTea";
            this.listTea.Size = new System.Drawing.Size(106, 60);
            this.listTea.TabIndex = 30;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(256, 85);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.Mask = "00/00/0000 90:00";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(106, 21);
            this.txtDate.TabIndex = 29;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // listClassLectures
            // 
            this.listClassLectures.FormattingEnabled = true;
            this.listClassLectures.ItemHeight = 14;
            this.listClassLectures.Location = new System.Drawing.Point(58, 88);
            this.listClassLectures.Margin = new System.Windows.Forms.Padding(2);
            this.listClassLectures.Name = "listClassLectures";
            this.listClassLectures.Size = new System.Drawing.Size(110, 60);
            this.listClassLectures.TabIndex = 28;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(408, 130);
            this.btnAddClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(68, 27);
            this.btnAddClass.TabIndex = 27;
            this.btnAddClass.Text = "Ekle";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // listClass
            // 
            this.listClass.FormattingEnabled = true;
            this.listClass.ItemHeight = 14;
            this.listClass.Location = new System.Drawing.Point(58, 3);
            this.listClass.Margin = new System.Windows.Forms.Padding(2);
            this.listClass.Name = "listClass";
            this.listClass.Size = new System.Drawing.Size(110, 60);
            this.listClass.TabIndex = 26;
            this.listClass.SelectedIndexChanged += new System.EventHandler(this.listClass_SelectedIndexChanged);
            // 
            // btnClassDelete
            // 
            this.btnClassDelete.Location = new System.Drawing.Point(559, 130);
            this.btnClassDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnClassDelete.Name = "btnClassDelete";
            this.btnClassDelete.Size = new System.Drawing.Size(68, 27);
            this.btnClassDelete.TabIndex = 24;
            this.btnClassDelete.Text = "Sil";
            this.btnClassDelete.UseVisualStyleBackColor = true;
            this.btnClassDelete.Click += new System.EventHandler(this.btnClassDelete_Click);
            // 
            // btnClassEdit
            // 
            this.btnClassEdit.Location = new System.Drawing.Point(480, 130);
            this.btnClassEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnClassEdit.Name = "btnClassEdit";
            this.btnClassEdit.Size = new System.Drawing.Size(75, 27);
            this.btnClassEdit.TabIndex = 25;
            this.btnClassEdit.Text = "Güncelle";
            this.btnClassEdit.UseVisualStyleBackColor = true;
            this.btnClassEdit.Click += new System.EventHandler(this.btnClassEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "gg.aa.yyyy ss.dd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ders Saati";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ders";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 23;
            this.label6.Text = "Durum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "Öğretmen";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 14);
            this.label11.TabIndex = 23;
            this.label11.Text = "Sınıf";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbHours);
            this.tabPage1.Controls.Add(this.listAtt);
            this.tabPage1.Controls.Add(this.txtStatus);
            this.tabPage1.Controls.Add(this.listTea);
            this.tabPage1.Controls.Add(this.txtDate);
            this.tabPage1.Controls.Add(this.listClassLectures);
            this.tabPage1.Controls.Add(this.btnAddClass);
            this.tabPage1.Controls.Add(this.listClass);
            this.tabPage1.Controls.Add(this.btnClassDelete);
            this.tabPage1.Controls.Add(this.btnClassEdit);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(717, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Yoklama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(729, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yoklamalar";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(2, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 340);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // AttendanceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 358);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttendanceEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceEdit";
            this.Load += new System.EventHandler(this.AttendanceEdit_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listStuAtt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHours;
        private System.Windows.Forms.ListView listAtt;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnAllStu;
        private System.Windows.Forms.Button btnRemoveStu;
        private System.Windows.Forms.Button btnAddStu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listStu;
        private System.Windows.Forms.RichTextBox txtStatus;
        private System.Windows.Forms.ListBox listTea;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.ListBox listClassLectures;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.ListBox listClass;
        private System.Windows.Forms.Button btnClassDelete;
        private System.Windows.Forms.Button btnClassEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}