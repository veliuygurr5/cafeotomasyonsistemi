namespace cafeotomasyonsistemi
{
	partial class Form3
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(80, 32);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(886, 180);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(83, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kullanıcı Ekle";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(93, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(185, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Kullanıcı Güncelle";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(824, 303);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "Kullanıcı Sil";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(173, 95);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(144, 30);
			this.textBox1.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(164, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "isim ve soyisim:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(1, 92);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(164, 25);
			this.label5.TabIndex = 7;
			this.label5.Text = "isim ve soyisim:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(171, 89);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(144, 30);
			this.textBox2.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(15, 236);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(331, 269);
			this.panel1.TabIndex = 8;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(354, 237);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(366, 267);
			this.panel2.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(103, 512);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(165, 34);
			this.button1.TabIndex = 10;
			this.button1.Text = "Ekle";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(423, 510);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(200, 36);
			this.button2.TabIndex = 11;
			this.button2.Text = "Güncelle";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(783, 331);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(200, 36);
			this.button3.TabIndex = 12;
			this.button3.Text = "Sil";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(798, 510);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(200, 36);
			this.button4.TabIndex = 13;
			this.button4.Text = "Geri Dön";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(1080, 558);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}