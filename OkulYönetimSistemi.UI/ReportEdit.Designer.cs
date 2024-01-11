namespace OkulYönetimSistemi.UI
{
    partial class ReportEdit
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAllStudent = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbOgr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSınıf = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewSonuclar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(2, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 340);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAllStudent);
            this.tabPage2.Controls.Add(this.btnFilter);
            this.tabPage2.Controls.Add(this.cmbOgr);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cmbDers);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmbSınıf);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listViewSonuclar);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(717, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sınav Sonuçları";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAllStudent
            // 
            this.btnAllStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllStudent.Location = new System.Drawing.Point(482, 44);
            this.btnAllStudent.Name = "btnAllStudent";
            this.btnAllStudent.Size = new System.Drawing.Size(135, 23);
            this.btnAllStudent.TabIndex = 8;
            this.btnAllStudent.Text = "Hepsini Getir";
            this.btnAllStudent.UseVisualStyleBackColor = true;
            this.btnAllStudent.Click += new System.EventHandler(this.btnAllStudent_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Location = new System.Drawing.Point(272, 43);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(162, 23);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Derse Göre Getir";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cmbOgr
            // 
            this.cmbOgr.FormattingEnabled = true;
            this.cmbOgr.Location = new System.Drawing.Point(96, 74);
            this.cmbOgr.Name = "cmbOgr";
            this.cmbOgr.Size = new System.Drawing.Size(121, 22);
            this.cmbOgr.TabIndex = 6;
            this.cmbOgr.SelectedIndexChanged += new System.EventHandler(this.cmbOgr_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Öğr. Seç  :";
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(96, 43);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(121, 22);
            this.cmbDers.TabIndex = 4;
            this.cmbDers.SelectedIndexChanged += new System.EventHandler(this.cmbDers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ders Seç  :";
            // 
            // cmbSınıf
            // 
            this.cmbSınıf.FormattingEnabled = true;
            this.cmbSınıf.Location = new System.Drawing.Point(96, 11);
            this.cmbSınıf.Name = "cmbSınıf";
            this.cmbSınıf.Size = new System.Drawing.Size(121, 22);
            this.cmbSınıf.TabIndex = 2;
            this.cmbSınıf.SelectedIndexChanged += new System.EventHandler(this.cmbSınıf_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sınıf Seç :";
            // 
            // listViewSonuclar
            // 
            this.listViewSonuclar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewSonuclar.FullRowSelect = true;
            this.listViewSonuclar.GridLines = true;
            this.listViewSonuclar.Location = new System.Drawing.Point(6, 102);
            this.listViewSonuclar.Name = "listViewSonuclar";
            this.listViewSonuclar.Size = new System.Drawing.Size(705, 206);
            this.listViewSonuclar.TabIndex = 0;
            this.listViewSonuclar.UseCompatibleStateImageBehavior = false;
            this.listViewSonuclar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Öğrenci";
            this.columnHeader1.Width = 202;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ders Adı";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 194;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sınav Tarihi";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 199;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Alınan Puan";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 106;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(717, 313);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "İstatistikler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(729, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raporlar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 96);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(428, 94);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Böyle birşey yok ya da olabilir de :)";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReportEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 358);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportEdit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewSonuclar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSınıf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOgr;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnAllStudent;
        private System.Windows.Forms.TextBox textBox1;
    }
}