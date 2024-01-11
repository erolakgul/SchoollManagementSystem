namespace OkulYönetimSistemi.UI
{
    partial class LectureEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LectureEdit));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listLec = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLecStatus = new System.Windows.Forms.RichTextBox();
            this.btnDeleteLec = new System.Windows.Forms.Button();
            this.btnUpdateLec = new System.Windows.Forms.Button();
            this.btnAddLec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLecDes = new System.Windows.Forms.TextBox();
            this.txtLecName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listClassLectures = new System.Windows.Forms.ListBox();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.listClass = new System.Windows.Forms.ListBox();
            this.chkClassLec = new System.Windows.Forms.CheckedListBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.btnClassDelete = new System.Windows.Forms.Button();
            this.btnClassEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtClassStatus = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(726, 357);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listLec);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtLecStatus);
            this.tabPage1.Controls.Add(this.btnDeleteLec);
            this.tabPage1.Controls.Add(this.btnUpdateLec);
            this.tabPage1.Controls.Add(this.btnAddLec);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtLecDes);
            this.tabPage1.Controls.Add(this.txtLecName);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(718, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dersler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listLec
            // 
            this.listLec.FormattingEnabled = true;
            this.listLec.ItemHeight = 14;
            this.listLec.Location = new System.Drawing.Point(510, 26);
            this.listLec.Margin = new System.Windows.Forms.Padding(2);
            this.listLec.Name = "listLec";
            this.listLec.Size = new System.Drawing.Size(166, 214);
            this.listLec.TabIndex = 31;
            this.listLec.SelectedIndexChanged += new System.EventHandler(this.listLec_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(452, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 14);
            this.label12.TabIndex = 30;
            this.label12.Text = "Dersler";
            // 
            // txtLecStatus
            // 
            this.txtLecStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLecStatus.Location = new System.Drawing.Point(3, 248);
            this.txtLecStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtLecStatus.Name = "txtLecStatus";
            this.txtLecStatus.Size = new System.Drawing.Size(712, 79);
            this.txtLecStatus.TabIndex = 29;
            this.txtLecStatus.Text = "";
            // 
            // btnDeleteLec
            // 
            this.btnDeleteLec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteLec.Location = new System.Drawing.Point(342, 141);
            this.btnDeleteLec.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteLec.Name = "btnDeleteLec";
            this.btnDeleteLec.Size = new System.Drawing.Size(68, 27);
            this.btnDeleteLec.TabIndex = 26;
            this.btnDeleteLec.Text = "Sil";
            this.btnDeleteLec.UseVisualStyleBackColor = true;
            this.btnDeleteLec.Click += new System.EventHandler(this.btnDeleteLec_Click);
            // 
            // btnUpdateLec
            // 
            this.btnUpdateLec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateLec.Location = new System.Drawing.Point(245, 141);
            this.btnUpdateLec.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateLec.Name = "btnUpdateLec";
            this.btnUpdateLec.Size = new System.Drawing.Size(74, 27);
            this.btnUpdateLec.TabIndex = 27;
            this.btnUpdateLec.Text = "Güncelle";
            this.btnUpdateLec.UseVisualStyleBackColor = true;
            this.btnUpdateLec.Click += new System.EventHandler(this.btnUpdateLec_Click);
            // 
            // btnAddLec
            // 
            this.btnAddLec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLec.Location = new System.Drawing.Point(146, 141);
            this.btnAddLec.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddLec.Name = "btnAddLec";
            this.btnAddLec.Size = new System.Drawing.Size(68, 27);
            this.btnAddLec.TabIndex = 28;
            this.btnAddLec.Text = "Ekle";
            this.btnAddLec.UseVisualStyleBackColor = true;
            this.btnAddLec.Click += new System.EventHandler(this.btnAddLec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 24;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ders Adı";
            // 
            // txtLecDes
            // 
            this.txtLecDes.Location = new System.Drawing.Point(98, 56);
            this.txtLecDes.Margin = new System.Windows.Forms.Padding(2);
            this.txtLecDes.Multiline = true;
            this.txtLecDes.Name = "txtLecDes";
            this.txtLecDes.Size = new System.Drawing.Size(116, 61);
            this.txtLecDes.TabIndex = 22;
            // 
            // txtLecName
            // 
            this.txtLecName.Location = new System.Drawing.Point(98, 19);
            this.txtLecName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLecName.Name = "txtLecName";
            this.txtLecName.Size = new System.Drawing.Size(116, 21);
            this.txtLecName.TabIndex = 23;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listClassLectures);
            this.tabPage2.Controls.Add(this.btnAddClass);
            this.tabPage2.Controls.Add(this.listClass);
            this.tabPage2.Controls.Add(this.chkClassLec);
            this.tabPage2.Controls.Add(this.cmbGrade);
            this.tabPage2.Controls.Add(this.btnClassDelete);
            this.tabPage2.Controls.Add(this.btnClassEdit);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtClassName);
            this.tabPage2.Controls.Add(this.txtClassStatus);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(718, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sınıflar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listClassLectures
            // 
            this.listClassLectures.FormattingEnabled = true;
            this.listClassLectures.ItemHeight = 14;
            this.listClassLectures.Location = new System.Drawing.Point(520, 178);
            this.listClassLectures.Margin = new System.Windows.Forms.Padding(2);
            this.listClassLectures.Name = "listClassLectures";
            this.listClassLectures.Size = new System.Drawing.Size(130, 144);
            this.listClassLectures.TabIndex = 35;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClass.Location = new System.Drawing.Point(275, 18);
            this.btnAddClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(107, 27);
            this.btnAddClass.TabIndex = 34;
            this.btnAddClass.Text = "Ekle";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // listClass
            // 
            this.listClass.FormattingEnabled = true;
            this.listClass.ItemHeight = 14;
            this.listClass.Location = new System.Drawing.Point(520, 18);
            this.listClass.Margin = new System.Windows.Forms.Padding(2);
            this.listClass.Name = "listClass";
            this.listClass.Size = new System.Drawing.Size(130, 144);
            this.listClass.TabIndex = 33;
            this.listClass.SelectedIndexChanged += new System.EventHandler(this.listClass_SelectedIndexChanged);
            // 
            // chkClassLec
            // 
            this.chkClassLec.FormattingEnabled = true;
            this.chkClassLec.Location = new System.Drawing.Point(87, 95);
            this.chkClassLec.Margin = new System.Windows.Forms.Padding(2);
            this.chkClassLec.Name = "chkClassLec";
            this.chkClassLec.Size = new System.Drawing.Size(130, 228);
            this.chkClassLec.TabIndex = 32;
            // 
            // cmbGrade
            // 
            this.cmbGrade.Location = new System.Drawing.Point(88, 60);
            this.cmbGrade.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(55, 22);
            this.cmbGrade.TabIndex = 31;
            // 
            // btnClassDelete
            // 
            this.btnClassDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassDelete.Location = new System.Drawing.Point(275, 195);
            this.btnClassDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnClassDelete.Name = "btnClassDelete";
            this.btnClassDelete.Size = new System.Drawing.Size(107, 27);
            this.btnClassDelete.TabIndex = 29;
            this.btnClassDelete.Text = "Sil";
            this.btnClassDelete.UseVisualStyleBackColor = true;
            this.btnClassDelete.Click += new System.EventHandler(this.btnClassDelete_Click);
            // 
            // btnClassEdit
            // 
            this.btnClassEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassEdit.Location = new System.Drawing.Point(275, 106);
            this.btnClassEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnClassEdit.Name = "btnClassEdit";
            this.btnClassEdit.Size = new System.Drawing.Size(107, 27);
            this.btnClassEdit.TabIndex = 30;
            this.btnClassEdit.Text = "Güncelle";
            this.btnClassEdit.UseVisualStyleBackColor = true;
            this.btnClassEdit.Click += new System.EventHandler(this.btnClassEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 14);
            this.label6.TabIndex = 24;
            this.label6.Text = "Dersler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 25;
            this.label7.Text = "Derecesi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 14);
            this.label8.TabIndex = 26;
            this.label8.Text = "Sınıf Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "Alınan Dersler";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 14);
            this.label11.TabIndex = 28;
            this.label11.Text = "Sınıflar";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(87, 18);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(2);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(130, 21);
            this.txtClassName.TabIndex = 23;
            // 
            // txtClassStatus
            // 
            this.txtClassStatus.Location = new System.Drawing.Point(275, 263);
            this.txtClassStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtClassStatus.Name = "txtClassStatus";
            this.txtClassStatus.Size = new System.Drawing.Size(241, 59);
            this.txtClassStatus.TabIndex = 22;
            this.txtClassStatus.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(718, 330);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Help";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(217, 263);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(424, 39);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Sınıflar kısmından dersi seçtikten sonra Sil butonu ile sınıfı kaldırabilirsiniz." +
    "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 14);
            this.label9.TabIndex = 4;
            this.label9.Text = "Silme İşlemi     :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(217, 108);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(424, 128);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Güncelleme İşlemi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ekleme İşlemi     :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(424, 51);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Sınıf adı ve kaçıncı sınıf olduğu bilgisi girildikten sonra listede sınıflar seçi" +
    "lir ve EKLE butonu kullanılarak sınıf ve o sınıfa ait dersler oluşturulmuş olur " +
    ".";
            // 
            // LectureEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 358);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LectureEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LectureEdit";
            this.Load += new System.EventHandler(this.LectureEdit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listLec;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtLecStatus;
        private System.Windows.Forms.Button btnDeleteLec;
        private System.Windows.Forms.Button btnUpdateLec;
        private System.Windows.Forms.Button btnAddLec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLecDes;
        private System.Windows.Forms.TextBox txtLecName;
        private System.Windows.Forms.ListBox listClassLectures;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.ListBox listClass;
        private System.Windows.Forms.CheckedListBox chkClassLec;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Button btnClassDelete;
        private System.Windows.Forms.Button btnClassEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.RichTextBox txtClassStatus;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
    }
}