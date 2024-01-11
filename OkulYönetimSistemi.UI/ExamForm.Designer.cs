namespace OkulYönetimSistemi.UI
{
    partial class ExamForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.boxWel = new System.Windows.Forms.GroupBox();
            this.lblSınav = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listExam = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boxWel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // boxWel
            // 
            this.boxWel.Controls.Add(this.lblSınav);
            this.boxWel.Controls.Add(this.label4);
            this.boxWel.Controls.Add(this.label3);
            this.boxWel.Controls.Add(this.lbltime);
            this.boxWel.Controls.Add(this.label2);
            this.boxWel.Controls.Add(this.label1);
            this.boxWel.Controls.Add(this.listExam);
            this.boxWel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxWel.Location = new System.Drawing.Point(0, 0);
            this.boxWel.Margin = new System.Windows.Forms.Padding(2);
            this.boxWel.Name = "boxWel";
            this.boxWel.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.boxWel.Size = new System.Drawing.Size(730, 358);
            this.boxWel.TabIndex = 1;
            this.boxWel.TabStop = false;
            // 
            // lblSınav
            // 
            this.lblSınav.AutoSize = true;
            this.lblSınav.Location = new System.Drawing.Point(550, 59);
            this.lblSınav.Name = "lblSınav";
            this.lblSınav.Size = new System.Drawing.Size(56, 14);
            this.lblSınav.TabIndex = 6;
            this.lblSınav.Text = ".......";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kalan Süre     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "En yakın sınav :";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(551, 85);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(56, 14);
            this.lbltime.TabIndex = 3;
            this.lbltime.Text = ".......";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sınavlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sınav zamanı geldiğinde otomatik olarak başlayacaktır lütfen bekleyiniz...";
            // 
            // listExam
            // 
            this.listExam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listExam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listExam.FullRowSelect = true;
            this.listExam.GridLines = true;
            this.listExam.Location = new System.Drawing.Point(6, 194);
            this.listExam.Margin = new System.Windows.Forms.Padding(2);
            this.listExam.MultiSelect = false;
            this.listExam.Name = "listExam";
            this.listExam.Size = new System.Drawing.Size(718, 158);
            this.listExam.TabIndex = 0;
            this.listExam.UseCompatibleStateImageBehavior = false;
            this.listExam.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sınav Adı";
            this.columnHeader1.Width = 195;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ders";
            this.columnHeader2.Width = 221;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih";
            this.columnHeader3.Width = 155;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Süre (dk)";
            this.columnHeader4.Width = 142;
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 358);
            this.Controls.Add(this.boxWel);
            this.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamForm";
            this.Load += new System.EventHandler(this.ExamForm_Load);
            this.boxWel.ResumeLayout(false);
            this.boxWel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox boxWel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listExam;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSınav;
    }
}