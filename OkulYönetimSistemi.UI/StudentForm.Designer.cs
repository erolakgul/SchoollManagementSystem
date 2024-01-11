namespace OkulYönetimSistemi.UI
{
    partial class StudentForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnQuesSave = new System.Windows.Forms.Button();
            this.btnSınavBitir = new System.Windows.Forms.Button();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.bowWel = new System.Windows.Forms.GroupBox();
            this.txtQue = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listQue = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.bowWel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.bowWel);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(730, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSonuc);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.lblTime);
            this.groupBox4.Controls.Add(this.btnQuesSave);
            this.groupBox4.Controls.Add(this.btnSınavBitir);
            this.groupBox4.Controls.Add(this.rb4);
            this.groupBox4.Controls.Add(this.rb3);
            this.groupBox4.Controls.Add(this.rb2);
            this.groupBox4.Controls.Add(this.rb1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(2, 161);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(584, 195);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Şıklar";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(387, 171);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(35, 14);
            this.lblSonuc.TabIndex = 7;
            this.lblSonuc.Text = "....";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "d şıkkı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "c şıkkı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "b şıkkı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "a şıkkı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(256, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Süre:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(315, 164);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 24);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "60";
            // 
            // btnQuesSave
            // 
            this.btnQuesSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuesSave.Location = new System.Drawing.Point(13, 159);
            this.btnQuesSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuesSave.Name = "btnQuesSave";
            this.btnQuesSave.Size = new System.Drawing.Size(84, 34);
            this.btnQuesSave.TabIndex = 1;
            this.btnQuesSave.Text = "Kaydet";
            this.btnQuesSave.UseVisualStyleBackColor = true;
            this.btnQuesSave.Click += new System.EventHandler(this.btnQuesSave_Click);
            // 
            // btnSınavBitir
            // 
            this.btnSınavBitir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSınavBitir.Location = new System.Drawing.Point(137, 159);
            this.btnSınavBitir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSınavBitir.Name = "btnSınavBitir";
            this.btnSınavBitir.Size = new System.Drawing.Size(105, 34);
            this.btnSınavBitir.TabIndex = 1;
            this.btnSınavBitir.Text = "Sınavı Bitir";
            this.btnSınavBitir.UseVisualStyleBackColor = true;
            this.btnSınavBitir.Click += new System.EventHandler(this.btnSınavBitir_Click);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(13, 128);
            this.rb4.Margin = new System.Windows.Forms.Padding(2);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(14, 13);
            this.rb4.TabIndex = 0;
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(13, 95);
            this.rb3.Margin = new System.Windows.Forms.Padding(2);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(14, 13);
            this.rb3.TabIndex = 0;
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(13, 61);
            this.rb2.Margin = new System.Windows.Forms.Padding(2);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(14, 13);
            this.rb2.TabIndex = 0;
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(13, 26);
            this.rb1.Margin = new System.Windows.Forms.Padding(2);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(14, 13);
            this.rb1.TabIndex = 0;
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // bowWel
            // 
            this.bowWel.Controls.Add(this.txtQue);
            this.bowWel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bowWel.Location = new System.Drawing.Point(2, 16);
            this.bowWel.Margin = new System.Windows.Forms.Padding(2);
            this.bowWel.Name = "bowWel";
            this.bowWel.Padding = new System.Windows.Forms.Padding(13);
            this.bowWel.Size = new System.Drawing.Size(584, 145);
            this.bowWel.TabIndex = 1;
            this.bowWel.TabStop = false;
            // 
            // txtQue
            // 
            this.txtQue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQue.Location = new System.Drawing.Point(13, 27);
            this.txtQue.Margin = new System.Windows.Forms.Padding(2);
            this.txtQue.Name = "txtQue";
            this.txtQue.ReadOnly = true;
            this.txtQue.Size = new System.Drawing.Size(558, 105);
            this.txtQue.TabIndex = 0;
            this.txtQue.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listQue);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(586, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(142, 340);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sorular";
            // 
            // listQue
            // 
            this.listQue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listQue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listQue.FormattingEnabled = true;
            this.listQue.ItemHeight = 14;
            this.listQue.Location = new System.Drawing.Point(2, 16);
            this.listQue.Margin = new System.Windows.Forms.Padding(2);
            this.listQue.Name = "listQue";
            this.listQue.Size = new System.Drawing.Size(138, 322);
            this.listQue.TabIndex = 0;
            this.listQue.SelectedIndexChanged += new System.EventHandler(this.listQue_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 358);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.bowWel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnQuesSave;
        private System.Windows.Forms.Button btnSınavBitir;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.GroupBox bowWel;
        private System.Windows.Forms.RichTextBox txtQue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listQue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Timer timer1;
    }
}