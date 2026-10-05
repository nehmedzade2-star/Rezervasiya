namespace WinFormsApp5
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			textBox1 = new TextBox();
			maskedTextBox1 = new MaskedTextBox();
			label1 = new Label();
			label2 = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			button6 = new Button();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			timer1 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(189, 71);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(143, 23);
			textBox1.TabIndex = 0;
			textBox1.TextChanged += textBox1_TextChanged;
			textBox1.KeyPress += textBox1_KeyPress;
			// 
			// maskedTextBox1
			// 
			maskedTextBox1.Location = new Point(425, 71);
			maskedTextBox1.Mask = "999";
			maskedTextBox1.Name = "maskedTextBox1";
			maskedTextBox1.Size = new Size(159, 23);
			maskedTextBox1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.Control;
			label1.Location = new Point(189, 51);
			label1.Name = "label1";
			label1.Size = new Size(84, 17);
			label1.TabIndex = 2;
			label1.Text = "Ad və Soyad";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = SystemColors.Control;
			label2.Location = new Point(425, 51);
			label2.Name = "label2";
			label2.Size = new Size(112, 17);
			label2.TabIndex = 3;
			label2.Text = "Müddət (dəqiqə)";
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.Location = new Point(139, 161);
			button1.Name = "button1";
			button1.Size = new Size(113, 78);
			button1.TabIndex = 4;
			button1.Text = "Otaq 1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.Location = new Point(328, 161);
			button2.Name = "button2";
			button2.Size = new Size(113, 78);
			button2.TabIndex = 5;
			button2.Text = "Otaq 2";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button3.Location = new Point(504, 161);
			button3.Name = "button3";
			button3.Size = new Size(113, 78);
			button3.TabIndex = 6;
			button3.Text = "Otaq 3";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button4.Location = new Point(504, 295);
			button4.Name = "button4";
			button4.Size = new Size(113, 78);
			button4.TabIndex = 9;
			button4.Text = "Otaq 6";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button5.Location = new Point(328, 295);
			button5.Name = "button5";
			button5.Size = new Size(113, 78);
			button5.TabIndex = 8;
			button5.Text = "Otaq 5";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button6
			// 
			button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button6.Location = new Point(139, 295);
			button6.Name = "button6";
			button6.Size = new Size(113, 78);
			button6.TabIndex = 7;
			button6.Text = "Otaq 4";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = SystemColors.ButtonHighlight;
			label3.Location = new Point(189, 137);
			label3.Name = "label3";
			label3.Size = new Size(19, 21);
			label3.TabIndex = 10;
			label3.Text = "0";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = SystemColors.ButtonHighlight;
			label4.Location = new Point(378, 137);
			label4.Name = "label4";
			label4.Size = new Size(19, 21);
			label4.TabIndex = 11;
			label4.Text = "0";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = SystemColors.ButtonHighlight;
			label5.Location = new Point(550, 137);
			label5.Name = "label5";
			label5.Size = new Size(19, 21);
			label5.TabIndex = 12;
			label5.Text = "0";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = SystemColors.ButtonHighlight;
			label6.Location = new Point(189, 271);
			label6.Name = "label6";
			label6.Size = new Size(19, 21);
			label6.TabIndex = 15;
			label6.Text = "0";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.ForeColor = SystemColors.ButtonHighlight;
			label7.Location = new Point(378, 271);
			label7.Name = "label7";
			label7.Size = new Size(19, 21);
			label7.TabIndex = 14;
			label7.Text = "0";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.ForeColor = SystemColors.ButtonHighlight;
			label8.Location = new Point(550, 271);
			label8.Name = "label8";
			label8.Size = new Size(19, 21);
			label8.TabIndex = 13;
			label8.Text = "0";
			// 
			// timer1
			// 
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			ClientSize = new Size(800, 450);
			Controls.Add(label6);
			Controls.Add(label7);
			Controls.Add(label8);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(button4);
			Controls.Add(button5);
			Controls.Add(button6);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(maskedTextBox1);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private MaskedTextBox maskedTextBox1;
		private Label label1;
		private Label label2;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private System.Windows.Forms.Timer timer1;
	}
}
